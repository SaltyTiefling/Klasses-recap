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
    public partial class Oef02 : Form
    {
        Televisie TV = new Televisie();
        public Oef02()
        {
            InitializeComponent();
        }

        private void Oef02_Load(object sender, EventArgs e)
        {
            UpdateInfo();
            numKanaal.Maximum = TV.kanalenLijst.Count-1;
        }

        public void UpdateInfo()
        {
            lblInfo.Text = TV.ToString();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            TV.VolumeUp();
            UpdateInfo();
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            TV.VolumeDown();
            UpdateInfo();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            TV.kanaalUp();
            numKanaal.Value = TV.kanaalnr;
            UpdateInfo();
        }

        private void btnKanaalMinus_Click(object sender, EventArgs e)
        {
            TV.kanaalDown();
            numKanaal.Value = TV.kanaalnr;
            UpdateInfo();
        }

        private void numKanaal_ValueChanged(object sender, EventArgs e)
        {
            TV.kanaalnr = Decimal.ToInt32(numKanaal.Value);
            UpdateInfo();
        }
    }
}
