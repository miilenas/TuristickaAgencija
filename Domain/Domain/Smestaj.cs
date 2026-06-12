using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Smestaj :IEntity
    {
        public int IdSmestaj { get; set; }

        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public string TableName => "Smestaj";

        public string Values => $"'{Naziv}', '{Cena}', '{Grad}', '{Drzava}'";

        public string IdCondition => $"idSmestaj = {IdSmestaj}";

        public string Update => $"naziv = '{Naziv}', cena = '{Cena}', 'grad={Grad}', 'drzava={Drzava}' ";

        public string FullName => Naziv;

        public string IdColumn => $"idSmestaj";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> smestajList = new List<IEntity>();
            while (reader.Read())
            {
                Smestaj smestaj = new Smestaj()
                {
                    IdSmestaj = (int)reader["idSmestaj"],
                    Naziv = (string)reader["naziv"],
                    Cena = (decimal)reader["cena"],
                    Grad = (string)reader["grad"],
                    Drzava = (string)reader["drzava"]
                };
                smestajList.Add(smestaj);
            }
            return smestajList;
        }

        public void SetId(int id)
        {
            IdSmestaj = id;
        }

        public override string ToString() => Naziv;
    }
}
