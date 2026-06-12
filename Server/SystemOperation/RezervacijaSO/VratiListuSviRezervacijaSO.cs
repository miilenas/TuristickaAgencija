using Common.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Server.SystemOperation.Rezervacije
{
    internal class VratiListuSviRezervacijaSO : SystemOperationBase
    {
        public List<Rezervacija> Result { get; set; } = new List<Rezervacija>();

        public VratiListuSviRezervacijaSO()
        {
        }

        protected override void ExecuteOperation()
        {
            Result = broker.GetAll(new Rezervacija())
                           .Cast<Rezervacija>()
                           .ToList();

            List<Rezervacija> zaBrisanje = new List<Rezervacija>();

            foreach (Rezervacija rez in Result)
            {
                if (rez.Putnik == null || rez.Agent == null ||
                    rez.Putnik.IdPutnik == 0 || rez.Agent.IdAgent == 0)
                {
                    zaBrisanje.Add(rez);
                    continue;
                }

                Putnik? putnik = broker.GetAll(new Putnik(), rez.Putnik.IdCondition)
                                       .Cast<Putnik>()
                                       .FirstOrDefault();

                if (putnik == null)
                {
                    zaBrisanje.Add(rez);
                    continue;
                }

                rez.Putnik = putnik;

                Agent? agent = broker.GetAll(new Agent(), rez.Agent.IdCondition)
                                     .Cast<Agent>()
                                     .FirstOrDefault();

                if (agent == null)
                {
                    zaBrisanje.Add(rez);
                    continue;
                }

                rez.Agent = agent;

                rez.stavkaRezervacijeList = broker.GetAll(
                                                new StavkaRezervacije(),
                                                rez.IdCondition
                                            )
                                            .Cast<StavkaRezervacije>()
                                            .ToList();
            }

            foreach (Rezervacija rez in zaBrisanje)
            {
                Result.Remove(rez);
            }
        }
    }
}