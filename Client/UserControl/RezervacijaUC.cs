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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cmbAgent.Enabled = false;
            cmbPutnik.Enabled = false;
            //da ne moze da se kuca tekst u cmbbox
            cmbAgentPretrazi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPutnikPretrazi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSmestajPretrazi.DropDownStyle = ComboBoxStyle.DropDownList;

            //unable korisnika da selektuje pojedinacnu celiju ili vise opcija
            dgvStavkaRez.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavkaRez.MultiSelect = false;

            controlor = new RezervacijaControlor(this, rezervacija ?? new Rezervacija());
        }
        public System.Windows.Forms.ComboBox CmbPutnikIzmeni => cmbPutnik;
        public System.Windows.Forms.ComboBox CmbAgentIzmeni => cmbAgent;
        public System.Windows.Forms.ComboBox CmbPutnikPretrazi => cmbPutnikPretrazi;
        public System.Windows.Forms.ComboBox CmbAgentPretrazi => cmbAgentPretrazi;
        public System.Windows.Forms.ComboBox CmbSmestajPretrazi => cmbSmestajPretrazi;
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
            DodajStavkuRezervacijeUC uc = new DodajStavkuRezervacijeUC(controlor.rezervacijaDTO);
            main.ChangePanel(uc);
        }

        private void btnKreirajRezervaciju_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            Rezervacija kreiranaRezervacija = controlor.KreirajRezervacija();
            if (kreiranaRezervacija == null)
            {
                return;
            }

            KreirajRezervacijaUC uc = new KreirajRezervacijaUC(kreiranaRezervacija);
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

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            //ako nije izabrana stavka iz dgvStavkaRez, ispsie se poruka da mora da se izabere stavka
            if (dgvStavkaRez.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati stavku za brisanje!", "Greška");
                return;
            }

            StavkaRezervacije stavka = (StavkaRezervacije)dgvStavkaRez.SelectedRows[0].DataBoundItem;
            controlor.ObrisiStavku(stavka);

        }

        private void btnIzmeniStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavkaRez.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati stavku za izmenu!", "Greška");
                return;
            }

            FrmMain main = (FrmMain)this.FindForm();
            Rezervacija rez =(Rezervacija) dgvRezervacije.SelectedRows[0].DataBoundItem;
            StavkaRezervacije stavka= (StavkaRezervacije)dgvStavkaRez.SelectedRows[0].DataBoundItem;
            IzmeniStavkuRezervacijeUC uc = new IzmeniStavkuRezervacijeUC(rez,stavka);
            main.ChangePanel(uc);

        }
    }
}
