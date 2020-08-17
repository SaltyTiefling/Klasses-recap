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
    public partial class Oef05 : Form
    {
        School school = new School();

        public Oef05()
        {
            InitializeComponent();
        }

        private void Oef05_Load(object sender, EventArgs e)
        {
            Klas klas = new Klas("5e middelbaar", "Informatica");
            school.klassenlijst.Add(klas);
            klas = new Klas("6e middelbaar", "Boekhouden");
            school.klassenlijst.Add(klas);

            cbxKlassen.DataSource = school.klassenlijst;
            cbxKlassen.SelectedIndex = 0;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string geslacht = gbGeslacht.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault().Text;
            if (geslacht.Equals(rbAndere.Text))
            {
                geslacht = tbxAnderGeslacht.Text;
            }
            Persoon leerling = new Persoon(txtNaam.Text,dtGeboortedatum.Value,geslacht);
            school.klassenlijst[cbxKlassen.SelectedIndex].leerlingen.Add(leerling);
            cbxKlassen_SelectedIndexChanged(sender, e);
        }

        private void cbxKlassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxStudents.DataSource = null;
            lbxStudents.DataSource = school.klassenlijst[cbxKlassen.SelectedIndex].leerlingen;
        }
    }
}
