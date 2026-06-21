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
    public partial class KreirajPutnikUC : System.Windows.Forms.UserControl
    {
       private KreirajPutnikControler controlor;
        public KreirajPutnikUC(Putnik putnik)
        {
            InitializeComponent();

            controlor = new KreirajPutnikControler(this, putnik);
           

    }
        public ComboBox CmbMesto
        {
            get { return cmbMesto; }
        }

        public string Ime => txtIme.Text;
        public string Prezime => txtPrezime.Text;
        public string BrojTelefona => txtBrojTelefona.Text;
        public string BrojPasosa => txtBrojPasosa.Text;

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (controlor.ZapamtiPutnik())
            {
                FrmMain main = (FrmMain)this.FindForm();
                PutnikUC uc = new PutnikUC();
                main.ChangePanel(uc);
            }
        }
    }
}
