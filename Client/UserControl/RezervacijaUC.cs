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
    public partial class RezervacijaUC : System.Windows.Forms.UserControl
    {
        private RezervacijaControlor controlor;
        public RezervacijaUC(Rezervacija rezervacija)
        {
            InitializeComponent();
            dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRezervacije.MultiSelect = false;
            controlor = new RezervacijaControlor(this, rezervacija ?? new Rezervacija());
        }
        public ComboBox CmbPutnikIzmeni => cmbPutnik;
        public ComboBox CmbAgentIzmeni => cmbAgent;
        public ComboBox CmbPutnikPretrazi => cmbPutnikPretrazi;
        public ComboBox CmbAgentPretrazi => cmbAgentPretrazi;
        public ComboBox CmbSmestajPretrazi => cmbSmestajPretrazi;
        public DataGridView DgvRezervacije => dgvRezervacije;
        public DataGridView DgvStavkeRezervacije => dgvStavkaRez;
        public decimal UkupanIznos
        {
            set => lblUkupanIznos.Text = value.ToString("0.00") + " RSD";
        }


        private void dgvRezervacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            controlor.OdabranaRezervacija();

        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            if (controlor.rezervacijaDTO == null || controlor.rezervacijaDTO.IdRezervacija == 0)
            {
                MessageBox.Show("Prvo izaberite rezervaciju!");
                return;
            }
            FrmMain main = (FrmMain)this.FindForm();
            StavkaRezervacijeUC uc = new StavkaRezervacijeUC(controlor.rezervacijaDTO);
            main.ChangePanel(uc);
        }

        private void btnKreirajRezervaciju_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            Rezervacija rez = controlor.KreirajRezervacija();
            KreirajRezervacijaUC uc = new KreirajRezervacijaUC(rez);
            main.ChangePanel(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cmbPutnikPretrazi.SelectedIndex = -1;
            controlor.SearchRezervacija();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cmbAgentPretrazi.SelectedIndex = -1;
            controlor.SearchRezervacija();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CmbSmestajPretrazi.SelectedIndex = -1;
            controlor.SearchRezervacija();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controlor.SearchRezervacija();
        }
    }
}
