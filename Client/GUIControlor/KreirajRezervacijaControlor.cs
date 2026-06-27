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
            this.uneteStavkeRezervacije = new List<StavkaRezervacije>();

            VratiListuSviAgent();
            VratiListuSviPutnik();
            VratiListuSviSmestaj();

            this.rezervacija = kreiranaRezervacija;

            rezervacijaUC.UkupanIznos = 0;
        }

        public void UbaciStavkuRezervacije()
        {
            if (rezervacija == null)
            {
                MessageBox.Show("Sistem ne moze da kreira rezervaciju");
                return;
            }

            if (rezervacijaUC.CmbSmestaj.SelectedIndex == -1 ||
                rezervacijaUC.Kolicina <= 0 ||
                String.IsNullOrWhiteSpace(rezervacijaUC.OpisStavke) ||
                rezervacijaUC.DatePolazak.Value >= rezervacijaUC.DateDolazak.Value)
            {
                MessageBox.Show("Sistem ne moze da sacuva stavku rezervacije!");
                return;
            }
            DateTime datumOd = rezervacijaUC.DatePolazak.Value.Date;
            DateTime datumDo = rezervacijaUC.DateDolazak.Value.Date;

            int brojNocenja = (datumDo - datumOd).Days;

            if (brojNocenja <= 0)
            {
                MessageBox.Show("Datum dolaska mora biti posle datuma polaska.");
                return;
            }

            if (brojNocenja != rezervacijaUC.Kolicina)
            {
                MessageBox.Show("Kolicina mora odgovarati broju nocenja.");
                return;
            }

            Smestaj smestaj = (Smestaj)rezervacijaUC.CmbSmestaj.SelectedItem;

            decimal jedinicnaCena = smestaj.Cena;
            int kolicina = rezervacijaUC.Kolicina;
            decimal ukupnaCena = jedinicnaCena * kolicina;

            StavkaRezervacije stavka = new StavkaRezervacije()
            {
                IdRezervacija = 0,
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
            rezervacijaUC.OcistiFormuZaStavku();
        }

        public bool ZapamtiRezervacija()
        {
            if (rezervacija == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
                return false;
            }

            if (rezervacijaUC.CmbAgent.SelectedIndex == -1 ||
                rezervacijaUC.CmbPutnik.SelectedIndex == -1 ||
                uneteStavkeRezervacije.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
                return false;
            }

            rezervacija.Agent = (Agent)rezervacijaUC.CmbAgent.SelectedItem;
            rezervacija.Putnik = (Putnik)rezervacijaUC.CmbPutnik.SelectedItem;
            rezervacija.UkupanIznos = IzracunajUkupanIznos();
            rezervacija.stavkaRezervacijeList = uneteStavkeRezervacije;
            try
            {
                Response response = Communication.Instance.CreateRezervacija(rezervacija);

                if (response.IsSuccess)
                {
                    rezervacija = (Rezervacija)response.Result;
                    MessageBox.Show("Sistem je zapamtio rezervaciju.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
                return false;
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

            rezervacijaUC.DgvStavkeRezervacije.Columns["IdSmestaj"].HeaderText = "Smestaj";
            rezervacijaUC.DgvStavkeRezervacije.Columns["OpisStavke"].HeaderText = "Opis stavke";
            rezervacijaUC.DgvStavkeRezervacije.Columns["DatumPolaska"].HeaderText = "Datum polaska";
            rezervacijaUC.DgvStavkeRezervacije.Columns["DatumDolaska"].HeaderText = "Datum dolaska";
            rezervacijaUC.DgvStavkeRezervacije.Columns["UkupnaCena"].HeaderText = "Ukupna cena";
            rezervacijaUC.DgvStavkeRezervacije.Columns["JedinicnaCena"].HeaderText = "Jedinicna cena";

            SakrijKolonu("IdRezervacija");
            SakrijKolonu("TableName");
            SakrijKolonu("Values");
            SakrijKolonu("IdCondition");
            SakrijKolonu("IdColumn");
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
            try
            {
                Response response = Communication.Instance.CreatePutnik(new Putnik());

                if (response.IsSuccess)
                {
                    MessageBox.Show("Sistem je kreirao putnika");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da kreira putnika");
                }
                return (Putnik)response.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
                return null;
            }
            
        }

    }
}
