using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.MestoSO
{
    public class CreateMestoSO : SystemOperationBase
    {
        private readonly Mesto mesto;

        public CreateMestoSO(Mesto mesto)
        {
            this.mesto = mesto;
        }

        protected override void ExecuteOperation()
        {
            broker.Add(mesto);
        }
    }
}
