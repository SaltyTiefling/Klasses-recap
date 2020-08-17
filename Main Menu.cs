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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOef01_Click(object sender, EventArgs e)
        {
            Oef01 oef = new Oef01();
            oef.Show();
        }

        private void btnOef02_Click(object sender, EventArgs e)
        {
            Oef02 oef = new Oef02();
            oef.Show();
        }

        private void btnOef03_Click(object sender, EventArgs e)
        {
            Oef03 oef = new Oef03();
            oef.Show();
        }

        private void btnOef04_Click(object sender, EventArgs e)
        {
            Oef04 oef = new Oef04();
            oef.Show();
        }

        private void btnOef05_Click(object sender, EventArgs e)
        {
            Oef05 oef = new Oef05();
            oef.Show();
        }
    }
}
