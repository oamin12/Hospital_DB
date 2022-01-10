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

            if (PatientPick_combo.SelectedItem == null)
            {
                MessageBox.Show("please pick a patient");
            }
            else if (DoctroPick_combo.SelectedItem == null)
            {
                MessageBox.Show("please pick a doctor");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("please choose appointment type");
            }
            else
            {
                string AppointmentType = "";
                if (radioButton1.Checked)
                {
                    AppointmentType = radioButton1.Text;
                }
                if (radioButton2.Checked)
                {
                    AppointmentType = radioButton2.Text;
                }

                string Date = dateTimePicker1.Value.ToString("yyyyMMdd");

                int r = controllerObj.RequestAppointment(Convert.ToInt32(PatientPick_combo.SelectedValue), Convert.ToInt32(((DataRowView)DoctroPick_combo.SelectedValue)["ID"]), Date, AppointmentType);
                if (r == 0)
                {
                    MessageBox.Show("Request not proccessed");
                }
                else
                {
                    MessageBox.Show("Appointment requested successfully");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((DataRowView)DoctroPick_combo.SelectedValue)["ID"]);
            DataTable db = controllerObj.docSchedule(id);
            dataGridView1.DataSource = db;
            dataGridView1.Refresh();
        }
    }
}
