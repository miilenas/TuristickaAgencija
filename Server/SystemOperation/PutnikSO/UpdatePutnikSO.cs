using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.PutnikSO
{
    public class UpdatePutnikSO :SystemOperationBase
    {
        private readonly Putnik putnik;

        public Putnik Result { get; set; }

        public UpdatePutnikSO(Putnik putnik)
        {
            this.putnik = putnik;
        }

        private void ValidatePutnik()
        {
            if (putnik == null)
                throw new Exception("Putnik ne sme biti null.");

            if (putnik.IdPutnik == 0)
                throw new Exception("Putnik za izmenu mora imati validan ID.");

            if (string.IsNullOrWhiteSpace(putnik.Ime))
                throw new Exception("Ime putnika je obavezno.");

            if (string.IsNullOrWhiteSpace(putnik.Prezime))
                throw new Exception("Prezime putnika je obavezno.");

            if (string.IsNullOrWhiteSpace(putnik.BrojTelefona))
                throw new Exception("Broj telefona putnika je obavezan.");

            if (string.IsNullOrWhiteSpace(putnik.BrojPasosa))
                throw new Exception("Broj pasosa putnika je obavezan.");

            if (putnik.IdMesto == null || putnik.IdMesto.IdMesto == 0)
                throw new Exception("Mesto putnika je obavezno.");

            bool postojiPutnikSaIstimPasosem = broker.GetAll(new Putnik())
                .Cast<Putnik>()
                .Any(p => p.IdPutnik != putnik.IdPutnik &&
                          p.BrojPasosa.Equals(putnik.BrojPasosa, StringComparison.OrdinalIgnoreCase));

            if (postojiPutnikSaIstimPasosem)
                throw new Exception("Broj pasosa mora biti jedinstven.");
        }

        protected override void ExecuteOperation()
        {
            ValidatePutnik();
            Result = (Putnik)broker.Update(putnik);
        }

    }
}
