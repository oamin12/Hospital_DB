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
    public partial class Edit_Nurse : Form
    {
        Controller controllerObj = new Controller();

        public Edit_Nurse()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllNurseID();
            DataTable dt2 = controllerObj.SelectAllNurseID();
            DataTable dt3 = controllerObj.SelectAllroomID();
            if (dt != null)
            {
                dt.Rows.Add("-1");
                dt2.Rows.Add("-1");
                cmbo_super.DataSource = dt;
                cmbo_super.DisplayMember = "ID";
                cmbo_NurseID.DataSource = dt2;
                cmbo_NurseID.DisplayMember = "ID";
                
            }
            if (dt3 != null)
            {
                dt3.Rows.Add("-1");
                cmbo_Room.DataSource = dt3;
                cmbo_Room.DisplayMember = "ID";

            }
        }

        private void btn_chngDr_Click(object sender, EventArgs e)
        {
            if (txtbox_Fname.Text == "" && txtbox_Lname.Text == "" && cmbo_super.Text == "")
            {
                MessageBox.Show("please Select a parameter to change");
                return;
            }
            if (cmbo_NurseID.Text == cmbo_super.Text)
            {
                MessageBox.Show("SuperVisor Can't have the same ID");
                return;
            }
            int result1;
            int result2;
            int pID = controllerObj.getNursePID(cmbo_NurseID.Text);
            if (cmbo_super.Text == "-1")
            {
                result1 = controllerObj.UpdateDr(pID.ToString(), txtbox_Fname.Text, txtbox_Lname.Text);
                if (result1 == 0)
                {
                    MessageBox.Show("Couldn't update Nurse");
                }
                else
                {
                    MessageBox.Show("Nurse updated successfully");

                }
            }
            else
            {
                result1 = controllerObj.UpdateDr(pID.ToString(), txtbox_Fname.Text, txtbox_Lname.Text);
                result2 = controllerObj.UpdateNurseSuper(cmbo_NurseID.Text, cmbo_super.Text);
                if (result1 == 0 || result2 == 0)
                {
                    MessageBox.Show("Couldn't update Nurse");
                }
                else
                {
                    MessageBox.Show("Nurse updated successfully");

                }

            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllNurses();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void btn_chngRoom_Click(object sender, EventArgs e)
        {
           int  result2 = controllerObj.UpdateRoomRes(cmbo_Room.Text,cmbo_NurseID.Text);
            if (result2 == 0)
            {
                MessageBox.Show("Couldn't update Room");
            }
            else
            {
                MessageBox.Show("Room updated successfully");

            }
        }
    }
}
