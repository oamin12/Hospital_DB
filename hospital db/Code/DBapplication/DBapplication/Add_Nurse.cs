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
    public partial class Add_Nurse : Form
    {
        Controller controllerObj = new Controller();
        public Add_Nurse()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllNurseID();
            dt.Rows.Add("-1");
            cmbo_super.DataSource = dt;
            cmbo_super.DisplayMember = "ID";
            
        }

        private void btn_add_nurse_Click(object sender, EventArgs e)
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
                MessageBox.Show("The insertion of a new Nurse failed");
            }

            int result2 = controllerObj.InsertaNurse(txtbox_ID.Text, txtbox_salary.Text, txtbox_ID.Text, cmbo_super.Text);
            if (result2 == 0)
            {
                MessageBox.Show("The insertion of a new Nurse failed");
            }
            else
            {
                MessageBox.Show("The Nurse is added Successfully");

            }

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
    }
}
