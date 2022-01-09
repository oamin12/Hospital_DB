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
    public partial class SignInForm : Form
    {
        Controller controllerObj;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
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

            DataTable dt = controllerObj.UserNameExists(txtbox_UserName.Text);
            // int usern = dt.Rows.Count;
            if (dt == null)
            {
                MessageBox.Show("Username doesn't exist");
                return;
            }
            dt = controllerObj.checkpass(txtbox_Pass.Text, txtbox_UserName.Text);
            //usern = dt.Rows.Count;
            if (dt == null)
            {
                MessageBox.Show("Password is incorrect");
                return;
            }
            int usertype = controllerObj.getUserTypeID(txtbox_UserName.Text);
            
            if (usertype==1)
            {
                int Doc_ID = controllerObj.getDocID(txtbox_UserName.Text);
                DocForm docf = new DocForm(Doc_ID , controllerObj);
                docf.Show();
            }
            if (usertype == 2)
            {
                Reception rec = new Reception();
                rec.Show();
            }
            //if (usertype == 3)
            //{
            //    Accounting acc = new Accounting();
            //    acc.Show();
            //}
            if (usertype == 4)
            {
                Adminstration admin = new Adminstration();
                admin.Show();
            }
            // dt controllerObj.UserNameExists(txtbox_UserName.Text);
            // cmbo_usertype.DataSource = dt;
            // cmbo_usertype.DisplayMember = "Tname";
        }

    }
}
