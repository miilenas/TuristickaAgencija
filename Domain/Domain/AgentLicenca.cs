using Common.Domain;
using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class AgentLicenca : IEntity
    {
        public Agent Agent { get; set; }
        public int Licenca { get; set; }
        public DateOnly DatumIzdavanja { get; set; }
        public DateOnly DatumIsteka { get; set; }

        public string TableName => $"AgL";

        public string Values => $"{Agent.IdAgent}, {Licenca}, '{DatumIzdavanja:yyyy-MM-dd}', '{DatumIsteka:yyyy-MM-dd}'";

        public string IdCondition => $"idAgent = {Agent.IdAgent} AND idLicenca = {Licenca}";

        public string Update => $"idAgent = {Agent.IdAgent}, idLicence = {Licenca}, " +
            $"datumIzdavanja = '{DatumIzdavanja:yyyy-MM-dd}', datumIsteka = '{DatumIsteka:yyyy-MM-dd}'";

        public string FullName => "";

        public string IdColumn => "";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> agentLicencaList = new List<IEntity>();
            while (reader.Read())
            {
                AgentLicenca il = new AgentLicenca();
                il.Agent = new Agent()
                {
                    IdAgent = (int)reader["idAgent"]
                };
                il.Licenca = (int)reader["idLicence"];
                il.DatumIzdavanja = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("datumIzdavanja")));
                il.DatumIsteka = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("datumIsteka")));
                agentLicencaList.Add(il);
            }
            return agentLicencaList;
        }

        public void SetId(int id)
        {
        }
    }
}
