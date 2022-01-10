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
    

    public partial class Show_stats : Form
    {
        Controller controllerObj = new Controller();
        public Show_stats()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllDeps();
            cmbo_Dep.DataSource = dt;
            cmbo_Dep.DisplayMember = "DepName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllDrStats();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllNursesStats();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllEmpsStats();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllDeps();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
