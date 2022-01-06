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
    public partial class Add_employee : Form
    {
        Controller controllerObj = new Controller();
        public Add_employee()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllDeps();
            cmbo_Dep.DataSource = dt;
            cmbo_Dep.DisplayMember = "DepName";

            dt = controllerObj.SelectAllEmpType();
            cmbo_empType.DataSource = dt;
            cmbo_empType.DisplayMember = "Tname";  
        }

        private void Add_Emp_Click(object sender, EventArgs e)
        {
            if (txtbox_Fname.Text == "")
            {
                MessageBox.Show("please enter the First Name");
                return;
            }
            if (txtbox_Lname.Text == "")
            {
                MessageBox.Show("please enter The Last Name");
                return;
            }
            if (txtbox_ID.Text == "")
            {
                MessageBox.Show("please enter a ID");
                return;
            }
            if (txtbox_salary.Text == "")
            {
                MessageBox.Show("please enter a Salary");
                return;
            }
            if (cmbo_Gender.Text == "")
            {
                MessageBox.Show("please choose a Gender");
                return;
            }
            int trial;

            bool res = Int32.TryParse(txtbox_ID.Text, out trial);
            if (!res)
            {
                MessageBox.Show("Incorrect Input, Enter a number in ID");
                return;
            }

            res = Int32.TryParse(txtbox_salary.Text, out trial);
            if (!res)
            {
                MessageBox.Show("Incorrect Input, Enter a number in Salary");
                return;
            }

            DataTable dt = controllerObj.IDExists(txtbox_ID.Text);
            // int usern = dt.Rows.Count;
            if (dt != null)
            {
                MessageBox.Show("ID already exists");
                return;
            }
            int result1 = controllerObj.InsertAperson(txtbox_Fname.Text, txtbox_Lname.Text, txtbox_ID.Text, dateTimePicker1.Text, cmbo_Gender.Text);
            if (result1 == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed");
            }
            string EmpType;
            if (cmbo_empType.Text == "technician")
            {
                EmpType = "1";
            }
            else if (cmbo_empType.Text == "Accountant")
            {
                EmpType = "2";
            }
            else if (cmbo_empType.Text == "Receptionist")
            {
                EmpType = "3";
            }
            else
            {
                EmpType = "4";
            }
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
            int result2 = controllerObj.InsertEmployee(txtbox_ID.Text, txtbox_ID.Text, EmpType, txtbox_salary.Text, DepartID);
            if (result2 == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed");
            }
            else
            {
                MessageBox.Show("The Employee is added Successfully");

            }
        }

        private void cmbo_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
