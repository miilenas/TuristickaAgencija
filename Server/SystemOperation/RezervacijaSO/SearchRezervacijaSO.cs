using Common.Domain;
using Common.Model;
using DBBroker;
using System.Collections.Generic;
using System.Linq;

namespace Server.SystemOperation.Rezervacije
{
    public class SearchRezervacijaSO : SystemOperationBase
    {
        private readonly KriterijumiRezervacija criteria;

        public List<Rezervacija> Result { get; set; } = new List<Rezervacija>();

        public SearchRezervacijaSO(KriterijumiRezervacija criteria)
        {
            this.criteria = criteria;
        }

        protected override void ExecuteOperation()
        {
            List<string> conditions = new List<string>();
            string join = "";

            if (criteria != null)
            {
                if (criteria.Agent != null)
                {
                    conditions.Add($"Rezervacija.idAgent = {criteria.Agent.IdAgent}");
                }

                if (criteria.Putnik != null)
                {
                    conditions.Add($"Rezervacija.idPutnik = {criteria.Putnik.IdPutnik}");
                }

                if (criteria.Smestaj != null)
                {
                    join = "JOIN StavkaRezervacije ON Rezervacija.idRezervacija = StavkaRezervacije.idRezervacija";
                    conditions.Add($"StavkaRezervacije.idSmestaj = {criteria.Smestaj.IdSmestaj}");
                }
            }

            string queryCondition = conditions.Count > 0
                ? string.Join(" AND ", conditions)
                : "";

            Result = broker.GetAll(new Rezervacija(), queryCondition, join)
                           .Cast<Rezervacija>()
                           .GroupBy(r => r.IdRezervacija)
                           .Select(g => g.First())
                           .ToList();

            foreach (Rezervacija rezervacija in Result)
            {
                if (rezervacija.Putnik != null)
                {
                    rezervacija.Putnik = broker.GetAll(new Putnik(), rezervacija.Putnik.IdCondition)
                                               .Cast<Putnik>()
                                               .FirstOrDefault();
                }

                if (rezervacija.Agent != null)
                {
                    rezervacija.Agent = broker.GetAll(new Agent(), rezervacija.Agent.IdCondition)
                                              .Cast<Agent>()
                                              .FirstOrDefault();
                }

                rezervacija.stavkaRezervacijeList = broker.GetAll(
                                                        new StavkaRezervacije(),
                                                        rezervacija.IdCondition
                                                    )
                                                    .Cast<StavkaRezervacije>()
                                                    .ToList();
            }
        }
    }
}