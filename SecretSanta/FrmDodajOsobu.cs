using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSanta
{
    public partial class FrmDodajOsobu : Form
    {
        private SantasHelper santasHelper;
        public FrmDodajOsobu(SantasHelper helper)
        {
            InitializeComponent();
            santasHelper = helper;
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if(txtIme.Text == "" || txtPrezime.Text == "")
            {
                MessageBox.Show("Unesite ime i prezime");
                return;
            }
            else
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                santasHelper.DodajOsobu(ime, prezime);
                this.Close();
            }
        }
    }
}
