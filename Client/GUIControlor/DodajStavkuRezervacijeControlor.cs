using Client.UserControl;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControlor
{
    public class DodajStavkuRezervacijeControlor
    {
        private readonly DodajStavkuRezervacijeUC uc;

        public Rezervacija Rezervacija { get; }

        public DodajStavkuRezervacijeControlor(DodajStavkuRezervacijeUC uc, Rezervacija rezervacija)
        {
            this.uc = uc;
            this.Rezervacija = rezervacija;

            if (Rezervacija.stavkaRezervacijeList == null)
            {
                Rezervacija.stavkaRezervacijeList = new List<StavkaRezervacije>();
            }

            UcitajSmestaje();
        }

        private void UcitajSmestaje()
        {
            List<Smestaj> smestaji = Communication.Instance.VratiListuSviSmestaj();

            uc.CmbSmestaj.DataSource = smestaji;
            uc.CmbSmestaj.ValueMember = "IdSmestaj";
            uc.CmbSmestaj.DisplayMember = "FullName";
            uc.CmbSmestaj.SelectedIndex = -1;
        }

        public void IzracunajCenu()
        {
            if (uc.CmbSmestaj.SelectedIndex == -1)
            {
                uc.JedinicnaCena = 0;
                uc.UkupnaCena = 0;
                return;
            }

            Smestaj smestaj = (Smestaj)uc.CmbSmestaj.SelectedItem;

            uc.JedinicnaCena = smestaj.Cena;
            uc.UkupnaCena = smestaj.Cena * uc.Kolicina;
        }

        public void DodajStavku()
        {
            if (uc.CmbSmestaj.SelectedIndex == -1 ||
                uc.DatumPolaska.Value >= uc.DatumDolaska.Value||
               string.IsNullOrEmpty(uc.OpisStavke))
            {
                MessageBox.Show("Sistem ne moze da sacuva stavku rezervacije.");
                return;
            }

            DateTime datumOd = uc.DatumPolaska.Value.Date;
            DateTime datumDo = uc.DatumDolaska.Value.Date;

            int brojNocenja = (datumDo - datumOd).Days;

            if (brojNocenja <= 0)
                throw new Exception("Datum dolaska mora biti posle datuma polaska.");

            if (brojNocenja != uc.Kolicina)
                throw new Exception("Kolicina mora odgovarati broju nocenja.");

            Smestaj smestaj = (Smestaj)uc.CmbSmestaj.SelectedItem;

            StavkaRezervacije stavka = new StavkaRezervacije
            {
                IdRezervacija = Rezervacija.IdRezervacija,
                Rb = Rezervacija.stavkaRezervacijeList.Count + 1,
                IdSmestaj = smestaj,
                JedinicnaCena = smestaj.Cena,
                Kolicina = uc.Kolicina,
                UkupnaCena = smestaj.Cena * uc.Kolicina,
                OpisStavke = uc.OpisStavke,
                DatumPolaska = DateOnly.FromDateTime(uc.DatumPolaska.Value),
                DatumDolaska = DateOnly.FromDateTime(uc.DatumDolaska.Value)
            };

            Rezervacija.stavkaRezervacijeList.Add(stavka);
            Rezervacija.UkupanIznos = Rezervacija.stavkaRezervacijeList.Sum(s => s.UkupnaCena);

            try
            {
                //update jer dodajes stavku na vec postojecu rezervaciju
                Response response = Communication.Instance.UpdateRezervacija(Rezervacija);

                if (response.IsSuccess)
                {
                    //MessageBox.Show("Sistem je dodao stavku rezervacije.");

                    FrmMain main = (FrmMain)uc.FindForm();
                    main.ChangePanel(new RezervacijaUC(Rezervacija));
                }
                else
                {
                    Rezervacija.stavkaRezervacijeList.Remove(stavka);
                    MessageBox.Show("Sistem ne moze da doda stavku rezervacije.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
            
           
        }
    }
}
