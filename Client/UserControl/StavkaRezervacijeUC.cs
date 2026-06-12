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
    public partial class StavkaRezervacijeUC : System.Windows.Forms.UserControl
    {
        private StavkaRezervacijeControlor controlor;

        public DataGridView DgvStavkaRezervacije => dgvStavkaRezervacije;
        public ComboBox CmbSmestaj => cmbSmestaj;
        public DateTimePicker DatumPolaska => dtpDatumOd;
        public DateTimePicker DatumDolaska => dtpDatumDo;

        public int Kolicina
        {
            get => (int)numericKolicina.Value;
            set => numericKolicina.Value = value;
        }

        public string OpisStavke
        {
            get => txtOpisStavke.Text;
            set => txtOpisStavke.Text = value;
        }
        public StavkaRezervacijeUC(Rezervacija rezervacija)
        {
            InitializeComponent();
            controlor = new StavkaRezervacijeControlor(this, rezervacija);
            cmbSmestaj.SelectedIndexChanged += (s, e) => PrikaziCeneStavke();
            numericKolicina.ValueChanged += (s, e) => PrikaziCeneStavke();
            lblJedinicnaCena.Text = "0.00 RSD";
            lblUkupnaCena.Text = "0.00 RSD";

        }
        private void PrikaziCeneStavke()
        {
            if (cmbSmestaj.SelectedItem is Smestaj smestaj)
            {
                decimal jedinicnaCena = smestaj.Cena;
                decimal ukupnaCena = jedinicnaCena * Kolicina;

                lblJedinicnaCena.Text = jedinicnaCena.ToString("0.00") + " RSD";
                lblUkupnaCena.Text = ukupnaCena.ToString("0.00") + " RSD";
            }
            else
            {
                lblJedinicnaCena.Text = "0.00 RSD";
                lblUkupnaCena.Text = "0.00 RSD";
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controlor.DodajStavkuRezervacije();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controlor.ObrisiStavkuRezervacije();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            RezervacijaUC uc = new RezervacijaUC(controlor.rezervacija);
            main.ChangePanel(uc);
        }

        private void dgvStavkaRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controlor.OdabranaStavkaRezervacije();
        }
    }
}
