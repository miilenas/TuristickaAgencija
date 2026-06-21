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
    public partial class PutnikUC : System.Windows.Forms.UserControl
    {
        PutnikControlor controlor;
        public PutnikUC()
        {
            InitializeComponent();

            //disable pre nego sto se izabere putnik iz dgv
            groupBox1.Enabled = false;

            cmbMestoPretrazi.DropDownStyle=ComboBoxStyle.DropDownList;


            controlor = new PutnikControlor(this);
        }

        public string Ime
        {
            get => txtIme.Text;
            set => txtIme.Text = value;
        }
        public string Prezime
        {
            get => txtPrezime.Text;
            set => txtPrezime.Text = value;
        }
        public string BrojTelefona
        {
            get => txtBrojTelefona.Text;
            set => txtBrojTelefona.Text = value;
        }
        public string BrojPasosa
        {
            get => txtBrojPasosa.Text;
            set => txtBrojPasosa.Text = value;
        }
        public ComboBox CmbMesto => cmbMesto;

        public string ImePretrazi
        {
            get => txtImePretrazi.Text;
            set => txtImePretrazi.Text = value;
        }

        public string PrezimePretrazi
        {
            get => txtPrezimePretrazi.Text;
            set => txtPrezimePretrazi.Text = value;
        }

        public string BrojTelefonaPretrazi
        {
            get => txtBrojTelefonaPretrazi.Text;
            set => txtBrojTelefonaPretrazi.Text = value;
        }

        public string BrojPasosaPretrazi
        {
            get => txtBrojPasosaPretrazi.Text;
            set => txtBrojPasosaPretrazi.Text = value;
        }

        public ComboBox CmbMestoPretrazi => cmbMestoPretrazi;

        public DataGridView DgvSviPutnici => dgvSviPutnici;

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controlor.UpdatePutnik();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controlor.DeletePutnik();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            Putnik putnik = controlor.CreatePutnik();
            if (putnik == null)
            {
                return;
            }

            KreirajPutnikUC uc = new KreirajPutnikUC(putnik);
            main.ChangePanel(uc);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controlor.SearchPutnik();
        }
        private void dgvSviPutnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            controlor.OdabraniPutnik();
            groupBox1.Enabled = true;
        }

        private void btnOcistiIme_Click(object sender, EventArgs e)
        {
            txtImePretrazi.Text = "";
            controlor.SearchPutnik();
        }

        private void btnOcistiPrezime_Click(object sender, EventArgs e)
        {
            txtPrezimePretrazi.Text = "";
            controlor.SearchPutnik();
        }

        private void btnOcistiBrojTelefona_Click(object sender, EventArgs e)
        {
            txtBrojTelefonaPretrazi.Text = "";
            controlor.SearchPutnik();
        }

        private void btnOcistiBrojPasosa_Click(object sender, EventArgs e)
        {
            txtBrojPasosaPretrazi.Text = "";
            controlor.SearchPutnik();
        }

        private void btnOcistiMesto_Click(object sender, EventArgs e)
        {
            cmbMestoPretrazi.SelectedIndex = -1;
            controlor.SearchPutnik();
        }
    }
}
