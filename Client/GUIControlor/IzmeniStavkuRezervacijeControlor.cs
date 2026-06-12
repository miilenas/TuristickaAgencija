using Client.UserControl;
using Common.Communication;
using Common.Domain;

namespace Client.GUIControlor
{
    public class IzmeniStavkuRezervacijeControlor
    {
        private readonly IzmeniStavkuRezervacijeUC uc;
        private readonly StavkaRezervacije stavka;

        public Rezervacija Rezervacija { get; }

        public IzmeniStavkuRezervacijeControlor(
            IzmeniStavkuRezervacijeUC uc,
            Rezervacija rezervacija,
            StavkaRezervacije stavka)
        {
            this.uc = uc;
            this.Rezervacija = rezervacija;
            this.stavka = stavka;

            UcitajSmestaje();
            PopuniFormu();
        }

        private void UcitajSmestaje()
        {
            List<Smestaj> smestaji = Communication.Instance.VratiListuSviSmestaj();

            uc.CmbSmestaj.DataSource = smestaji;
            uc.CmbSmestaj.ValueMember = "IdSmestaj";
            uc.CmbSmestaj.DisplayMember = "FullName";
        }

        private void PopuniFormu()
        {
            uc.CmbSmestaj.SelectedValue = stavka.IdSmestaj.IdSmestaj;
            uc.Kolicina = stavka.Kolicina;
            uc.OpisStavke = stavka.OpisStavke;
            uc.DatumPolaska.Value = stavka.DatumPolaska.ToDateTime(TimeOnly.MinValue);
            uc.DatumDolaska.Value = stavka.DatumDolaska.ToDateTime(TimeOnly.MinValue);
            uc.JedinicnaCena = stavka.JedinicnaCena;
            uc.UkupnaCena = stavka.UkupnaCena;
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

        public void IzmeniStavku()
        {
            if (uc.CmbSmestaj.SelectedIndex == -1 ||
                uc.DatumPolaska.Value >= uc.DatumDolaska.Value)
            {
                MessageBox.Show("Sistem ne moze da izmeni stavku rezervacije.");
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

            stavka.IdSmestaj = smestaj;
            stavka.JedinicnaCena = smestaj.Cena;
            stavka.Kolicina = uc.Kolicina;
            stavka.UkupnaCena = smestaj.Cena * uc.Kolicina;
            stavka.OpisStavke = uc.OpisStavke;
            stavka.DatumPolaska = DateOnly.FromDateTime(uc.DatumPolaska.Value);
            stavka.DatumDolaska = DateOnly.FromDateTime(uc.DatumDolaska.Value);

            Rezervacija.UkupanIznos = Rezervacija.stavkaRezervacijeList.Sum(s => s.UkupnaCena);

            Response response = Communication.Instance.UpdateRezervacija(Rezervacija);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je izmenio stavku rezervacije.");

                FrmMain main = (FrmMain)uc.FindForm();
                main.ChangePanel(new RezervacijaUC(Rezervacija));
            }
            else
            {
                MessageBox.Show("Sistem ne moze da izmeni stavku rezervacije.");
            }
        }
    }
}
