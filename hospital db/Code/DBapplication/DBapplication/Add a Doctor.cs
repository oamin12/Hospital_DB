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
    public partial class Add_a_Doctor : Form
    {
        Controller controllerObj = new Controller();
        public Add_a_Doctor()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllDeps();
            cmbo_Dep.DataSource = dt;
            cmbo_Dep.DisplayMember = "DepName";
            
            dt = controllerObj.SelectAllDrID();
            if (dt != null)
            {
                dt.Rows.Add("-1");
                cmbo_super.DataSource = dt;
                cmbo_super.DisplayMember = "ID";
            }
                // cmbo_super.Items.Add("none");
            //cmbo_super.Items.Add("none");
        }

        private void Add_a_Doctor_Load(object sender, EventArgs e)
        {

        }

        private void Add_doc_Click(object sender, EventArgs e)
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

            
            bool res = Int32.TryParse(txtbox_salary.Text, out trial);
            if (!res)
            {
                MessageBox.Show("Incorrect Input, Enter a number in Salary");
                return;
            }


            int result1 = controllerObj.InsertAperson(txtbox_Fname.Text, txtbox_Lname.Text, dateTimePicker1.Text, cmbo_Gender.Text);
            if (result1 == 0)
            {
                MessageBox.Show("The insertion of a new Dr failed");
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
            int perID = controllerObj.getLastAddedPerson();
            int result2= controllerObj.InsertaDr(txtbox_salary.Text, DepartID ,perID.ToString() ,cmbo_super.Text);
            if (result2 == 0)
            {
                MessageBox.Show("The insertion of a new Doctor failed");
            }
            else
            {
                MessageBox.Show("The Doctor is added Successfully");

            }
        }



        private void cmbo_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46) { e.Handled = true; }
        }

        private void txtbox_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (!char.IsLetter(cr) && cr != 8 && cr != 46) { e.Handled = true; }
        }

        private void txtbox_salary_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
