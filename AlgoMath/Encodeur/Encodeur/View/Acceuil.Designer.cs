namespace Encodeur
{
    partial class Acceuil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.codeDeCesarMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.crypterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeDeCesarMenuClick});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // codeDeCesarMenuClick
            // 
            this.codeDeCesarMenuClick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crypterMenuItem});
            this.codeDeCesarMenuClick.Name = "codeDeCesarMenuClick";
            this.codeDeCesarMenuClick.Size = new System.Drawing.Size(93, 20);
            this.codeDeCesarMenuClick.Text = "Code de cesar";
            this.codeDeCesarMenuClick.Click += new System.EventHandler(this.codeDeCesarMenuClick_Click);
            // 
            // crypterMenuItem
            // 
            this.crypterMenuItem.Name = "crypterMenuItem";
            this.crypterMenuItem.Size = new System.Drawing.Size(169, 22);
            this.crypterMenuItem.Text = "Crypter/Decrypter";
            this.crypterMenuItem.Click += new System.EventHandler(this.crypterMenuItem_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceuil";
            this.Text = "Encodeur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem codeDeCesarMenuClick;
        private System.Windows.Forms.ToolStripMenuItem crypterMenuItem;
    }
}

