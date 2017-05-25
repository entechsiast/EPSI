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
            this.lbl_resultatCryptage.Location = new System.Drawing.Point(318, 108);
            this.lbl_resultatCryptage.Name = "lbl_resultatCryptage";
            this.lbl_resultatCryptage.Size = new System.Drawing.Size(111, 13);
            this.lbl_resultatCryptage.TabIndex = 6;
            this.lbl_resultatCryptage.Text = "Resultat du cryptage :";
            // 
            // lbl_RC
            // 
            this.lbl_RC.AutoSize = true;
            this.lbl_RC.Location = new System.Drawing.Point(435, 108);
            this.lbl_RC.Name = "lbl_RC";
            this.lbl_RC.Size = new System.Drawing.Size(14, 13);
            this.lbl_RC.TabIndex = 7;
            this.lbl_RC.Text = "X";
            // 
            // btn_crypter
            // 
            this.btn_crypter.Location = new System.Drawing.Point(327, 162);
            this.btn_crypter.Name = "btn_crypter";
            this.btn_crypter.Size = new System.Drawing.Size(75, 23);
            this.btn_crypter.TabIndex = 8;
            this.btn_crypter.Text = "Crypter";
            this.btn_crypter.UseVisualStyleBackColor = true;
            this.btn_crypter.Click += new System.EventHandler(this.btn_crypter_Click);
            // 
            // CodeCesarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(880, 473);
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
    }
}