using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Media;
using System.IO;

namespace Cryptogram
{
    public partial class Form_Cryptogram : Form
    {
        public Form_Cryptogram()
        {
            InitializeComponent();
        }

        #region Les différents évènements

        /// <summary>
        /// Au chargement de l'application
        /// </summary>
        private void Form_Cryptogram_Load(object sender, EventArgs e)
        {
            button_Decrypt.Enabled = false;
            button_Encrypt.Enabled = false;
        }

        /// <summary>
        /// Lors du clic sur le bouton Encrypt
        /// </summary>
        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            bool checkpass = PassOK();
            if (checkpass == true)
            {
                Chiffrer();
                pictureBox_Lock.Image = Cryptogram.Properties.Resources.Lockit;     // On change l'image du cadenas
                playSound();
            }
        }

        /// <summary>
        /// Lors du clic sur le bouton Decrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            bool checkpass = PassOK();
            if (checkpass == true)
            {
                Dechiffrer();
                if (textBox_DecryptedText.Text != "")
                {
                    pictureBox_Lock.Image = Cryptogram.Properties.Resources.Unlockit;       // On change l'image du cadenas
                    playSound();
                }
            }
        }

        /// <summary>
        /// Lors du clic dans le menu sur About the encryption
        /// </summary>
        private void aboutTheEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rijndael est l'algorithme utilisé par Cryptogram pour le chiffrement AES (\"Advanced Encryption Standard\").\nCet algorithme utilise des clés de 128, 196 ou 256 bits et une taille fixe de blocs de 128 bits. Advanced Encryption Standard fut pour le gouvernement américain le successeur de DES qui datait des années 70. Jusqu'à aujourd'hui l'algorithme Rijndael d'AES n'a pas été cassé.");
        }

        /// <summary>
        /// Quand le texte change dans la textbox normal
        /// </summary>
        private void textBox_DecryptedText_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_DecryptedText.Text == null) || (textBox_DecryptedText.Text == ""))
            {
                button_Encrypt.Enabled = false;
            }
            else
            {
                button_Encrypt.Enabled = true;
            }
        }

        /// <summary>
        /// Quand le texte change dans la textbox chiffré 
        /// </summary>
        private void textBox_EncryptedText_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_EncryptedText.Text == null) || (textBox_EncryptedText.Text == ""))
            {
                button_Decrypt.Enabled = false;
            }
            else
            {
                button_Decrypt.Enabled = true;
            }
        }

        /// <summary>
        /// Lors du clic sur Chiffrer un fichier texte
        /// </summary>
        private void encryptAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiffrerFichierTexte();
        }
        #endregion

        #region Les procédures servant au chiffrement
        /// <summary>
        /// Chiffre une chaîne de caractère
        /// </summary>
        /// <param name="texteClair">Texte à chiffrer</param>
        /// <param name="list">Liste de tableau d'octet contenant clé et vecteur</param>
        /// <returns>Retourne le texte chiffré</returns>
        private static string ChiffreTexte(string texteClair, List<byte[]> list)
        {
            // Place le texte à chiffrer dans un tableau d'octets
            byte[] texteEnClair = Encoding.UTF8.GetBytes(texteClair);

            // Place la clé de chiffrement dans un tableau d'octets
            byte[] cleChiffrement = list[0];

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] initVecteur = list[1];

            RijndaelManaged rijndael = new RijndaelManaged();

            // Définit le mode utilisé
            rijndael.Mode = CipherMode.CBC;

            // Crée le chiffreur AES - Rijndael
            ICryptoTransform aesEncryptor = rijndael.CreateEncryptor(cleChiffrement, initVecteur);

            // A COMPLETER
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            // Ecris les données chiffrées dans le MemoryStream
            CryptoStream cs = new CryptoStream(ms, aesEncryptor, CryptoStreamMode.Write);
            cs.Write(texteEnClair, 0, texteEnClair.Length);
            cs.FlushFinalBlock();

            // Place les données chiffrées dans un tableau d'octet
            byte[] bytesChiffre = ms.ToArray();

            ms.Close();
            cs.Close();

            // Place les données chiffrées dans une chaine encodée en Base64
            return Convert.ToBase64String(bytesChiffre);
        }

        /// <summary>
        /// Déchiffre une chaîne de caractère
        /// </summary>
        /// <param name="texteChiffre">Texte chiffré</param>
        /// <param name="list">Liste de tableau de byte contenant clé et vecteur</param>
        /// <returns>Retourne le texte déchiffré</returns>
        private static string DecryptString(string texteChiffre, List<byte[]> list)
        {
            try
            {
                // Place le texte à déchiffrer dans un tableau d'octets
                byte[] donneeChiffre = Convert.FromBase64String(texteChiffre);

                // Place la clé de déchiffrement dans un tableau d'octets
                byte[] cleChiffrement = list[0];

                // Place le vecteur d'initialisation dans un tableau d'octets
                byte[] initVecteur = list[1];

                RijndaelManaged rijndael = new RijndaelManaged();

                // Définit le mode utilisé
                rijndael.Mode = CipherMode.CBC;

                // Ecris les données déchiffrées dans le MemoryStream
                ICryptoTransform decryptor = rijndael.CreateDecryptor(cleChiffrement, initVecteur);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(donneeChiffre);
                CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

                // Place les données déchiffrées dans un tableau d'octet
                byte[] donneeDechiffre = new byte[donneeChiffre.Length];

                int cptByteDechiffre = cs.Read(donneeDechiffre, 0, donneeDechiffre.Length);

                ms.Close();
                cs.Close();

                return Encoding.UTF8.GetString(donneeDechiffre, 0, cptByteDechiffre);
            }
            catch (Exception)
            {
                MessageBox.Show("Le texte chiffré ou le mot de passe est faux.\nEtes-vous sur de votre mot de passe?\nAvez-vous copié correctement le texte chiffré?", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Procédure pour obtenir une clé et un vecteur d'initialisation à l'aide d'un mot de passe défini par l'utilisateur
        /// </summary>
        /// <param name="password">Le mot de passe défini par l'utilisateur</param>
        private static List<byte[]> GenerateAlgotihmInputs(string password)
        {
            byte[] key;             // La clé de chiffrement
            byte[] initVector;      // Le vecteur d'initialisation

            List<byte[]> result = new List<byte[]>();       // On crée une liste de table de bytes

            Rfc2898DeriveBytes rfcDb = new Rfc2898DeriveBytes(password, System.Text.Encoding.UTF8.GetBytes(password));

            key = rfcDb.GetBytes(16);
            initVector = rfcDb.GetBytes(16);

            result.Add(key);
            result.Add(initVector);

            return result;
        }

        /// <summary>
        /// Procédure permettant la lecture, le chiffrement et l'écriture d'un nouveau fichier texte chiffré
        /// </summary>
        /// <param name="list">Liste de tableau de byte contenant clé et vecteur</param>
        /// <param name="cheminFichierTexte">Chemin vers le fichier texte non chiffré</param>
        /// <param name="cheminFichierTexteChiffre">Chemin vers le fichier texte non chiffré</param>
        public static void ChiffrerFichierTexte(List<byte[]> list, string cheminFichierTexte, string cheminFichierTexteChiffre)
        {
            // Place la clé de déchiffrement dans un tableau d'octets
            byte[] cleChiffrement = list[0];

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] initVecteur = list[1];

            FileStream fsFichierChiffre = new FileStream(cheminFichierTexteChiffre, FileMode.Create);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;
            rijndael.Key = cleChiffrement;
            rijndael.IV = initVecteur;

            ICryptoTransform aesEncryptor = rijndael.CreateEncryptor();

            CryptoStream cs = new CryptoStream(fsFichierChiffre, aesEncryptor, CryptoStreamMode.Write);

            FileStream fsFichierDechiffre = new FileStream(cheminFichierTexte, FileMode.OpenOrCreate);

            int data;

            while ((data = fsFichierDechiffre.ReadByte()) != -1)
            {
                cs.WriteByte((byte)data);
            }

            fsFichierDechiffre.Close();
            cs.Close();
            fsFichierChiffre.Close();
        }


        /// <summary>
        /// Procédure regroupant les actions servant au chiffrement de la textbox
        /// </summary>
        private void Chiffrer()
        {
            List<byte[]> cleVecteur = new List<byte[]>();       // On crée une table de bytes
            cleVecteur = GenerateAlgotihmInputs(textBox_Password.Text); // On recupère la clé et le vecteur depuis le mot de passe
            textBox_EncryptedText.Text = ChiffreTexte(textBox_DecryptedText.Text, cleVecteur); // On chiffre le texte
            textBox_DecryptedText.Clear();      // On efface le texte non chiffré 
        }

        /// <summary>
        /// Procédure regroupant les actions servant au déchiffrement de la texbox
        /// </summary>
        private void Dechiffrer()
        {
            List<byte[]> result = new List<byte[]>();       // On crée une table de bytes
            result = GenerateAlgotihmInputs(textBox_Password.Text); // On recupère la clé et le vecteur depuis le mot de passe
            textBox_DecryptedText.Text = DecryptString(textBox_EncryptedText.Text, result); // On déchiffre le texte chiffré
            textBox_EncryptedText.Clear();        //On efface le texte chiffré
        }
        #endregion

        /// <summary>
        /// Fonction vérifiant la longueur du mot de passe
        /// </summary>
        /// <returns>Vrai ou faux selon la longueur du mot de passe</returns>
        private bool PassOK()
        {
            bool checkpass;
            int MiniCharPass = 8;        // Minimun de caractères pour un mot de passe
            if (textBox_Password.TextLength < MiniCharPass)
            {
                checkpass = false;
                MessageBox.Show("Le mot de passe n'est pas assez long.\nMinimum de 8 caractères!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                checkpass = true;
            }
            return checkpass;
        }

        /// <summary>
        /// Fonction permettant de jouer un son
        /// </summary>
        private void playSound()
        {
            SoundPlayer lockedSound = new SoundPlayer(Cryptogram.Properties.Resources.tick);
            lockedSound.Play();
        }

        /// <summary>
        /// Procédure récupérant le chemin du fichier texte à chiffrer
        /// </summary>
        /// <param name="cheminFichierClair"></param>
        private void ObtenirCheminFichierTexte(out string cheminFichierClair)
        {
            OpenFileDialog ofd = new OpenFileDialog();      //On ouvre une fenêtre de sélection du fichier
            ofd.Filter = "Only Text Files (*.txt)|*.txt";   // On filtre selon l'extension
            ofd.Multiselect = false;                        // On empêche la sélection multiple de fichier

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cheminFichierClair = ofd.FileName;
            }
            else
            {
                cheminFichierClair = string.Empty;
            }
        }

        /// <summary>
        /// Procédure permettant le chiffrement d'un fichier texte
        /// </summary>
        private void ChiffrerFichierTexte()
        {
            string cheminFichierEnClair;
            string cheminFichierChiffre;
            string test;
            ObtenirCheminFichierTexte(out cheminFichierEnClair);
            test = cheminFichierEnClair.Substring(0, cheminFichierEnClair.Length - 3);
            cheminFichierChiffre = test + "Encrypted.txt";
            List<byte[]> cleVecteur = new List<byte[]>();       // On crée une table de bytes
            cleVecteur = GenerateAlgotihmInputs(textBox_Password.Text); // On recupère la clé et le vecteur depuis le mot de passe
            ChiffrerFichierTexte(cleVecteur, cheminFichierEnClair, cheminFichierChiffre);
        }

    }
}
