using Client.UserControl;
using Common.Communication;
using Common.Domain;
using Common.Model;

namespace Client.GUIControlor
{
    public class RezervacijaControlor
    {
        private RezervacijaUC rezervacijaUC;
        public Rezervacija rezervacijaDTO;

        public RezervacijaControlor(RezervacijaUC rezervacijaUC, Rezervacija rezervacija)
        {
            this.rezervacijaUC = rezervacijaUC;

            this.UcitajPretraziPutnikCMB(this.VratiListuSviPutnik());
            this.UcitajIzmeniPutnikCMB(this.VratiListuSviPutnik());

            this.UcitajPretraziAgentCMB(this.VratiListuSviAgent());
            this.UcitajIzmeniAgentCMB(this.VratiListuSviAgent());

            this.UcitajCmbSmestaj();
            this.DGV(this.VratiListuSviRezervacija());

            this.rezervacijaDTO = rezervacija;

            if (rezervacijaDTO != null && rezervacijaDTO.IdRezervacija != 0)
            {
                this.OdabranaRezervacija(rezervacijaDTO);
            }
        }

        public RezervacijaControlor()
        {
        }

        public List<Putnik> VratiListuSviPutnik()
        {
            List<Putnik> putnici = Communication.Instance.VratiListuSviPutnik();
            return putnici;
        }

        public void UcitajPretraziPutnikCMB(List<Putnik> putnici)
        {
            if (putnici == null || putnici.Count == 0)
            {
                return;
            }

            rezervacijaUC.CmbPutnikPretrazi.DataSource = putnici;
            rezervacijaUC.CmbPutnikPretrazi.ValueMember = "IdPutnik";
            rezervacijaUC.CmbPutnikPretrazi.DisplayMember = "FullName";
            rezervacijaUC.CmbPutnikPretrazi.SelectedIndex = -1;
        }

        public void UcitajIzmeniPutnikCMB(List<Putnik> putnici)
        {
            if (putnici == null || putnici.Count == 0)
            {
                return;
            }

            rezervacijaUC.CmbPutnikIzmeni.DataSource = putnici;
            rezervacijaUC.CmbPutnikIzmeni.ValueMember = "IdPutnik";
            rezervacijaUC.CmbPutnikIzmeni.DisplayMember = "FullName";
            rezervacijaUC.CmbPutnikIzmeni.SelectedIndex = -1;
        }

        public List<Agent> VratiListuSviAgent()
        {
            List<Agent> agenti = Communication.Instance.VratiListuSviAgent();
            return agenti;
        }

        public void UcitajPretraziAgentCMB(List<Agent> agenti)
        {
            if (agenti == null || agenti.Count == 0)
            {
                MessageBox.Show("Nema registrovanih agenata.");
                return;
            }

            rezervacijaUC.CmbAgentPretrazi.DataSource = agenti;
            rezervacijaUC.CmbAgentPretrazi.ValueMember = "IdAgent";
            rezervacijaUC.CmbAgentPretrazi.DisplayMember = "FullName";
            rezervacijaUC.CmbAgentPretrazi.SelectedIndex = -1;
        }

        public void UcitajIzmeniAgentCMB(List<Agent> agenti)
        {
            if (agenti == null || agenti.Count == 0)
            {
                MessageBox.Show("Nema registrovanih agenata.");
                return;
            }

            rezervacijaUC.CmbAgentIzmeni.DataSource = agenti;
            rezervacijaUC.CmbAgentIzmeni.ValueMember = "IdAgent";
            rezervacijaUC.CmbAgentIzmeni.DisplayMember = "FullName";
            rezervacijaUC.CmbAgentIzmeni.SelectedIndex = -1;
        }

        public List<Smestaj> VratiListuSviSmestaj()
        {
            List<Smestaj> smestaji = Communication.Instance.VratiListuSviSmestaj();
            return smestaji;
        }

        private void UcitajCmbSmestaj()
        {
            try
            {
                List<Smestaj> smestaji = this.VratiListuSviSmestaj();

                rezervacijaUC.CmbSmestajPretrazi.DataSource = smestaji;
                rezervacijaUC.CmbSmestajPretrazi.ValueMember = "IdSmestaj";
                rezervacijaUC.CmbSmestajPretrazi.DisplayMember = "FullName";
                rezervacijaUC.CmbSmestajPretrazi.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita smestaje.");
            }
        }

        public void SearchRezervacija()
        {

            bool nemaKriterijuma =
               (rezervacijaUC.CmbAgentPretrazi.SelectedIndex == -1) &&
               (rezervacijaUC.CmbPutnikPretrazi.SelectedIndex == -1) &&
               (rezervacijaUC.CmbSmestajPretrazi.SelectedIndex == -1);

            if (nemaKriterijuma)
            {
                OsveziRezervacije();
                return;
            }
           

            KriterijumiRezervacija kriterijum = new KriterijumiRezervacija();

            if (rezervacijaUC.CmbPutnikPretrazi.SelectedIndex != -1)
            {
                kriterijum.Putnik = (Putnik)rezervacijaUC.CmbPutnikPretrazi.SelectedItem;
            }

            if (rezervacijaUC.CmbAgentPretrazi.SelectedIndex != -1)
            {
                kriterijum.Agent = (Agent)rezervacijaUC.CmbAgentPretrazi.SelectedItem;
            }

            if (rezervacijaUC.CmbSmestajPretrazi.SelectedIndex != -1)
            {
                kriterijum.Smestaj = (Smestaj)rezervacijaUC.CmbSmestajPretrazi.SelectedItem;
            }

            Response response = Communication.Instance.SearchRezervacija(kriterijum);
            List<Rezervacija> rezultat = (List<Rezervacija>)response.Result;

            if (response.IsSuccess && rezultat.Count > 0)
            {
                MessageBox.Show("Sistem je nasao rezervacije po zadatim kriterijumima.");
                rezervacijaUC.DgvRezervacije.DataSource = null;
                this.DGV(rezultat);
            }
            else
            {
                rezervacijaUC.DgvRezervacije.DataSource = null;
                rezervacijaUC.DgvRezervacije.Rows.Clear();
                MessageBox.Show("Sistem ne moze da nadje rezervacije po zadatim kriterijumima.");
            }
        }

        internal void OsveziRezervacije()
        {
            rezervacijaUC.DgvRezervacije.DataSource = null;
            DGV(VratiListuSviRezervacija());
        }

        public void PromeniRezervacija()
        {
            if (!this.Validacija())
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
                return;
            }

            rezervacijaDTO.Putnik = (Putnik)rezervacijaUC.CmbPutnikIzmeni.SelectedItem;
            rezervacijaDTO.Agent = (Agent)rezervacijaUC.CmbAgentIzmeni.SelectedItem;
            rezervacijaDTO.UkupanIznos = IzracunajUkupanIznos(rezervacijaDTO.stavkaRezervacijeList);

            Response response = Communication.Instance.UpdateRezervacija(rezervacijaDTO);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je zapamtio rezervaciju.");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju.");
            }
        }

        public void OdabranaRezervacija()
        {
            try
            {
                if (rezervacijaUC.DgvRezervacije.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Prvo izaberite rezervaciju.");
                    return;
                }
                Rezervacija rezervacija = (Rezervacija)rezervacijaUC.DgvRezervacije.SelectedRows[0].DataBoundItem;

                rezervacijaUC.CmbAgentIzmeni.SelectedValue = rezervacija.Agent.IdAgent;
                rezervacijaUC.CmbPutnikIzmeni.SelectedValue = rezervacija.Putnik.IdPutnik;

                rezervacijaDTO = rezervacija;

                this.DGVStavka(rezervacija.stavkaRezervacijeList);
                OsveziUkupanIznos();

                MessageBox.Show("Sistem je nasao rezervaciju.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da nadje rezervaciju.");
            }
        }

        public void OdabranaRezervacija(Rezervacija rezervacija)
        {
            try
            {
                rezervacijaUC.CmbAgentIzmeni.SelectedValue = rezervacija.Agent.IdAgent;
                rezervacijaUC.CmbPutnikIzmeni.SelectedValue = rezervacija.Putnik.IdPutnik;

                rezervacijaDTO = rezervacija;
                this.DGVStavka(rezervacija.stavkaRezervacijeList);
                OsveziUkupanIznos();
                MessageBox.Show("Sistem je nasao rezervaciju.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da nadje rezervaciju.");
            }
        }
        private void OsveziUkupanIznos()
        {
            if (rezervacijaDTO == null || rezervacijaDTO.stavkaRezervacijeList == null)
            {
                rezervacijaUC.UkupanIznos = 0;
                return;
            }

            decimal ukupanIznos = rezervacijaDTO.stavkaRezervacijeList.Sum(s => s.UkupnaCena);
            rezervacijaDTO.UkupanIznos = ukupanIznos;
            rezervacijaUC.UkupanIznos = ukupanIznos;
        }

        public void DGVStavka(List<StavkaRezervacije> stavke)
        {
            List<Smestaj> smestaji = this.VratiListuSviSmestaj();

            if (smestaji == null || stavke == null)
            {
                return;
            }

            foreach (StavkaRezervacije s in stavke)
            {
                foreach (Smestaj sm in smestaji)
                {
                    if (s.IdSmestaj.IdSmestaj.Equals(sm.IdSmestaj))
                    {
                        s.IdSmestaj = sm;
                    }
                }
            }

            rezervacijaDTO.stavkaRezervacijeList = stavke;

            rezervacijaUC.DgvStavkeRezervacije.DataSource = null;
            rezervacijaUC.DgvStavkeRezervacije.DataSource = stavke;
            rezervacijaUC.DgvStavkeRezervacije.Columns["IdSmestaj"].HeaderText = "Smestaj";
            rezervacijaUC.DgvStavkeRezervacije.Columns["JedinicnaCena"].HeaderText = "Jedinicna cena";
            rezervacijaUC.DgvStavkeRezervacije.Columns["UkupnaCena"].HeaderText = "Ukupna cena";
            rezervacijaUC.DgvStavkeRezervacije.Columns["DatumPolaska"].HeaderText = "Datum polaska";
            rezervacijaUC.DgvStavkeRezervacije.Columns["DatumDolaska"].HeaderText = "Datum dolaska";
            rezervacijaUC.DgvStavkeRezervacije.Columns["OpisStavke"].HeaderText = "Opis stavke";

            SakrijKolonuStavke("Rb");
            SakrijKolonuStavke("IdRezervacija");
            SakrijKolonuStavke("TableName");
            SakrijKolonuStavke("Values");
            SakrijKolonuStavke("IdCondition");
            SakrijKolonuStavke("IdColumn");
            SakrijKolonuStavke("Update");
            SakrijKolonuStavke("FullName");

            // rezervacijaUC.UkupanIznos = IzracunajUkupanIznos(stavke); moze i ovako, bez osveziUkupanIznos()
            OsveziUkupanIznos();
        }

        public Rezervacija KreirajRezervacija()
        {
            Rezervacija rezervacija = new Rezervacija()
            {
                stavkaRezervacijeList = new List<StavkaRezervacije>()
            };

            MessageBox.Show("Sistem je kreirao rezervaciju");
            return rezervacija;
        }

        public void ObrisiStavku(StavkaRezervacije stavka)
        {
            if (rezervacijaDTO == null || rezervacijaDTO.stavkaRezervacijeList == null)
            {
                MessageBox.Show("Nije izabrana rezervacija.");
                return;
            }

            rezervacijaDTO.stavkaRezervacijeList.Remove(stavka);

            for (int i = 0; i < rezervacijaDTO.stavkaRezervacijeList.Count; i++)
            {
                rezervacijaDTO.stavkaRezervacijeList[i].Rb = i + 1;
            }

            rezervacijaDTO.UkupanIznos = IzracunajUkupanIznos(rezervacijaDTO.stavkaRezervacijeList);

            Response response = Communication.Instance.UpdateRezervacija(rezervacijaDTO);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je obrisao stavku rezervacije.");
                DGVStavka(rezervacijaDTO.stavkaRezervacijeList);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise stavku rezervacije.");
            }
        }

        private void DGV(List<Rezervacija> rezervacije)
        {
            if (rezervacije == null || rezervacije.Count == 0)
            {
                MessageBox.Show("Nema rezervacija za prikaz.");
                return;
            }

            rezervacijaUC.DgvRezervacije.DataSource = rezervacije;

            rezervacijaUC.DgvRezervacije.Columns["UkupanIznos"].HeaderText = "Ukupan iznos";


            if (rezervacije == null)
            {
                return;
            }

            SakrijKolonuRezervacije("IdRezervacija");
            SakrijKolonuRezervacije("sessionTime");
            SakrijKolonuRezervacije("TableName");
            SakrijKolonuRezervacije("Values");
            SakrijKolonuRezervacije("IdCondition");
            SakrijKolonuRezervacije("IdColumn");
            SakrijKolonuRezervacije("Update");
            SakrijKolonuRezervacije("FullName");
        }

        private decimal IzracunajUkupanIznos(List<StavkaRezervacije> stavke)
        {
            if (stavke == null)
            {
                return 0;
            }

            return stavke.Sum(s => s.UkupnaCena);
        }

        private bool Validacija()
        {
            if (rezervacijaUC.CmbAgentIzmeni.SelectedIndex == -1 ||
                rezervacijaUC.CmbPutnikIzmeni.SelectedIndex == -1 ||
                rezervacijaDTO == null ||
                rezervacijaDTO.IdRezervacija == 0)
            {
                MessageBox.Show("Molimo vas popunite sva polja!", "Greska");
                return false;
            }

            return true;
        }

        private List<Rezervacija> VratiListuSviRezervacija()
        {
            List<Rezervacija> rezervacije = Communication.Instance.VratiListuSviRezervacija();
            return rezervacije;
        }

        private void SakrijKolonuRezervacije(string nazivKolone)
        {
            if (rezervacijaUC.DgvRezervacije.Columns.Contains(nazivKolone))
            {
                rezervacijaUC.DgvRezervacije.Columns[nazivKolone].Visible = false;
            }
        }

        private void SakrijKolonuStavke(string nazivKolone)
        {
            if (rezervacijaUC.DgvStavkeRezervacije.Columns.Contains(nazivKolone))
            {
                rezervacijaUC.DgvStavkeRezervacije.Columns[nazivKolone].Visible = false;
            }
        }
    }
}
