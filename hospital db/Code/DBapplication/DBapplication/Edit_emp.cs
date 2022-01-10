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
    public partial class Edit_emp : Form
    {
        Controller controllerObj = new Controller();

        public Edit_emp()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllDeps();
            cmbo_Dep.DataSource = dt;
            cmbo_Dep.DisplayMember = "DepName";
            dt = controllerObj.SelectAllEmpID();
            if (dt != null)
            {
                cmbo_EmpID.DataSource = dt;
                cmbo_EmpID.DisplayMember = "ID";
            }
        }

        private void btn_chngNurse_Click(object sender, EventArgs e)
        {
            if (txtbox_Fname.Text == "" && txtbox_Lname.Text == "" && cmbo_Dep.Text == "")
            {
                MessageBox.Show("please Select a parameter to change");
                return;
            }
            int result1;
            int result2;
            int pID = controllerObj.getEmpPID(cmbo_EmpID.Text);
            string DepartID;

            if (cmbo_Dep.Text == "orthopaedics")
            {
                DepartID = "1";
            }
            else if (cmbo_Dep.Text == "neurology")
            {
                DepartID = "2";
            }
            else if (cmbo_Dep.Text == "cardiology")
            {
                DepartID = "3";
            }
            else if (cmbo_Dep.Text == "Ophthalmology")
            {
                DepartID = "4";
            }
            else
            {
                DepartID = "5";
            }

            result1 = controllerObj.UpdateDr(pID.ToString(), txtbox_Fname.Text, txtbox_Lname.Text);
           result2 = controllerObj.UpdateEMpDEp(cmbo_EmpID.Text, DepartID.ToString());
                if (result1 == 0 || result2 == 0)
                {
                    MessageBox.Show("Couldn't update Employee");
                }
                else
                {
                    MessageBox.Show("Employee updated successfully");

                }

            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllEmps();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
