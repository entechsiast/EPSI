namespace Encodeur.View.Code_Cesar
{
    partial class CodeCesarView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_txtCrypter = new System.Windows.Forms.Label();
            this.TBox_crypter = new System.Windows.Forms.TextBox();
            this.lbl_cle = new System.Windows.Forms.Label();
            this.TBox_cle = new System.Windows.Forms.TextBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.TBox_modulo = new System.Windows.Forms.TextBox();
            this.lbl_resultatCryptage = new System.Windows.Forms.Label();
            this.lbl_RC = new System.Windows.Forms.Label();
            this.btn_crypter = new System.Windows.Forms.Button();
            this.btn_decryptage = new System.Windows.Forms.Button();
            this.lbl_ResultatDecryptage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox_moduloDecryptage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBox_cleDecryptage = new System.Windows.Forms.TextBox();
            this.lbl_décryptage = new System.Windows.Forms.Label();
            this.Tbox_Décryptage = new System.Windows.Forms.TextBox();
            this.lbl_decrypter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_txtCrypter
            // 
            this.lbl_txtCrypter.AutoSize = true;
            this.lbl_txtCrypter.Location = new System.Drawing.Point(94, 39);
            this.lbl_txtCrypter.Name = "lbl_txtCrypter";
            this.lbl_txtCrypter.Size = new System.Drawing.Size(84, 13);
            this.lbl_txtCrypter.TabIndex = 0;
            this.lbl_txtCrypter.Text = "Texte a crypter :";
            // 
            // TBox_crypter
            // 
            this.TBox_crypter.Location = new System.Drawing.Point(185, 39);
            this.TBox_crypter.Name = "TBox_crypter";
            this.TBox_crypter.Size = new System.Drawing.Size(100, 20);
            this.TBox_crypter.TabIndex = 1;
            // 
            // lbl_cle
            // 
            this.lbl_cle.AutoSize = true;
            this.lbl_cle.Location = new System.Drawing.Point(318, 39);
            this.lbl_cle.Name = "lbl_cle";
            this.lbl_cle.Size = new System.Drawing.Size(84, 13);
            this.lbl_cle.TabIndex = 2;
            this.lbl_cle.Text = "Clé de cryptage:";
            // 
            // TBox_cle
            // 
            this.TBox_cle.Location = new System.Drawing.Point(408, 39);
            this.TBox_cle.Name = "TBox_cle";
            this.TBox_cle.Size = new System.Drawing.Size(100, 20);
            this.TBox_cle.TabIndex = 3;
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Location = new System.Drawing.Point(532, 42);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(48, 13);
            this.lbl_modulo.TabIndex = 4;
            this.lbl_modulo.Text = "Modulo :";
            // 
            // TBox_modulo
            // 
            this.TBox_modulo.Location = new System.Drawing.Point(586, 42);
            this.TBox_modulo.Name = "TBox_modulo";
            this.TBox_modulo.Size = new System.Drawing.Size(100, 20);
            this.TBox_modulo.TabIndex = 5;
            // 
            // lbl_resultatCryptage
            // 
            this.lbl_resultatCryptage.AutoSize = true;
            this.lbl_resultatCryptage.Location = new System.Drawing.Point(318, 85);
            this.lbl_resultatCryptage.Name = "lbl_resultatCryptage";
            this.lbl_resultatCryptage.Size = new System.Drawing.Size(111, 13);
            this.lbl_resultatCryptage.TabIndex = 6;
            this.lbl_resultatCryptage.Text = "Resultat du cryptage :";
            // 
            // lbl_RC
            // 
            this.lbl_RC.AutoSize = true;
            this.lbl_RC.Location = new System.Drawing.Point(435, 85);
            this.lbl_RC.Name = "lbl_RC";
            this.lbl_RC.Size = new System.Drawing.Size(14, 13);
            this.lbl_RC.TabIndex = 7;
            this.lbl_RC.Text = "X";
            // 
            // btn_crypter
            // 
            this.btn_crypter.Location = new System.Drawing.Point(327, 112);
            this.btn_crypter.Name = "btn_crypter";
            this.btn_crypter.Size = new System.Drawing.Size(75, 23);
            this.btn_crypter.TabIndex = 8;
            this.btn_crypter.Text = "Crypter";
            this.btn_crypter.UseVisualStyleBackColor = true;
            this.btn_crypter.Click += new System.EventHandler(this.btn_crypter_Click);
            // 
            // btn_decryptage
            // 
            this.btn_decryptage.Location = new System.Drawing.Point(327, 285);
            this.btn_decryptage.Name = "btn_decryptage";
            this.btn_decryptage.Size = new System.Drawing.Size(75, 23);
            this.btn_decryptage.TabIndex = 17;
            this.btn_decryptage.Text = "Décrypter";
            this.btn_decryptage.UseVisualStyleBackColor = true;
            this.btn_decryptage.Click += new System.EventHandler(this.btn_decryptage_Click);
            // 
            // lbl_ResultatDecryptage
            // 
            this.lbl_ResultatDecryptage.AutoSize = true;
            this.lbl_ResultatDecryptage.Location = new System.Drawing.Point(435, 258);
            this.lbl_ResultatDecryptage.Name = "lbl_ResultatDecryptage";
            this.lbl_ResultatDecryptage.Size = new System.Drawing.Size(14, 13);
            this.lbl_ResultatDecryptage.TabIndex = 16;
            this.lbl_ResultatDecryptage.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resultat du décryptage :";
            // 
            // TBox_moduloDecryptage
            // 
            this.TBox_moduloDecryptage.Location = new System.Drawing.Point(586, 215);
            this.TBox_moduloDecryptage.Name = "TBox_moduloDecryptage";
            this.TBox_moduloDecryptage.Size = new System.Drawing.Size(100, 20);
            this.TBox_moduloDecryptage.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Modulo :";
            // 
            // TBox_cleDecryptage
            // 
            this.TBox_cleDecryptage.Location = new System.Drawing.Point(408, 212);
            this.TBox_cleDecryptage.Name = "TBox_cleDecryptage";
            this.TBox_cleDecryptage.Size = new System.Drawing.Size(100, 20);
            this.TBox_cleDecryptage.TabIndex = 12;
            // 
            // lbl_décryptage
            // 
            this.lbl_décryptage.AutoSize = true;
            this.lbl_décryptage.Location = new System.Drawing.Point(306, 212);
            this.lbl_décryptage.Name = "lbl_décryptage";
            this.lbl_décryptage.Size = new System.Drawing.Size(96, 13);
            this.lbl_décryptage.TabIndex = 11;
            this.lbl_décryptage.Text = "Clé de décryptage:";
            // 
            // Tbox_Décryptage
            // 
            this.Tbox_Décryptage.Location = new System.Drawing.Point(185, 212);
            this.Tbox_Décryptage.Name = "Tbox_Décryptage";
            this.Tbox_Décryptage.Size = new System.Drawing.Size(100, 20);
            this.Tbox_Décryptage.TabIndex = 10;
            // 
            // lbl_decrypter
            // 
            this.lbl_decrypter.AutoSize = true;
            this.lbl_decrypter.Location = new System.Drawing.Point(83, 215);
            this.lbl_decrypter.Name = "lbl_decrypter";
            this.lbl_decrypter.Size = new System.Drawing.Size(96, 13);
            this.lbl_decrypter.TabIndex = 9;
            this.lbl_decrypter.Text = "Texte a décrypter :";
            // 
            // CodeCesarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(786, 414);
            this.Controls.Add(this.btn_decryptage);
            this.Controls.Add(this.lbl_ResultatDecryptage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox_moduloDecryptage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBox_cleDecryptage);
            this.Controls.Add(this.lbl_décryptage);
            this.Controls.Add(this.Tbox_Décryptage);
            this.Controls.Add(this.lbl_decrypter);
            this.Controls.Add(this.btn_crypter);
            this.Controls.Add(this.lbl_RC);
            this.Controls.Add(this.lbl_resultatCryptage);
            this.Controls.Add(this.TBox_modulo);
            this.Controls.Add(this.lbl_modulo);
            this.Controls.Add(this.TBox_cle);
            this.Controls.Add(this.lbl_cle);
            this.Controls.Add(this.TBox_crypter);
            this.Controls.Add(this.lbl_txtCrypter);
            this.Name = "CodeCesarView";
            this.Text = "Code Cesar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txtCrypter;
        private System.Windows.Forms.TextBox TBox_crypter;
        private System.Windows.Forms.Label lbl_cle;
        private System.Windows.Forms.TextBox TBox_cle;
        private System.Windows.Forms.Label lbl_modulo;
        private System.Windows.Forms.TextBox TBox_modulo;
        private System.Windows.Forms.Label lbl_resultatCryptage;
        private System.Windows.Forms.Label lbl_RC;
        private System.Windows.Forms.Button btn_crypter;
        private System.Windows.Forms.Button btn_decryptage;
        private System.Windows.Forms.Label lbl_ResultatDecryptage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBox_moduloDecryptage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBox_cleDecryptage;
        private System.Windows.Forms.Label lbl_décryptage;
        private System.Windows.Forms.TextBox Tbox_Décryptage;
        private System.Windows.Forms.Label lbl_decrypter;
    }
}