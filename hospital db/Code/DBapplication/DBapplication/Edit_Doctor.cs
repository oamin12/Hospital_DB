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

    public partial class Edit_Doctor : Form
    {
        Controller controllerObj = new Controller();

        public Edit_Doctor()
        {
            InitializeComponent();

            DataTable dt = controllerObj.SelectAllDeps();
            cmbo_Dep.DataSource = dt;
            cmbo_Dep.DisplayMember = "DepName";

            dt = controllerObj.SelectAllDrID();
           DataTable dt2 = controllerObj.SelectAllDrID();
            if (dt != null)
            {
                dt.Rows.Add("-1");
                dt2.Rows.Add("-1");
                cmbo_super.DataSource = dt;
                cmbo_super.DisplayMember = "ID";
                cmbo_drID.DataSource = dt2;
                cmbo_drID.DisplayMember = "ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox_Fname.Text == "" && txtbox_Lname.Text == "" && cmbo_super.Text=="")
            {
                MessageBox.Show("please Select a parameter to change");
                return;
            }
            if (cmbo_drID.Text == cmbo_super.Text)
            {
                MessageBox.Show("SuperVisor Can't have the same ID");
                return;
            }
            int result1;
            int result2;
            int pID = controllerObj.getDrPID(cmbo_drID.Text);
            if (cmbo_super.Text == "-1")
            {
                result1 = controllerObj.UpdateDr(pID.ToString(), txtbox_Fname.Text, txtbox_Lname.Text);
                if (result1 == 0)
                {
                    MessageBox.Show("Couldn't update Doctor");
                }
                else
                {
                    MessageBox.Show("Doctor updated successfully");

                }
            }
            else
            {
                result1 = controllerObj.UpdateDr(pID.ToString(), txtbox_Fname.Text, txtbox_Lname.Text);
                result2 = controllerObj.UpdateDrS(cmbo_drID.Text,cmbo_super.Text);
                if (result1 == 0 || result2==0)
                {
                    MessageBox.Show("Couldn't update Doctor");
                }
                else
                {
                    MessageBox.Show("Doctor updated successfully");

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllDr();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_chngHead_Click(object sender, EventArgs e)
        {
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
            int result2 = controllerObj.UpdateDepHead(DepartID.ToString(), cmbo_drID.Text);
            if (result2 == 0)
            {
                MessageBox.Show("Couldn't update Department");
            }
            else
            {
                MessageBox.Show("Department updated successfully");

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
