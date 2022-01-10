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
            DataTable dt = controllerObj.LookUpPatient(FnameText.Text.ToString(), LnameText.Text.ToString());
            ShowPatient.DataSource = dt;
            ShowPatient.Refresh();
        }
    }
}
