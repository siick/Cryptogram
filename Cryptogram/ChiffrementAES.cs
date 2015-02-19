using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Media;
using System.IO;

// Préparation pour mettre les méthodes de chiffrement dans une autre classe à part. Work In Progress.
// Le programme n'utilise pas encore cette classe.
namespace Cryptogram
{
    class ChiffrementAES
    {

        public static void DehiffrerFichierTexte(List<byte[]> list, string cheminFichierTexteChiffrer, string cheminFichierTexteDechiffre)
        {
            // Place la clé de déchiffrement dans un tableau d'octets
            byte[] cle = list[0];

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] initVecteur = list[1];

            // Filestream du nouveau fichier qui sera déchiffré  
            FileStream fsCrypt = new FileStream(cheminFichierTexteDechiffre, FileMode.Create);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;
            rijndael.Key = cle;
            rijndael.IV = initVecteur;

            ICryptoTransform aesDecryptor = rijndael.CreateDecryptor();

            CryptoStream cs = new CryptoStream(fsCrypt, aesDecryptor, CryptoStreamMode.Write);

            // FileStream du fichier qui est chiffré.    
            FileStream fsIn = new FileStream(cheminFichierTexteChiffrer, FileMode.OpenOrCreate);

            int data;

            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);
            cs.Close();
            fsIn.Close();
            fsCrypt.Close();
        }
    }
}
