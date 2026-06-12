using Client.UserControl;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIControlor
{
    public class KreirajPutnikControler
    {
        private KreirajPutnikUC kreirajPutnikUC;
        private Putnik putnik;
        public KreirajPutnikControler(KreirajPutnikUC kreirajPutnikUC, Putnik putnik)
        {
            this.kreirajPutnikUC = kreirajPutnikUC;
            this.VratiMesto();
            this.putnik = putnik;
        }

        public void ZapamtiPutnik()
        {
            if (String.IsNullOrWhiteSpace(kreirajPutnikUC.Ime) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.Prezime) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.BrojTelefona) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.BrojPasosa) ||
               kreirajPutnikUC.CmbMesto.SelectedIndex == -1) 
            {
                MessageBox.Show("Molimo Vas popunite sva polja", "Niste popunili sva polja", MessageBoxButtons.OK);
                return;
            }
            putnik.Ime = kreirajPutnikUC.Ime;
            putnik.Prezime = kreirajPutnikUC.Prezime;
            putnik.BrojTelefona = kreirajPutnikUC.BrojTelefona;
            putnik.BrojPasosa = kreirajPutnikUC.BrojPasosa;
            putnik.IdMesto = (Mesto)kreirajPutnikUC.CmbMesto.SelectedItem;

            Response response = Communication.Instance.CreatePutnik(putnik);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je kreirao putnika");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da kreira putnika");
            }
        }

        private void VratiMesto()
        {
            List<Mesto> mesta = (List<Mesto>)Communication.Instance.VratiListuSviMesto();

            if (mesta == null || mesta.Count == 0)
            {
                MessageBox.Show("Greska!Nema unetih mesta!", "Greska");
            }

            kreirajPutnikUC.CmbMesto.DataSource = mesta;
            kreirajPutnikUC.CmbMesto.ValueMember = "IdMesto";
            kreirajPutnikUC.CmbMesto.DisplayMember = "FullName";
            kreirajPutnikUC.CmbMesto.SelectedIndex = -1;
        }
    }


}
