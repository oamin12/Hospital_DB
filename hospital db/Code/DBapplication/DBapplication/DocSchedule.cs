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
    public partial class DocSchedule : Form
    {
        int myID;
        Controller controllerobj;

      

        public DocSchedule(int ID, Controller c)
        {
          

            myID = ID;
            controllerobj = new Controller();
            InitializeComponent();
        }
        private void refreshcombobox()
        {
            DataTable dt = controllerobj.selectappointments(myID);
            appointments_combo.DataSource = dt;
            appointments_combo.DisplayMember = "Date_time";
            appointments_combo.Text = "";

        }
        private void DocSchedule_Load(object sender, EventArgs e)
        {
            strt_date.Text = null;
            final_date.Text = null;
            DataTable dt = controllerobj.selectappointments(myID);
            appointments_combo.DataSource = dt;
            appointments_combo.DisplayMember = "Date_time";
            appointments_combo.Text = "";
        }

        private void show_schedule_button_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(strt_date.Text)) { strt_date.Text = "1999-05-06"; }
            if (string.IsNullOrEmpty(final_date.Text)) { final_date.Text = "2999-05-06"; }
            DataTable dt = controllerobj.getappointments(myID , strt_date.Value , final_date.Value);
            if (dt == null) { MessageBox.Show("No Appointments found");return; }
            dt.Columns[0].ColumnName = "DATE & TIME";
            dt.Columns[1].ColumnName = "Patient ID";
            dt.Columns[2].ColumnName = "First Name";
            dt.Columns[3].ColumnName = "Second Name";
            dt.Columns[4].ColumnName = "TYPE";
            schedulegrid.DataSource = dt;
            strt_date.Text = null;
            final_date.Text = null;


        }

        private void postpone_button_Click(object sender, EventArgs e)
        {
            DateTime appointtime;
            if (string.IsNullOrEmpty(appointments_combo.Text)) { MessageBox.Show("no appointment selected");return; }
            if (string.IsNullOrEmpty(newdate.Text)) { MessageBox.Show("no date selected"); return; }
            DateTime.TryParse(appointments_combo.Text, out appointtime);
            DataTable dt = controllerobj.checkappointmentandDr(myID, newdate.Text);
            if (dt != null) { MessageBox.Show("this time is not vacant in your schedule");return; }
            int result = controllerobj.updateappoint(myID , appointtime , newdate.Value);
            if (result != 0) { MessageBox.Show("appointment changed successfully!"); refreshcombobox(); return; }
            else { MessageBox.Show("appointment didn't change!"); refreshcombobox(); return; }
           






        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DateTime appointtime;
            if (string.IsNullOrEmpty(appointments_combo.Text)) { MessageBox.Show("no appointment selected"); return; }
            DateTime.TryParse(appointments_combo.Text, out appointtime);
            int result = controllerobj.cancelappointment(myID, appointtime);
            if (result != 0) { MessageBox.Show("appointment cancelled successfully!"); refreshcombobox(); return; }
            else { MessageBox.Show("appointment didn't cancel!"); refreshcombobox(); return; }

        }
    }
}
