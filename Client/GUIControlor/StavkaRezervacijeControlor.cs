using Client.UserControl;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControlor
{
    public class StavkaRezervacijeControlor
    {
        private List<StavkaRezervacije> stavkeRezervacije;
        private StavkaRezervacijeUC stavkeUC;

        internal Rezervacija rezervacija;

        public StavkaRezervacijeControlor(StavkaRezervacijeUC stavkeUC, Rezervacija rezervacija)
        {
            this.stavkeUC = stavkeUC;
            this.rezervacija = rezervacija;

            if (this.rezervacija.stavkaRezervacijeList == null)
            {
                this.rezervacija.stavkaRezervacijeList = new List<StavkaRezervacije>();
            }

            this.stavkeRezervacije = this.rezervacija.stavkaRezervacijeList;

            UcitajSmestaje();
            DGV(stavkeRezervacije);
        }

        internal void DodajStavkuRezervacije()
        {
            if (stavkeUC.CmbSmestaj.SelectedIndex == -1 ||
                stavkeUC.DatumPolaska.Value >= stavkeUC.DatumDolaska.Value)
            {
                MessageBox.Show("Sistem ne može da sačuva stavku rezervacije.");
                return;
            }

            Smestaj smestaj = (Smestaj)stavkeUC.CmbSmestaj.SelectedItem;

            StavkaRezervacije stavka = new StavkaRezervacije()
            {
                IdRezervacija = rezervacija.IdRezervacija,
                Rb = stavkeRezervacije.Count + 1,
                IdSmestaj = smestaj,
                JedinicnaCena = smestaj.Cena,
                Kolicina = stavkeUC.Kolicina,
                UkupnaCena = smestaj.Cena * stavkeUC.Kolicina,
                OpisStavke = stavkeUC.OpisStavke,
                DatumPolaska = DateOnly.FromDateTime(stavkeUC.DatumPolaska.Value),
                DatumDolaska = DateOnly.FromDateTime(stavkeUC.DatumDolaska.Value)
            };

            stavkeRezervacije.Add(stavka);
            OsveziUkupanIznos();
            DGV(stavkeRezervacije);
        }

        internal void ObrisiStavkuRezervacije()
        {
            StavkaRezervacije stavka = OdabranaStavkaRezervacije();

            if (stavka != null)
            {
                stavkeRezervacije.Remove(stavka);
                SrediRb();
                OsveziUkupanIznos();
                DGV(stavkeRezervacije);
            }
        }

        internal StavkaRezervacije OdabranaStavkaRezervacije()
        {
            if (stavkeUC.DgvStavkaRezervacije.SelectedRows.Count == 0)
            {
                return null;
            }

            StavkaRezervacije stavka =
                (StavkaRezervacije)stavkeUC.DgvStavkaRezervacije.SelectedRows[0].DataBoundItem;

            stavkeUC.CmbSmestaj.SelectedValue = stavka.IdSmestaj.IdSmestaj;
            stavkeUC.Kolicina = stavka.Kolicina;
            stavkeUC.OpisStavke = stavka.OpisStavke;
            stavkeUC.DatumPolaska.Value = stavka.DatumPolaska.ToDateTime(TimeOnly.MinValue);
            stavkeUC.DatumDolaska.Value = stavka.DatumDolaska.ToDateTime(TimeOnly.MinValue);

            return stavka;
        }

        private void UcitajSmestaje()
        {
            List<Smestaj> smestaji = Communication.Instance.VratiListuSviSmestaj();

            stavkeUC.CmbSmestaj.DataSource = smestaji;
            stavkeUC.CmbSmestaj.ValueMember = "IdSmestaj";
            stavkeUC.CmbSmestaj.DisplayMember = "FullName";
            stavkeUC.CmbSmestaj.SelectedIndex = -1;
        }

        private void DGV(List<StavkaRezervacije> stavke)
        {
            stavkeUC.DgvStavkaRezervacije.DataSource = null;
            stavkeUC.DgvStavkaRezervacije.DataSource = stavke;
            SakrijKolonu("IdRezervacija");
            SakrijKolonu("TableName");
            SakrijKolonu("Values");
            SakrijKolonu("IdCondition");
            SakrijKolonu("Update");
            SakrijKolonu("FullName");
        }
        private void SakrijKolonu(string nazivKolone)
        {
            if (stavkeUC.DgvStavkaRezervacije.Columns.Contains(nazivKolone))
            {
                stavkeUC.DgvStavkaRezervacije.Columns[nazivKolone].Visible = false;
            }
        }

        private void OsveziUkupanIznos()
        {
            rezervacija.UkupanIznos = stavkeRezervacije.Sum(s => s.UkupnaCena);
        }

        private void SrediRb()
        {
            for (int i = 0; i < stavkeRezervacije.Count; i++)
            {
                stavkeRezervacije[i].Rb = i + 1;
            }
        }
    }
}