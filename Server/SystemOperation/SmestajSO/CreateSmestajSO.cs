using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SmestajSO
{
    public class CreateSmestajSO :SystemOperationBase
    {
        private readonly Smestaj smestaj;

        public Smestaj Result { get; set; }

        public CreateSmestajSO(Smestaj smestaj)
        {
            this.smestaj = smestaj;
        }

        protected override void ExecuteOperation()
        {
            ValidateSmestaj();

            Result = (Smestaj)broker.Add(smestaj);
        }

        private void ValidateSmestaj()
        {
            if (smestaj == null)
                throw new Exception("Smestaj ne sme biti null.");

            if (string.IsNullOrWhiteSpace(smestaj.Naziv))
                throw new Exception("Naziv smestaja je obavezan.");

            if (smestaj.Cena <= 0)
                throw new Exception("Cena smestaja mora biti veca od 0.");

            if (string.IsNullOrWhiteSpace(smestaj.Grad))
                throw new Exception("Grad smestaja je obavezan.");

            if (string.IsNullOrWhiteSpace(smestaj.Drzava))
                throw new Exception("Drzava smestaja je obavezna.");
        }
    }
}
