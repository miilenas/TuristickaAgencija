using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.LicencaSO
{
    public class UbaciLicencaSO : SystemOperationBase
    {
            private readonly Licenca licenca;
            public Licenca Result { get; set; }

            public UbaciLicencaSO(Licenca licenca)
            {
                this.licenca = licenca;
            }

            protected override void ExecuteOperation()
            {
                Result = (Licenca)broker.Add(licenca);
                AgentLicenca il = licenca.AgentLicenca;
                il.Licenca = Result.IdLicenca;
                broker.Add(il);
            }
        }
    
}
