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
    public partial class Edit_User : Form
    {

        Controller controllerObj = new Controller();
        public Edit_User()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "")
            {
                MessageBox.Show("please enter Username");
                return;
            }
            if (txtbox_newVal.Text == "")
            {
                MessageBox.Show("please enter new value");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("please Select the parameter you want to change");
                return;
            }
            DataTable dt1 = controllerObj.UserNameExists(txtbox_username.Text);
            if (dt1 == null)
            {
                MessageBox.Show("Username doesn't exist");
                return;
            }
            if (comboBox1.Text == "Password")
            {
                int result1 = controllerObj.UpdatePass(txtbox_username.Text, txtbox_newVal.Text);
                if (result1 == 0)
                {
                    MessageBox.Show("Couldn't update password");
                }
                else
                {
                    MessageBox.Show("Password updated successfully");

                }
            }
            else
            {
                DataTable dt = controllerObj.UserNameExists(txtbox_newVal.Text);
                if (dt == null)
                {
                    int result1 = controllerObj.UpdateUsername(txtbox_username.Text, txtbox_newVal.Text);
                    if (result1 == 0)
                    {
                        MessageBox.Show("Couldn't update Username");
                    }
                    else
                    {
                        MessageBox.Show("Username updated successfully");

                    }
                }
                else
                {
                    MessageBox.Show("Username is taken");
                    return;

                }
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectUser();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
