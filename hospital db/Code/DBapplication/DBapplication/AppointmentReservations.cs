using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AppointmentReservations : UserControl
    {
        Controller controllerObj;

        public AppointmentReservations()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable PN = controllerObj.SelectPatients();
            PatientPick_combo.DataSource = PN;
            PatientPick_combo.DisplayMember = "FName";
            PatientPick_combo.ValueMember = "ID";

            DataTable DS = controllerObj.SelectDoctors_Name_ID();
            DoctroPick_combo.DataSource = DS;
            DoctroPick_combo.DisplayMember = "FName";
            PatientPick_combo.ValueMember = "ID";


        }

        private void ReserveAppButton_Click(object sender, EventArgs e)
        {

        }

        private void DoctroPick_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
