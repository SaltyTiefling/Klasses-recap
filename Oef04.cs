using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasses_recap
{
    public partial class Oef04 : Form
    {
        Zwembad Zwembad = new Zwembad();
        public Oef04()
        {
            InitializeComponent();
        }

        private void Oef04_Load(object sender, EventArgs e)
        {
            numDepth.Maximum = numLength.Maximum = numWidth.Maximum = decimal.MaxValue;
        }

        private void UpdateVolume(object sender, EventArgs e)
        {
            Zwembad.length = decimal.ToInt32(numLength.Value);
            Zwembad.depth = decimal.ToInt32(numDepth.Value);
            Zwembad.width = decimal.ToInt32(numWidth.Value);

            Zwembad.CalculateVolume();

            lblVolume.Text = Zwembad.volume.ToString();
        }
    }
}
