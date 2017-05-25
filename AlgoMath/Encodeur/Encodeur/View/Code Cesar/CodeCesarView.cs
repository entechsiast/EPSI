using Encodeur.Controller.CodeCesarController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encodeur.View.Code_Cesar
{
    public partial class CodeCesarView : Form
    {
        public CodeCesarView()
        {
            InitializeComponent();
        }

        private void btn_crypter_Click(object sender, EventArgs e)
        {
            lbl_RC.Text = fonctions.chiffrer(TBox_crypter.Text, int.Parse(TBox_cle.Text), int.Parse(TBox_modulo.Text));
        }

        private void btn_decryptage_Click(object sender, EventArgs e)
        {
            lbl_ResultatDecryptage.Text = fonctions.dechiffrer(Tbox_Décryptage.Text, int.Parse(TBox_cleDecryptage.Text), int.Parse(TBox_moduloDecryptage.Text));
        }
    }
}
