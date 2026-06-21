using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Rezervacija :IEntity
    {
        public int IdRezervacija { get; set; }
        public decimal UkupanIznos { get; set; }
        public Agent? Agent { get; set; }
        public Putnik? Putnik { get; set; }
        public List<StavkaRezervacije> stavkaRezervacijeList { get; set; }
        public string TableName => "Rezervacija";
        public string Values =>
        $"{UkupanIznos.ToString(CultureInfo.InvariantCulture)}, " +
        $"{(Agent != null ? Agent.IdAgent.ToString() : "NULL")}, " +
        $"{(Putnik != null ? Putnik.IdPutnik.ToString() : "NULL")}";

        public string IdCondition => $"idRezervacija= {IdRezervacija}";

        public string Update =>
            $"ukupanIznos={UkupanIznos}," +
            $"idAgent = {(Agent != null ? Agent.IdAgent.ToString() : "NULL")}, " +
            $"idPutnik = {(Putnik != null ? Putnik.IdPutnik.ToString() : "NULL")} ";
        public string FullName => "";

        public string IdColumn => $"idRezervacija";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> rezervacijaList = new List<IEntity>();

            while (reader.Read())
            {
                Rezervacija rezervacija = new Rezervacija();
                rezervacija.IdRezervacija = (int)reader["idRezervacija"];
                rezervacija.UkupanIznos = (decimal)reader["ukupanIznos"];
                rezervacija.Agent = new Agent();
                if (reader["idAgent"] != DBNull.Value)
                {
                    rezervacija.Agent.IdAgent = (int)reader["idAgent"];
                }
                rezervacija.Putnik = new Putnik();
                if (reader["idPutnik"] != DBNull.Value)
                {
                    rezervacija.Putnik.IdPutnik = (int)reader["idPutnik"];
                }
                rezervacijaList.Add(rezervacija);
            }
            return rezervacijaList;
        }

        public void SetId(int id)
        {
            IdRezervacija = id;
        }

    }
}
