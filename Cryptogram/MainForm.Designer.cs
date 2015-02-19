namespace Cryptogram
{
    partial class Form_Cryptogram
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cryptogram));
            this.textBox_DecryptedText = new System.Windows.Forms.TextBox();
            this.textBox_EncryptedText = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_DecryptedText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Lock = new System.Windows.Forms.PictureBox();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCryptogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lock)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_DecryptedText
            // 
            this.textBox_DecryptedText.Location = new System.Drawing.Point(13, 204);
            this.textBox_DecryptedText.Multiline = true;
            this.textBox_DecryptedText.Name = "textBox_DecryptedText";
            this.textBox_DecryptedText.Size = new System.Drawing.Size(262, 407);
            this.textBox_DecryptedText.TabIndex = 0;
            this.textBox_DecryptedText.TextChanged += new System.EventHandler(this.textBox_DecryptedText_TextChanged);
            // 
            // textBox_EncryptedText
            // 
            this.textBox_EncryptedText.Location = new System.Drawing.Point(658, 204);
            this.textBox_EncryptedText.Multiline = true;
            this.textBox_EncryptedText.Name = "textBox_EncryptedText";
            this.textBox_EncryptedText.Size = new System.Drawing.Size(262, 407);
            this.textBox_EncryptedText.TabIndex = 3;
            this.textBox_EncryptedText.TextChanged += new System.EventHandler(this.textBox_EncryptedText_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(337, 178);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(280, 20);
            this.textBox_Password.TabIndex = 1;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(395, 157);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(162, 18);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Type your password here";
            // 
            // label_DecryptedText
            // 
            this.label_DecryptedText.AutoSize = true;
            this.label_DecryptedText.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecryptedText.Location = new System.Drawing.Point(12, 183);
            this.label_DecryptedText.Name = "label_DecryptedText";
            this.label_DecryptedText.Size = new System.Drawing.Size(246, 18);
            this.label_DecryptedText.TabIndex = 5;
            this.label_DecryptedText.Text = "Type or paste your decrypted text here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type or paste your encrypted text here";
            // 
            // pictureBox_Lock
            // 
            this.pictureBox_Lock.Image = global::Cryptogram.Properties.Resources.Unlockit;
            this.pictureBox_Lock.Location = new System.Drawing.Point(408, 345);
            this.pictureBox_Lock.Name = "pictureBox_Lock";
            this.pictureBox_Lock.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_Lock.TabIndex = 7;
            this.pictureBox_Lock.TabStop = false;
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Encrypt.Location = new System.Drawing.Point(408, 223);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(128, 49);
            this.button_Encrypt.TabIndex = 2;
            this.button_Encrypt.Text = "Encrypt >";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Decrypt.Location = new System.Drawing.Point(408, 536);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(128, 49);
            this.button_Decrypt.TabIndex = 9;
            this.button_Decrypt.Text = "< Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(932, 24);
            this.menuStrip_Main.TabIndex = 10;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptAFileToolStripMenuItem,
            this.decryptAFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // encryptAFileToolStripMenuItem
            // 
            this.encryptAFileToolStripMenuItem.Name = "encryptAFileToolStripMenuItem";
            this.encryptAFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.encryptAFileToolStripMenuItem.Text = "Encrypt a text file";
            this.encryptAFileToolStripMenuItem.Click += new System.EventHandler(this.encryptAFileToolStripMenuItem_Click);
            // 
            // decryptAFileToolStripMenuItem
            // 
            this.decryptAFileToolStripMenuItem.Name = "decryptAFileToolStripMenuItem";
            this.decryptAFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.decryptAFileToolStripMenuItem.Text = "Decrypt a text file";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheEncryptionToolStripMenuItem,
            this.aboutCryptogramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTheEncryptionToolStripMenuItem
            // 
            this.aboutTheEncryptionToolStripMenuItem.Name = "aboutTheEncryptionToolStripMenuItem";
            this.aboutTheEncryptionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutTheEncryptionToolStripMenuItem.Text = "About the encryption";
            this.aboutTheEncryptionToolStripMenuItem.Click += new System.EventHandler(this.aboutTheEncryptionToolStripMenuItem_Click);
            // 
            // aboutCryptogramToolStripMenuItem
            // 
            this.aboutCryptogramToolStripMenuItem.Name = "aboutCryptogramToolStripMenuItem";
            this.aboutCryptogramToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutCryptogramToolStripMenuItem.Text = "About Cryptogram";
            // 
            // Form_Cryptogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(932, 623);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.pictureBox_Lock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_DecryptedText);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_EncryptedText);
            this.Controls.Add(this.textBox_DecryptedText);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_Cryptogram";
            this.Text = "Cryptogram";
            this.Load += new System.EventHandler(this.Form_Cryptogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lock)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DecryptedText;
        private System.Windows.Forms.TextBox textBox_EncryptedText;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_DecryptedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Lock;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCryptogramToolStripMenuItem;
    }
}

