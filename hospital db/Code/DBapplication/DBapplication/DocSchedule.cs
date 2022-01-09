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
            controllerobj = c;
            InitializeComponent();
        }

        private void DocSchedule_Load(object sender, EventArgs e)
        {

            // DataTable dt = controllerobj.SelectPatientsnames();
            //appointments_combo.DataSource = dt;
            //appointments_combo.DisplayMember = "FName";
            //appointments_combo.Text = "";
        }

        private void show_schedule_button_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerobj.getappointments(myID , strt_date.Value , final_date.Value);
            if (dt == null) { MessageBox.Show("No Appointments found");return; }
            dt.Columns[0].ColumnName = "DATE & TIME";
            dt.Columns[1].ColumnName = "Patient ID";
            dt.Columns[2].ColumnName = "First Name";
            dt.Columns[3].ColumnName = "Second Name";
            dt.Columns[4].ColumnName = "TYPE";
            schedulegrid.DataSource = dt;


        }
    }
}
