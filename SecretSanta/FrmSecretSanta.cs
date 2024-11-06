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
    public partial class FrmSecretSanta : Form
    {
        private SantasHelper helper;
        private bool SecretSantaDodjela = true;
        public FrmSecretSanta()
        {
            InitializeComponent();
            helper = new SantasHelper();
            dgvOsobe.DataSource = helper.Osobe;
            dgvOsobe.Columns["ImaSantu"].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (SecretSantaDodjela)
            {
                FrmDodajOsobu dodajOsobu = new FrmDodajOsobu(helper);
                dodajOsobu.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Dodjela je počela, više ne možete dodavati ljude.");
                return;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (SecretSantaDodjela)
            {
                if(dgvOsobe.CurrentRow != null) 
                {
                    string ime = dgvOsobe.CurrentRow.Cells[0].Value?.ToString();
                    string prezime = dgvOsobe.CurrentRow.Cells[1].Value?.ToString();
                    helper.ObrisiOsobu(ime, prezime);
                }

                else
                {
                    MessageBox.Show("Odaberite osobu koju želite obrisati.");
                }
            }
            else
            {
                MessageBox.Show("Dodjela je počela, više ne možete brisati ljude.");
                return;
            }
        }

        private void btnDodjeli_Click(object sender, EventArgs e)
        {
            if (helper.Osobe.Count <= 2)
            {
                MessageBox.Show("Secret santa treba imati najmanje troje ljudi!");
                return;
            }

            SecretSantaDodjela = false;
            if(dgvOsobe.CurrentRow != null)
            {
                string ime = dgvOsobe.CurrentRow.Cells[0].Value?.ToString();
                string prezime = dgvOsobe.CurrentRow.Cells[1].Value?.ToString();
                Osoba secretSanta = helper.DodjeliSantu(ime, prezime);
                if(secretSanta == null)
                {
                    MessageBox.Show("Ova osoba je već dobila secret santu.");
                    return;
                }

                string imeSante = secretSanta.Ime.ToString();
                string prezimeSante = secretSanta.Prezime.ToString();
                MessageBox.Show(ime + " " + prezime + " tvoj secret santa je " + imeSante + " " + prezimeSante);
                
                if (helper.Slobodni.Count == 0)
                {
                    MessageBox.Show("Čestitamo, svi ste dobili secret santu!!!");
                    this.Close(); return;
                }
                return;
            }

        }
    }
}
