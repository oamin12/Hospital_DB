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
    public partial class Surgery_Res : UserControl
    {
        Controller controllerObj;
        public Surgery_Res()
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

            DataTable Otype = controllerObj.SelectOperationType_ID();
            OperationTypePick_combo.DataSource = Otype;
            OperationTypePick_combo.DisplayMember = "Oname";
            OperationTypePick_combo.ValueMember = "ID";

        }

        private void ReserveSuregeryButton_Click(object sender, EventArgs e)
        {
            string StartDate = StartTimePicker.Value.ToString("dd-MM-yyyy hh':'ss tt");
            string endDate = EndTimePicker.Value.ToString("yyyy-MM-dd hh':'ss tt");
        }
    }
}
