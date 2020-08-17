using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_recap
{
    class Rapport
    {
        List<int> punten = new List<int>(); 
        public Dictionary<string, List<int>> rapportList { get; set; } = new Dictionary<string, List<int>>();

        public Rapport()
        {
            rapportList.Add("Wiskunde",new List<int>());
            rapportList.Add("Informatica", new List<int>());
            rapportList.Add("Nederlands", new List<int>());
            rapportList.Add("Economie", new List<int>());
        }
    }
}
