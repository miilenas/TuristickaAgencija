using Client.UserControl;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControlor
{
    public class KreirajRezervacijaControlor
    {
        private KreirajRezervacijaUC rezervacijaUC;
        private List<StavkaRezervacije> uneteStavkeRezervacije;
        private Rezervacija rezervacija;

        public KreirajRezervacijaControlor(KreirajRezervacijaUC rezervacijaUC, Rezervacija kreiranaRezervacija)
        {
            this.rezervacijaUC = rezervacijaUC;
            this.rezervacija = kreiranaRezervacija ?? new Rezervacija();
            this.uneteStavkeRezervacije = new List<StavkaRezervacije>();

            VratiListuSviAgent();
            VratiListuSviPutnik();
            VratiListuSviSmestaj();

            rezervacijaUC.UkupanIznos = 0;
        }

        public void UbaciStavkuRezervacije()
        {
            if (rezervacijaUC.CmbSmestaj.SelectedIndex == -1 ||
                rezervacijaUC.Kolicina <= 0 ||
                String.IsNullOrWhiteSpace(rezervacijaUC.OpisStavke) ||
                rezervacijaUC.DatePolazak.Value >= rezervacijaUC.DateDolazak.Value)
            {
                MessageBox.Show("Sistem ne moze da sacuva stavku rezervacije!");
                return;
            }

            Smestaj smestaj = (Smestaj)rezervacijaUC.CmbSmestaj.SelectedItem;

            decimal jedinicnaCena = smestaj.Cena;
            int kolicina = rezervacijaUC.Kolicina;
            decimal ukupnaCena = jedinicnaCena * kolicina;

            StavkaRezervacije stavka = new StavkaRezervacije()
            {
                IdRezervacija = rezervacija.IdRezervacija,
                Rb = uneteStavkeRezervacije.Count + 1,
                IdSmestaj = smestaj,
                JedinicnaCena = jedinicnaCena,
                Kolicina = kolicina,
                UkupnaCena = ukupnaCena,
                OpisStavke = rezervacijaUC.OpisStavke,
                DatumPolaska = DateOnly.FromDateTime(rezervacijaUC.DatePolazak.Value),
                DatumDolaska = DateOnly.FromDateTime(rezervacijaUC.DateDolazak.Value)
            };

            uneteStavkeRezervacije.Add(stavka);

            DGV(uneteStavkeRezervacije);
            rezervacijaUC.UkupanIznos = IzracunajUkupanIznos();
        }

        public void ZapamtiRezervacija()
        {
            if (rezervacijaUC.CmbAgent.SelectedIndex == -1 ||
                rezervacijaUC.CmbPutnik.SelectedIndex == -1 ||
                uneteStavkeRezervacije.Count == 0)
            {
                MessageBox.Show(
                    "Potrebno je izabrati agenta, putnika i uneti bar jednu stavku rezervacije!",
                    "Niste popunili sva polja",
                    MessageBoxButtons.OK
                );
                return;
            }

            rezervacija.Agent = (Agent)rezervacijaUC.CmbAgent.SelectedItem;
            rezervacija.Putnik = (Putnik)rezervacijaUC.CmbPutnik.SelectedItem;
            rezervacija.UkupanIznos = IzracunajUkupanIznos();
            rezervacija.stavkaRezervacijeList = uneteStavkeRezervacije;

            Response response = Communication.Instance.CreateRezervacija(rezervacija);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je zapamtio rezervaciju.");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
            }
        }

        private decimal IzracunajUkupanIznos()
        {
            return uneteStavkeRezervacije.Sum(s => s.UkupnaCena);
        }

        private void DGV(List<StavkaRezervacije> stavke)
        {
            rezervacijaUC.DgvStavkeRezervacije.DataSource = null;
            rezervacijaUC.DgvStavkeRezervacije.DataSource = stavke;

            SakrijKolonu("IdRezervacija");
            SakrijKolonu("TableName");
            SakrijKolonu("Values");
            SakrijKolonu("IdCondition");
            SakrijKolonu("Update");
            SakrijKolonu("FullName");
        }

        private void SakrijKolonu(string nazivKolone)
        {
            if (rezervacijaUC.DgvStavkeRezervacije.Columns.Contains(nazivKolone))
            {
                rezervacijaUC.DgvStavkeRezervacije.Columns[nazivKolone].Visible = false;
            }
        }

        private void VratiListuSviSmestaj()
        {
            try
            {
                List<Smestaj> smestaji = Communication.Instance.VratiListuSviSmestaj();

                rezervacijaUC.CmbSmestaj.DataSource = smestaji;
                rezervacijaUC.CmbSmestaj.ValueMember = "IdSmestaj";
                rezervacijaUC.CmbSmestaj.DisplayMember = "FullName";
                rezervacijaUC.CmbSmestaj.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita smestaje.");
            }
        }

        private void VratiListuSviPutnik()
        {
            try
            {
                List<Putnik> putnici = (List<Putnik>)Communication.Instance.VratiListuSviPutnik();

                rezervacijaUC.CmbPutnik.DataSource = putnici;
                rezervacijaUC.CmbPutnik.ValueMember = "IdPutnik";
                rezervacijaUC.CmbPutnik.DisplayMember = "FullName";
                rezervacijaUC.CmbPutnik.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita putnike.");
            }
        }

        private void VratiListuSviAgent()
        {
            try
            {
                List<Agent> agenti = (List<Agent>)Communication.Instance.VratiListuSviAgent();

                rezervacijaUC.CmbAgent.DataSource = agenti;
                rezervacijaUC.CmbAgent.ValueMember = "IdAgent";
                rezervacijaUC.CmbAgent.DisplayMember = "FullName";
                rezervacijaUC.CmbAgent.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita agente.");
            }
        }

        public Putnik kreirajPutnik()
        {
            return new Putnik();
            //Response response = Communication.Instance.CreatePutnik(new Putnik());

            //if (response.IsSuccess)
            //{
            //    MessageBox.Show("Sistem je kreirao putnika");
            //}
            //else
            //{
            //    MessageBox.Show("Sistem ne moze da kreira putnika");
            //}
            //return (Putnik)response.Result;
        }

    }
}