using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasses_recap
{
    class Televisie
    {
        int volume = 0;
        public List<string> kanalenLijst { get; set; } = new List<string>();
        public int kanaalnr { get; set; } = 0;

        public Televisie()
        {
            kanalenLijst.Add("BBC");
            kanalenLijst.Add("Cartoon Network");
            kanalenLijst.Add("Ketnet");
            kanalenLijst.Add("Een");
        }

       public void kanaalUp()
        {
            kanaalnr++;
            if (kanaalnr >= kanalenLijst.Count)
            {
                kanaalnr = 0;
            }
        }
        public void kanaalDown()
        {
            kanaalnr--;
            if (kanaalnr < 0)
            {
                kanaalnr = kanalenLijst.Count-1;
            }
        }
        public string GetKanaal()
        {
            return kanalenLijst[kanaalnr];
        }
        public void VolumeUp()
        {
            volume++;
            if (volume > 15)
            {
                volume = 0;
            }
        }
        public void VolumeDown()
        {
            volume--;
            if (volume < 0)
            {
                volume = 15;
            }
        }
        public override string ToString()
        {

            return $"Volume: {volume} Kanaal: {GetKanaal()}";
        }
    }
}
