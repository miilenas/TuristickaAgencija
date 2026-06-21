using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Mesto :IEntity
    {
        public int IdMesto { get; set; }

        public string Grad { get; set; }
        public string Drzava { get; set; }


        public string TableName => "Mesto";

        public string Values => $"'{Grad}', '{Drzava}'";

        public string IdCondition => $"idMesto = {IdMesto}";

        public string Update => $"grad = '{Grad}', drzava = '{Drzava}' ";

        public string FullName => Grad + ", " + Drzava;

        public string IdColumn => $"idMesto";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> mestoList = new List<IEntity>();
            while (reader.Read())
            {
                Mesto mesto = new Mesto
                {
                    IdMesto = (int)reader["idMesto"],
                    Grad = (string)reader["grad"].ToString().Trim(),
                    Drzava = (string)reader["drzava"].ToString().Trim()
                };
                mestoList.Add(mesto);
            }
            return mestoList;
        }

        public void SetId(int id)
        {
            IdMesto = id;
        }
   public override string ToString() => $"{Grad},{Drzava}";

    }
}
