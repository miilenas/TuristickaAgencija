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
            if (rezervacija == null)
            {
                throw new Exception("Rezervacija ne sme biti null.");
            }

            if (rezervacija.Agent == null || rezervacija.Putnik == null)
            {
                throw new Exception("Rezervacija mora imati agenta i putnika.");
            }

            if (rezervacija.stavkaRezervacijeList == null || rezervacija.stavkaRezervacijeList.Count == 0)
            {
                throw new Exception("Rezervacija mora imati bar jednu stavku.");
            }

            Result = (Rezervacija)broker.Add(rezervacija);

            foreach (StavkaRezervacije stavka in rezervacija.stavkaRezervacijeList)
            {
                stavka.IdRezervacija = Result.IdRezervacija;
                broker.Add(stavka);
            }

            Result.stavkaRezervacijeList = rezervacija.stavkaRezervacijeList;
        }
    }
}
