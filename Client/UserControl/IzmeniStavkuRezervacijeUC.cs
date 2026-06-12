using Client.GUIControlor;
using Common.Domain;

namespace Client.UserControl
{
    public partial class IzmeniStavkuRezervacijeUC : System.Windows.Forms.UserControl
    {
        private IzmeniStavkuRezervacijeControlor controlor;

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

        public decimal JedinicnaCena
        {
            set => lblJedinicnaCena.Text = value.ToString("0.00");
        }

        public decimal UkupnaCena
        {
            set => lblUkupnaCena.Text = value.ToString("0.00");
        }

        public IzmeniStavkuRezervacijeUC(Rezervacija rezervacija, StavkaRezervacije stavka)
        {
            InitializeComponent();

            controlor = new IzmeniStavkuRezervacijeControlor(this, rezervacija, stavka);

            cmbSmestaj.SelectedIndexChanged += (s, e) => controlor.IzracunajCenu();
            numericKolicina.ValueChanged += (s, e) => controlor.IzracunajCenu();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controlor.IzmeniStavku();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            FrmMain main = (FrmMain)this.FindForm();
            main.ChangePanel(new RezervacijaUC(controlor.Rezervacija));
        }
    }
}
