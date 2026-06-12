using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Licenca : IEntity
    {
        public int IdLicenca { get; set; }
        public string TipLicence { get; set; }

        public AgentLicenca agentLicenca { get; set; }
        public string TableName => $"Licenca";

        public string Values => $"'{TipLicence}'";

        public string IdCondition => $"idLicenca = {IdLicenca}";

        public string Update => $"tipLicence = {TipLicence}";

        public string FullName => TipLicence;

        public string IdColumn => $"idLicenca";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> licenceList = new List<IEntity>();
            while (reader.Read())
            {
                Licenca licenca = new Licenca
                {
                    IdLicenca = (int)reader["idLicenca"],
                    TipLicence = (string)reader["tipLicence"]
                };
                licenceList.Add(licenca);
            }
            return licenceList;
        }

        public void SetId(int id)
        {
            IdLicenca = id;
        }
    }
}
