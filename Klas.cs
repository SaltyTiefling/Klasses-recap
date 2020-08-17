using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_recap
{
    class Klas
    {
        public string jaar { get; set; }
        public string richting { get; set; }
        public List<Persoon> leerlingen { get; set; } = new List<Persoon>();

        public Klas(string jaar, string richting)
        {
            this.jaar = jaar;
            this.richting = richting;
        }

        public override string ToString()
        {
            return $"{jaar}: {richting}";
        }
    }
}
