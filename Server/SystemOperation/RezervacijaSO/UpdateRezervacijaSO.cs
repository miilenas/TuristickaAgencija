using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Rezervacije
{
    public class UpdateRezervacijaSO :SystemOperationBase
    {
        public Rezervacija Result { get; set; }

        private readonly Rezervacija rezervacija;

        public UpdateRezervacijaSO(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        protected override void ExecuteOperation()
        {
            List<StavkaRezervacije> stareStavke = broker.GetAll(
                    new StavkaRezervacije(),
                    rezervacija.IdCondition
                )
                .Cast<StavkaRezervacije>()
                .ToList();

            List<StavkaRezervacije> zaBrisanje = new List<StavkaRezervacije>();

            if (rezervacija.stavkaRezervacijeList == null)
            {
                rezervacija.stavkaRezervacijeList = new List<StavkaRezervacije>();
            }

            foreach (StavkaRezervacije stara in stareStavke)
            {
                bool postojiUNovimStavkama = rezervacija.stavkaRezervacijeList
                    .Any(novaStavka => novaStavka.Rb == stara.Rb);

                if (!postojiUNovimStavkama)
                {
                    zaBrisanje.Add(stara);
                }
            }

            foreach (StavkaRezervacije novaStavka in rezervacija.stavkaRezervacijeList)
            {
                StavkaRezervacije? postojecaStavka = stareStavke
                    .FirstOrDefault(staraStavka => staraStavka.Rb == novaStavka.Rb);

                if (postojecaStavka == null)
                {
                    broker.Add(novaStavka);
                }
                else
                {
                    broker.Update(novaStavka);
                }
            }

            foreach (StavkaRezervacije stavkaZaBrisanje in zaBrisanje)
            {
                broker.Delete(stavkaZaBrisanje);
            }

            Result = (Rezervacija)broker.Update(rezervacija);
        }

    }
}
