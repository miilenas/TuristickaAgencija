using Common.Domain;
using Common.Model;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.PutnikSO
{
    public class SearchPutnikSO : SystemOperationBase
    {
        public List<Putnik> Result { get; set; } = new List<Putnik>();

        private readonly KriterijumPutnik criteria;

        public SearchPutnikSO(KriterijumPutnik criteria)
        {
            this.criteria = criteria;
        }

        protected override void ExecuteOperation()
        {
            List<string> conditions = new List<string>();

            if (!string.IsNullOrWhiteSpace(criteria.Ime))
                conditions.Add($"ime LIKE '%{criteria.Ime}%'");

            if (!string.IsNullOrWhiteSpace(criteria.Prezime))
                conditions.Add($"prezime LIKE '%{criteria.Prezime}%'");

            if (criteria.Mesto != null)
                conditions.Add($"idMesto = {criteria.Mesto.IdMesto}");

            if (!string.IsNullOrWhiteSpace(criteria.BrojPasosa))
                conditions.Add($"brojPasosa LIKE '%{criteria.BrojPasosa}%'");

            if (!string.IsNullOrWhiteSpace(criteria.BrojTelefona))
                conditions.Add($"brojTelefona LIKE '%{criteria.BrojTelefona}%'");

            string queryCondition = "";

            if (conditions.Count != 0)
            {
                queryCondition = string.Join(" AND ", conditions);
            }

            Result = broker.GetAll(new Putnik(), queryCondition)
                .Cast<Putnik>()
                .ToList();

            Debug.WriteLine(Result);
        }

    }

}
