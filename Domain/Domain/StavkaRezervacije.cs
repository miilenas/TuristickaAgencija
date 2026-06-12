using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaRezervacije: IEntity
    {
        public int Rb { get; set; }
        public int IdRezervacija { get; set; }
        public decimal JedinicnaCena { get; set; }
        public decimal UkupnaCena { get; set; }
        public int Kolicina { get; set; }
        public string OpisStavke { get; set; }
        public DateOnly DatumPolaska { get; set; }
        public DateOnly DatumDolaska { get; set; }
        
        public Smestaj IdSmestaj { get; set; }

        public string TableName => $"StavkaRezervacije";

        public string Values =>
             $"{IdRezervacija}, {Rb}, " +
             $"{JedinicnaCena.ToString(CultureInfo.InvariantCulture)}, " +
             $"'{OpisStavke}', " +
             $"{Kolicina}, " +
             $"{UkupnaCena.ToString(CultureInfo.InvariantCulture)}, " +
             $"'{DatumDolaska:yyyy-MM-dd}', " +
             $"'{DatumPolaska:yyyy-MM-dd}', " +
             $"{IdSmestaj.IdSmestaj}";
        public string IdCondition => $"rb = {Rb} AND idRezervacija = {IdRezervacija}";

        public string Update =>
     $"jedinicnaCena = {JedinicnaCena.ToString(CultureInfo.InvariantCulture)}, " +
     $"opisStavke = '{OpisStavke}', " +
     $"kolicina = {Kolicina}, " +
     $"ukupnaCena = {UkupnaCena.ToString(CultureInfo.InvariantCulture)}, " +
     $"datumDolaska = '{DatumDolaska:yyyy-MM-dd}', " +
     $"datumPolaska = '{DatumPolaska:yyyy-MM-dd}', " +
     $"idSmestaj = {IdSmestaj.IdSmestaj}";
        public string FullName => $"";

        public string IdColumn => $"rb";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> stavkaRezervacijeList = new List<IEntity>();

            while (reader.Read())
            {
                StavkaRezervacije stavkaRezervacije = new StavkaRezervacije
                {

                    IdRezervacija = (int)reader["idRezervacija"],
                    Rb = (int)reader["rb"],
                    JedinicnaCena = (decimal)reader["jedinicnaCena"],
                    OpisStavke = (string)reader["opisStavke"],
                    Kolicina = (int)reader["kolicina"],
                    UkupnaCena = (decimal)reader["ukupnaCena"],
                    DatumDolaska = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("datumDolaska"))),
                    DatumPolaska = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("datumPolaska"))),
                    
                    IdSmestaj = new Smestaj
                    {
                        IdSmestaj = (int)reader["idSmestaj"]
                    }
                };
                stavkaRezervacijeList.Add(stavkaRezervacije);
            };

            return stavkaRezervacijeList;
        }

        public void SetId(int id)
        {
            Rb = id;
        }
    }

}
