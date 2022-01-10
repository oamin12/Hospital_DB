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
    public partial class Search_Staff : Form
    {
        Controller controllerObj = new Controller();
        public Search_Staff()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllFnames();
            comboBox_srcName.DataSource = dt;
            comboBox_srcName.DisplayMember = "FName";
        }

        private void comboBox_srcName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectSearch(comboBox_srcName.Text); ;
            dataGridView_src.DataSource = dt;
            dataGridView_src.Refresh();
        }
    }
}
