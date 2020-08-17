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
    public partial class Oef01 : Form
    {
        int teller = 0;
        public Oef01()
        {
            InitializeComponent();
        }

        private void btnLeesTeller_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{teller}");
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            teller++;
        }

        private void btnVerminder_Click(object sender, EventArgs e)
        {
            teller--;
        }

        private void btnResetten_Click(object sender, EventArgs e)
        {
            teller = 0;
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
