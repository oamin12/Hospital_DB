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
    public partial class look_Up_page : UserControl
    {
        Controller controllerObj;
        public look_Up_page()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void look_Up_page_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (FnameText.Text == "" || LnameText.Text == "")
            {
                MessageBox.Show("Please enter full name");
            }
            else if (int.TryParse(FnameText.Text, out _) || int.TryParse(LnameText.Text, out _))
            {
                MessageBox.Show("Please enter appropriate alphabetical name");
            }

            DataTable dt = controllerObj.LookUpPatient(FnameText.Text.ToString(), LnameText.Text.ToString());
            ShowPatient.DataSource = dt;
            ShowPatient.Refresh();
        }
    }
}
