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
    public partial class Adminstration : Form
    {
        public Adminstration()
        {
            InitializeComponent();
        }

        private void Adminstration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_a_User user = new Add_a_User();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Doc_Click(object sender, EventArgs e)
        {
            Add_a_Doctor doc = new Add_a_Doctor();
            doc.Show();
        }

        private void Add_Nurse_Click(object sender, EventArgs e)
        {
            Add_Nurse Nurse = new Add_Nurse();
            Nurse.Show();
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Add_employee Emp = new Add_employee();
            Emp.Show();
        }
    }
}
