using Client.GUIControlor;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControl
{
    public partial class KreirajRezervacijaUC : System.Windows.Forms.UserControl
    {
        KreirajRezervacijaControlor controlor;
        public KreirajRezervacijaUC(Rezervacija rez)
        {
           

            InitializeComponent();
            controlor = new KreirajRezervacijaControlor(this, rez);
            cmbSmestaj.SelectedIndexChanged += (s, e) => PrikaziCeneStavke();
            numKolicina.ValueChanged += (s, e) => PrikaziCeneStavke();


            lblJedinicnaCenaStavke.Text = "0.00 RSD";
            lblUkupnaCenaStavke.Text = "0.00 RSD";
            lblUkupanIznos.Text = "0.00 RSD";
        }

        public ComboBox CmbSmestaj => cmbSmestaj;
        public ComboBox CmbPutnik => cmbPutnik;
        public ComboBox CmbAgent => cmbAgent;
        public DateTimePicker DateDolazak => dateDolazak;
        public DateTimePicker DatePolazak => datePolazak;

        public DataGridView DgvStavkeRezervacije => dgvStavkeRezervacije;

        public string OpisStavke => txtOpis.Text;

        public int Kolicina => (int)numKolicina.Value;

        public decimal UkupanIznos
        {
            set => lblUkupanIznos.Text = value.ToString("0.00") + " RSD";
        }

        private void PrikaziCeneStavke()
        {
            if (cmbSmestaj.SelectedItem is Smestaj smestaj)
            {
                decimal jedinicnaCena = smestaj.Cena;
                decimal ukupnaCena = jedinicnaCena * Kolicina;

                lblJedinicnaCenaStavke.Text = jedinicnaCena.ToString("0.00") +" RSD";
                lblUkupnaCenaStavke.Text = ukupnaCena.ToString("0.00") + " RSD";
            }
            else
            {
                lblJedinicnaCenaStavke.Text = "0.00 RSD";
                lblUkupnaCenaStavke.Text = "0.00 RSD";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            controlor.UbaciStavkuRezervacije();

        }

        private void btnKreirajPutnika_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            KreirajPutnikUC uc = new KreirajPutnikUC(controlor.kreirajPutnik());
            main.ChangePanel(uc);
        }

        private void btnSacuvajRezervaciju_Click(object sender, EventArgs e)
        {
            controlor.ZapamtiRezervacija();
        }
    }
}
