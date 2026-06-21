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

        public bool ZapamtiPutnik()
        {
            if (putnik == null ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.Ime) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.Prezime) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.BrojTelefona) ||
               String.IsNullOrWhiteSpace(kreirajPutnikUC.BrojPasosa) ||
               kreirajPutnikUC.CmbMesto.SelectedIndex == -1) 
            {
                MessageBox.Show("Sistem ne moze da zapamti putnika", "Greska");
                return false;
            }

            putnik.Ime = kreirajPutnikUC.Ime;
            putnik.Prezime = kreirajPutnikUC.Prezime;
            putnik.BrojTelefona = kreirajPutnikUC.BrojTelefona;
            putnik.BrojPasosa = kreirajPutnikUC.BrojPasosa;
            putnik.IdMesto = (Mesto)kreirajPutnikUC.CmbMesto.SelectedItem;

            if (!PasosJeJedinstven(putnik.BrojPasosa))
            {
                MessageBox.Show("Broj pasosa mora biti jedinstven.", "Greska");
                return false;
            }

            Response response = Communication.Instance.CreatePutnik(putnik);

            if (response.IsSuccess)
            {
                putnik = (Putnik)response.Result;
                MessageBox.Show("Sistem je zapamtio putnika.");
                return true;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti putnika", "Greska");
                return false;
            }
        }

        private void VratiMesto()
        {
            List<Mesto> mesta = (List<Mesto>)Communication.Instance.VratiListuSviMesto();

            if (mesta == null || mesta.Count == 0)
            {
                MessageBox.Show("Greska!Nema unetih mesta!", "Greska");
                return;
            }

            kreirajPutnikUC.CmbMesto.DataSource = mesta;
            kreirajPutnikUC.CmbMesto.ValueMember = "IdMesto";
            kreirajPutnikUC.CmbMesto.DisplayMember = "FullName";
            kreirajPutnikUC.CmbMesto.SelectedIndex = -1;
        }

        private bool PasosJeJedinstven(string brojPasosa)
        {
            List<Putnik> putnici = (List<Putnik>)Communication.Instance.VratiListuSviPutnik();

            if (putnici == null)
            {
                return false;
            }

            return !putnici.Any(p => p.BrojPasosa.Equals(brojPasosa, StringComparison.OrdinalIgnoreCase));
        }
    }


}
