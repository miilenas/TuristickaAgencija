using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.PutnikSO
{
    public class DeletePutnikSO : SystemOperationBase
    {
        private readonly Putnik putnik;

        public DeletePutnikSO(Putnik p)
        {
            this.putnik = p;
        }

        protected override void ExecuteOperation()
        {
            List<Rezervacija> rezervacijeList = broker.GetAll(new Rezervacija(), putnik.IdCondition).Cast<Rezervacija>().ToList();

            foreach (Rezervacija r in rezervacijeList)
            {
                List<StavkaRezervacije> stavkaRezervacije = broker.GetAll(new StavkaRezervacije(), r.IdCondition).
                    Cast<StavkaRezervacije>().ToList();
                foreach (StavkaRezervacije sr in stavkaRezervacije)
                {
                    broker.Delete(sr); //valjda sr a ne r
                }
                broker.Delete(r);
            }

            broker.Delete(putnik);
        }
    }
}
