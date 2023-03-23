using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPNote2022_05_05.Modele;

namespace TPNote2022_05_05
{
    public partial class Menu : Form
    {
        SousFormulaire SF;
        public Menu()
        {
            InitializeComponent();
            SF = new SousFormulaire(pn_SousFormulaire);
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new CmdVoiture());
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF.openChildForm(new ListeCmd());
        }
    }
}
