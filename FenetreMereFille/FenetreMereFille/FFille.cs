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
    public partial class FFille : Form
    {
        private string monNom;
        private Fmere maMere;
        public FFille(Fmere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            this.Load+=new EventHandler(FFille_Load);
        }

        private void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur : " + this.monNom);
        } 
        private void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le nom de la mere est :"+maMere.GetNomMere);
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            monNom = tb1.Text;
            this.Text = tb1.Text;
            this.maMere.MaFilleChangeDeNom(this, monNom);
        }

        
    }
}
