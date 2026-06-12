using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Putnik: IEntity
    {
        public int IdPutnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string BrojPasosa { get; set; }
        public Mesto IdMesto { get; set; }
    //    public DateTime sessionTime { get; set; } = DateTime.Now;

        public string TableName => "Putnik";

        public string Values => $"'{Ime}', '{Prezime}', '{BrojTelefona}', '{BrojPasosa}', {(IdMesto != null ? IdMesto.IdMesto : "null")} ";
           //+ $"'{sessionTime:yyyy-MM-ddTHH:mm:ss}'";

        public string IdCondition => $"idPutnik = {IdPutnik}";

        public string Update => $"ime = '{Ime}', prezime = '{Prezime}', brojTelefona = '{BrojTelefona}', brojPasosa='{BrojPasosa}'," +
            $" idMesto = {(IdMesto != null ? IdMesto.IdMesto : "null")} ";
           //+ $"sessionTime = '{sessionTime:yyyy-MM-dd HH:mm:ss}'";

        public string FullName => Ime + " " + Prezime;

        public string IdColumn => $"idPutnik";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> putnikList = new List<IEntity>();

            while (reader.Read())
            {
                Putnik putnik = new Putnik();
                putnik.IdPutnik = (int)reader["idPutnik"];
                putnik.Ime = (string)reader["ime"];
                putnik.Prezime = (string)reader["prezime"];
                putnik.BrojTelefona = (string)reader["brojTelefona"];
                putnik.BrojPasosa = (string)reader["brojPasosa"];
                putnik.IdMesto = new Mesto();
                if (reader["idMesto"] != DBNull.Value)
                {
                    putnik.IdMesto.IdMesto = (int)reader["idMesto"];
                }
               // putnik.sessionTime = reader.GetDateTime(reader.GetOrdinal("sessionTime"));
                putnikList.Add(putnik);
            }
            return putnikList;
        }

        public void SetId(int id)
        {
            IdPutnik = id;
        }

        public override string ToString() => Ime + " " + Prezime;
    }
}

