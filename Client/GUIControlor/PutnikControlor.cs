using Client.UserControl;
using Common.Communication;
using Common.Domain;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIControlor
{
    internal class PutnikControlor
    {
        private List<Mesto> svaMesta = new List<Mesto>();
        private PutnikUC putnikUC;

        public PutnikControlor(PutnikUC putnikUC)
        {
            this.putnikUC = putnikUC;
            this.UcitajPretraziMestoCMB(this.VratiListuSviMesto());
            this.UcitajIzmeniMestoCMB(this.VratiListuSviMesto());
            this.DGV(this.VratiListuSviPutnik());
        }

        internal void UpdatePutnik()
        {
            if (Validacija())
            {
                Putnik putnik = new Putnik()
                {
                    IdPutnik = Convert.ToInt32(putnikUC.DgvSviPutnici.SelectedRows[0].Cells["IdPutnik"].Value),
                    Ime = putnikUC.Ime,
                    Prezime = putnikUC.Prezime,
                    BrojTelefona = putnikUC.BrojTelefona,
                    BrojPasosa = putnikUC.BrojPasosa,
                    IdMesto = (Mesto)putnikUC.CmbMesto.SelectedItem
                };

                Response response = Communication.Instance.UpdatePutnik(putnik);

                if (response.IsSuccess)
                {
                    MessageBox.Show("Sistem je izmenio putnika.");
                    putnikUC.DgvSviPutnici.DataSource = null;
                    DGV(VratiListuSviPutnik());
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da izmeni putnika.");
                }
            }
        }

        internal void DeletePutnik()
        {
            if (this.Validacija())
            {
                Putnik putnik = this.OdabraniPutnik();

                if (putnik != null)
                {
                    Response response = Communication.Instance.DeletePutnik(putnik);

                    if (response.IsSuccess)
                    {
                        MessageBox.Show("Sistem je obrisao putnika.");
                        putnikUC.DgvSviPutnici.DataSource = null;
                        DGV(VratiListuSviPutnik());
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da obrise putnika.");
                    }
                }
            }
        }

        internal void SearchPutnik()
        {
            bool nemaKriterijuma =
                String.IsNullOrWhiteSpace(putnikUC.ImePretrazi) &&
                String.IsNullOrWhiteSpace(putnikUC.PrezimePretrazi) &&
                String.IsNullOrWhiteSpace(putnikUC.BrojTelefonaPretrazi) &&
                String.IsNullOrWhiteSpace(putnikUC.BrojPasosaPretrazi) &&
                putnikUC.CmbMestoPretrazi.SelectedIndex == -1;

            if (nemaKriterijuma)
            {
                OsveziPutnike();
                return;
            }

            KriterijumPutnik kriterijum = new KriterijumPutnik();

            if (!String.IsNullOrWhiteSpace(putnikUC.ImePretrazi))
            {
                kriterijum.Ime = putnikUC.ImePretrazi;
            }

            if (!String.IsNullOrWhiteSpace(putnikUC.PrezimePretrazi))
            {
                kriterijum.Prezime = putnikUC.PrezimePretrazi;
            }

            if (!String.IsNullOrWhiteSpace(putnikUC.BrojTelefonaPretrazi))
            {
                kriterijum.BrojTelefona = putnikUC.BrojTelefonaPretrazi;
            }

            if (!String.IsNullOrWhiteSpace(putnikUC.BrojPasosaPretrazi))
            {
                kriterijum.BrojPasosa = putnikUC.BrojPasosaPretrazi;
            }

            if (putnikUC.CmbMestoPretrazi.SelectedIndex != -1)
            {
                kriterijum.Mesto = (Mesto)putnikUC.CmbMestoPretrazi.SelectedItem;
            }

            Response response = Communication.Instance.SearchPutnik(kriterijum);

            if (response.IsSuccess)
            {
                List<Putnik> rezultat = (List<Putnik>)response.Result;
                putnikUC.DgvSviPutnici.DataSource = null;
                DGV(rezultat);

                MessageBox.Show("Sistem je nasao putnike po zadatim kriterijumima.");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da nadje putnike po zadatim kriterijumima.");
            }
        }
        internal void OsveziPutnike()
        {
            putnikUC.DgvSviPutnici.DataSource = null;
            DGV(VratiListuSviPutnik());
        }

        public Putnik CreatePutnik()
        {
            return new Putnik();

            //Response response = Communication.Instance.CreatePutnik(new Putnik());

            //if (response.IsSuccess)
            //{
            //    MessageBox.Show("Sistem je kreirao putnika.");
            //}
            //else
            //{
            //    MessageBox.Show("Sistem ne moze da kreira putnika. >>> " + response.ExceptionMessage);
            //}

            //return (Putnik)response.Result;
        }

        public void UcitajPretraziMestoCMB(List<Mesto> mesta)
        {
            if (mesta == null || mesta.Count == 0)
            {
                MessageBox.Show("Greska! Nema unetih mesta!", "Greska");
                return;
            }

            putnikUC.CmbMestoPretrazi.DataSource = mesta;
            putnikUC.CmbMestoPretrazi.ValueMember = "IdMesto";
            putnikUC.CmbMestoPretrazi.DisplayMember = "FullName";
            putnikUC.CmbMestoPretrazi.SelectedIndex = -1;
        }

        public void UcitajIzmeniMestoCMB(List<Mesto> mesta)
        {
            if (mesta == null || mesta.Count == 0)
            {
                MessageBox.Show("Greska! Nema unetih mesta!", "Greska");
                return;
            }

            putnikUC.CmbMesto.DataSource = mesta;
            putnikUC.CmbMesto.ValueMember = "IdMesto";
            putnikUC.CmbMesto.DisplayMember = "FullName";
            putnikUC.CmbMesto.SelectedIndex = -1;
        }

        private void DGV(List<Putnik> putnici)
        {
            List<Mesto> mesta = this.VratiListuSviMesto();

            if (putnici == null)
            {
                return;
            }

            foreach (Putnik p in putnici)
            {
                foreach (Mesto m in mesta)
                {
                    if (p.IdMesto.IdMesto.Equals(m.IdMesto))
                    {
                        p.IdMesto = m;
                    }
                }
            }

            putnikUC.DgvSviPutnici.DataSource = putnici;
            putnikUC.DgvSviPutnici.Columns["IdMesto"].HeaderText = "Mesto";

            putnikUC.DgvSviPutnici.Columns["IdPutnik"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["IdColumn"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["TableName"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["Values"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["IdCondition"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["Update"].Visible = false;
            putnikUC.DgvSviPutnici.Columns["FullName"].Visible = false;
        }

        private bool Validacija()
        {
            if (String.IsNullOrWhiteSpace(putnikUC.Ime) ||
                String.IsNullOrWhiteSpace(putnikUC.Prezime) ||
                String.IsNullOrWhiteSpace(putnikUC.BrojTelefona) ||
                String.IsNullOrWhiteSpace(putnikUC.BrojPasosa) ||
                putnikUC.CmbMesto.SelectedIndex == -1 ||
                putnikUC.DgvSviPutnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo Vas izaberite putnika i popunite sva polja.", "Greska");
                return false;
            }

            return true;
        }

        private List<Putnik> VratiListuSviPutnik()
        {
            List<Putnik> putnici = (List<Putnik>)Communication.Instance.VratiListuSviPutnik();
            return putnici;
        }

        private List<Mesto> VratiListuSviMesto()
        {
            List<Mesto> mesta = Communication.Instance.VratiListuSviMesto();
            return mesta;
        }

        public Putnik OdabraniPutnik()
        {
            Putnik putnik = new Putnik();

            try
            {
                putnik = (Putnik)putnikUC.DgvSviPutnici.SelectedRows[0].DataBoundItem;

                putnikUC.Ime = putnik.Ime;
                putnikUC.Prezime = putnik.Prezime;
                putnikUC.BrojTelefona = putnik.BrojTelefona;
                putnikUC.BrojPasosa = putnik.BrojPasosa;
                putnikUC.CmbMesto.SelectedValue = putnik.IdMesto.IdMesto;

                //MessageBox.Show("Sistem je nasao putnika.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da nadje putnika.");
            }

            return putnik;
        }
    }
}
