﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPNote2022_05_05.Modele
{
    public class SousFormulaire
    {

        public Panel PanelSousFormlaire;
        public Form activeForm = null;

        public SousFormulaire(Panel panelenvoit)
        {
            PanelSousFormlaire = panelenvoit;
        }

        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            PanelSousFormlaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }



    }
}
