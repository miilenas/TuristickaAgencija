using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.PutnikSO
{
    public class VratiListuSviPutnikSO :SystemOperationBase
    {
        public List<Putnik> Result { get; set; } = new List<Putnik>();

        public VratiListuSviPutnikSO()
        {
        }

        protected override void ExecuteOperation()
        {
            Result = broker.GetAll(new Putnik()).Cast<Putnik>().ToList();
            List<Putnik> zaBrisanje = new List<Putnik>();

            foreach (Putnik p in Result)
            {
                if (string.IsNullOrWhiteSpace(p.Ime)
                    || string.IsNullOrWhiteSpace(p.Prezime)
                    || string.IsNullOrWhiteSpace(p.BrojTelefona)
                    || string.IsNullOrWhiteSpace(p.BrojPasosa)
                    || p.IdMesto.IdMesto == 0)
                {
                    zaBrisanje.Add(p);
                        broker.Delete(p);
                    
                    continue;
                }
            }

            foreach (Putnik p in zaBrisanje)
            {
                Result.Remove(p);
            }
        }
    }
}
