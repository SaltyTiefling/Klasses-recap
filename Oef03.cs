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
    public partial class Oef03 : Form
    {
        Rapport rapport = new Rapport();
        public Oef03()
        {
            InitializeComponent();
        }
        private void Oef03_Load(object sender, EventArgs e)
        {
            foreach (var key in rapport.rapportList.Keys)
            {
                cbxVak.Items.Add(key);
            }
            cbxVak.SelectedIndex = 0;
        }

        private void cbxVak_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxPunten.DataSource = null;
            lbxPunten.DataSource = rapport.rapportList[cbxVak.Text];
            double avg = 0, sum = 0;
            
            for (int i = 0; i < lbxPunten.Items.Count; i++)
            {
                sum += Convert.ToDouble(lbxPunten.Items[i]);
            }
            avg = sum / lbxPunten.Items.Count;

            lblGemiddelde.Text = $"{Math.Round(avg,2)}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rapport.rapportList[cbxVak.Text].Add(decimal.ToInt32(numPunten.Value));
            cbxVak_SelectedIndexChanged(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                rapport.rapportList[cbxVak.Text].RemoveAt(lbxPunten.SelectedIndex);
            cbxVak_SelectedIndexChanged(sender, e);
        }
    }
}
