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
    public partial class Salaries : Form
    {
        Controller controllerObj = new Controller();
        public Salaries()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectIDsDrs();
            comboBox_DrS.DataSource = dt;
            comboBox_DrS.DisplayMember = "ID";

            dt = controllerObj.SelectIDsNrs();
            comboBox_NrS.DataSource = dt;
            comboBox_NrS.DisplayMember = "ID";

            dt = controllerObj.SelectIDsEmps();
            comboBox_EmpS.DataSource = dt;
            comboBox_EmpS.DisplayMember = "ID";
        }

        private void DrSbtn_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(textBox_DrS.Text, out check);
            if (ok)
            {
                int a = Int16.Parse(textBox_DrS.Text);
                ok = ok && a > 0;
            }

            ok = ok && (comboBox_DrS.Text.Length > 0 && textBox_DrS.Text.Length > 0);

            if (ok == false) 
                MessageBox.Show("Failed! Salary should be positive integer and no blank entries are allowed");
            else
            {
                int result = controllerObj.UpdateDrSS(comboBox_DrS.Text, textBox_DrS.Text);
                if (result == 0)
                {
                    MessageBox.Show("Updating Salary failed");
                }
                else
                {
                    MessageBox.Show("Salary is updated successfully!");
                }
            }
        }

        private void comboBox_DrS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NrSbtn_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(textBox_NrS.Text, out check);
            if (ok)
            {
                int a = Int16.Parse(textBox_NrS.Text);
                ok = ok && a > 0;
            }

            ok = ok && (comboBox_NrS.Text.Length > 0 && textBox_NrS.Text.Length > 0);

            if (ok == false)
                MessageBox.Show("Failed! Salary should be positive integer and no blank entries are allowed");
            else
            {
                int result = controllerObj.UpdateNrS(comboBox_NrS.Text, textBox_NrS.Text);
                if (result == 0)
                {
                    MessageBox.Show("Updating Salary failed");
                }
                else
                {
                    MessageBox.Show("Salary is updated successfully!");
                }
            }
        }

        private void EmpSbtn_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(textBox_EmpS.Text, out check);
            if (ok)
            {
                int a = Int16.Parse(textBox_EmpS.Text);
                ok = ok && a > 0;
            }

            ok = ok && (comboBox_EmpS.Text.Length > 0 && textBox_EmpS.Text.Length > 0);

            if (ok == false)
                MessageBox.Show("Failed! Salary should be positive integer and no blank entries are allowed");
            else
            {
                int result = controllerObj.UpdateEmpS(comboBox_EmpS.Text, textBox_EmpS.Text);
                if (result == 0)
                {
                    MessageBox.Show("Updating Salary failed");
                }
                else
                {
                    MessageBox.Show("Salary is updated successfully!");
                }
            }
        }
    }
}
