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
    public partial class Transactions : Form
    {
        Controller controllerObj = new Controller();
        public Transactions()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAlltrans();
            comboBox_trans.DataSource = dt;
            comboBox_trans.DisplayMember = "requestID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check;
            bool ok = int.TryParse(textBox_trans.Text, out check);
            ok = ok && (textBox_trans.Text.Length > 0 );

            if (ok == false) 
                MessageBox.Show("Failed! Please insert a payment");
            else
            {
                int result = controllerObj.Updatepayment(textBox_trans.Text, comboBox_trans.Text);
                if (result == 0)
                {
                    MessageBox.Show("Transaction failed");
                }
                else
                {
                    MessageBox.Show("Transaction is inserted successfully!");
                }
            }
        }
    }
}
