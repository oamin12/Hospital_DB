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



            DataTable Loc = controllerObj.SelectOpRoom();
            locationCombo.DataSource = Loc;
            locationCombo.DisplayMember = "RoomNumber";
            locationCombo.ValueMember = "ID";


        }

        private void ReserveSuregeryButton_Click(object sender, EventArgs e)
        {
            string StartDate = StartTimePicker.Value.ToString("yyyyMMdd");
            string endDate = EndTimePicker.Value.ToString("yyyyMMdd");

            int r = controllerObj.RequestSuregry(Convert.ToInt32(locationCombo.SelectedValue), StartDate, endDate, Convert.ToInt32(PatientPick_combo.SelectedValue), Convert.ToInt32(DoctroPick_combo.SelectedValue));
            if(r == 0)
            {
                MessageBox.Show("Reservation not updated");
            }
            else
            {
                MessageBox.Show("Reservation updated successfully");
            }

        }
    }
}
