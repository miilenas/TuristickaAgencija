using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SmestajSO
{
    public class VratiListuSviSmestajSO :SystemOperationBase
    {
        public List<Smestaj> Result { get; set; } = new List<Smestaj>();

        protected override void ExecuteOperation()
        {
            Result = broker.GetAll(new Smestaj())
                .Cast<Smestaj>()
                .ToList();

            //nemoj da baca exception ako nema, samo ce prikazati praznu listu
            //if (Result == null || Result.Count == 0)
            //{
            //    throw new Exception("Nema sacuvanog smestaja u bazi!");
            //}
        }
    }
}
