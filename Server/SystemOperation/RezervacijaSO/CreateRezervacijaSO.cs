using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.Rezervacije
{
    public class CreateRezervacijaSO :SystemOperationBase
    {
        private readonly Rezervacija rezervacija;
        public Rezervacija Result { get; set; }
        public CreateRezervacijaSO(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }
        protected override void ExecuteOperation()
        {
            if (rezervacija == null ||
                rezervacija.Agent == null ||
                rezervacija.Putnik == null ||
                rezervacija.stavkaRezervacijeList == null ||
                rezervacija.stavkaRezervacijeList.Count == 0)
            {
                throw new Exception("Rezervacija nema sve obavezne podatke.");
            }

            Result = (Rezervacija)broker.Add(rezervacija);

            for (int i = 0; i < rezervacija.stavkaRezervacijeList.Count; i++)
            {
                StavkaRezervacije stavka = rezervacija.stavkaRezervacijeList[i];
                stavka.IdRezervacija = Result.IdRezervacija;
                stavka.Rb = i + 1;
                broker.Add(stavka);
            }

            Result.stavkaRezervacijeList = rezervacija.stavkaRezervacijeList;
        }
    }
}
