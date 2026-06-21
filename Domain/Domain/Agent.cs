using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Agent : IEntity
    {
        public int IdAgent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateOnly DatumZaposlenja { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string TableName => "Agent";

        public string Values => $"'{Ime}', '{Prezime}', '{DatumZaposlenja:yyyy - MM - dd}', '{Email}' , '{Password}'";

        public string IdCondition => $"idAgent={IdAgent}";

        public string Update => $"ime='{Ime}', prezime='{Prezime}' , datumZaposlenja='{DatumZaposlenja}' , email='{Email}' , 'password={Password}' ";

        public string FullName => Ime+" "+Prezime;

        public string IdColumn => $"idAgent";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> agentList = new List<IEntity>();
            while (reader.Read())
            {
                Agent agent = new Agent
                {
                    IdAgent = (int)reader["idAgent"],
                    Ime = (string)reader["ime"].ToString().Trim(),
                    Prezime = (string)reader["prezime"].ToString().Trim(),
                    DatumZaposlenja = DateOnly.FromDateTime((DateTime)reader["datumZaposlenja"]),
                    Email = (string)reader["email"].ToString().Trim(),
                    Password= (string)reader["password"].ToString().Trim()
                };
                agentList.Add(agent);
            }
            return agentList;
        }

        public void SetId(int id)
        {
            IdAgent = id;
        }

        public override string ToString() => Ime + " " + Prezime;
    }
}
