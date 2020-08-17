using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_recap
{
    class Persoon
    {
        public string naam { get; set; }
        public DateTime geboorteDatum { get; set; }
        public string Geslacht { get; set; }

        public Persoon(string naam, DateTime geboorteDatum, string geslacht)
        {
            this.naam = naam;
            this.geboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
