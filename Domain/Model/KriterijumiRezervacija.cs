using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class KriterijumiRezervacija
    {
        public Agent Agent { get; set; }
        public Putnik Putnik { get; set; }
        public Smestaj Smestaj { get; set; }
    }
}
