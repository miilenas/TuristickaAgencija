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

            try
            {
                putnik.Ime = kreirajPutnikUC.Ime.Trim();
            putnik.Prezime = kreirajPutnikUC.Prezime.Trim();
            putnik.BrojTelefona = kreirajPutnikUC.BrojTelefona.Trim();
            putnik.BrojPasosa = kreirajPutnikUC.BrojPasosa.Trim();
            putnik.IdMesto = (Mesto)kreirajPutnikUC.CmbMesto.SelectedItem;

          
                Response response = Communication.Instance.CreatePutnik(putnik);

                if (response.IsSuccess)
                {
                    putnik = (Putnik)response.Result;
                    MessageBox.Show("Sistem je zapamtio putnika.");
                    return true;
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(response.ExceptionMessage))
                    {
                        MessageBox.Show(response.ExceptionMessage, "Greska");
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da zapamti putnika", "Greska");
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
                return false;
            }

        }

        private void VratiMesto()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
        }
    }


}
