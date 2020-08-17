using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_recap
{
    class Zwembad
    {
        public decimal length { get; set; } = 1;
        public decimal width { get; set; } = 1;
        public decimal depth { get; set; } = 1;
        public decimal volume { get; set; }

        public Zwembad()
        {
        }

        public void CalculateVolume()
        {
            volume = length * width * depth;
        }

    }
}
