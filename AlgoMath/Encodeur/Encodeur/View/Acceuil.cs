using Encodeur.View.Code_Cesar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encodeur
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void codeDeCesarMenuClick_Click(object sender, EventArgs e)
        {

        }

        private void crypterMenuItem_Click(object sender, EventArgs e)
        {
            CodeCesarView nouvelleFeuilleMDI = new CodeCesarView();
            // Set the Parent Form of the Child window.
            nouvelleFeuilleMDI.MdiParent = this;
            // Display the new form.  
            nouvelleFeuilleMDI.Show();
        }
    }
}
