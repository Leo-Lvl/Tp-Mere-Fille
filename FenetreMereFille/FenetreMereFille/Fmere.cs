using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FenetreMereFille
{
    public partial class Fmere : Form
    {
        public Fmere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click+=new EventHandler(btnHide_Click);
            btnShowDialog.Click+=new EventHandler(btnShowDialog_Click);
            
            btnNew.Click +=new EventHandler(btnNew_Click_Message);
        }
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            IbLesFilles.Items.Add("Fille n°" + this.nombreFille);

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (IbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[IbLesFilles.SelectedIndex].Show();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (IbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[IbLesFilles.SelectedIndex].Hide();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (IbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[IbLesFilles.SelectedIndex].ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.lesFilles[IbLesFilles.SelectedIndex].Close();
            lesFilles.RemoveAt(IbLesFilles.SelectedIndex);
            IbLesFilles.Items.RemoveAt(IbLesFilles.SelectedIndex);

        }

        private void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }



        public string GetNomMere
        {
            get
            {
                return nomMere;
            }
        }

        public void MaFilleChangeDeNom(FFille fille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(fille);

            if (position != -1)
            {
                lesFilles[position] = fille;
                IbLesFilles.Items[position] = nouveauNom;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {

        }

    }
}
