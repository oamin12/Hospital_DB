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
    public partial class Add_a_User : Form
    {
        Controller controllerObj = new Controller();
        public Add_a_User()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllUserType();
            cmbo_usertype.DataSource = dt;
            cmbo_usertype.DisplayMember = "Tname";

            dt = controllerObj.SelectAllPersonID();
            cmbo_ID.DataSource = dt;
            cmbo_ID.DisplayMember = "ID";

        }

        private void Add_a_User_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {

            if (txtbox_UserName.Text == "")
            {
                MessageBox.Show("please enter a UserName");
                return;
            }
            if (txtbox_Pass.Text == "")
            {
                MessageBox.Show("please enter a password");
                return;
            }
            string UserTypeID;
            if (cmbo_usertype.Text == "Doctor")
            {
                UserTypeID = "1";
            }
            else if (cmbo_usertype.Text == "Reception")
            {
                UserTypeID = "2";
            }
            else if (cmbo_usertype.Text == "Accouting")
            {
                UserTypeID = "3";
            }
            else
            {
                UserTypeID = "4";
            }


            int result = controllerObj.InsertUser(txtbox_Pass.Text, cmbo_ID.Text,txtbox_UserName.Text,UserTypeID);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new User failed");
            }
            else
            {
                MessageBox.Show("The User is added successfully!");
            }
        }
    }
}
