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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            Requests open = new Requests();
            open.Show();
        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            Transactions openTany = new Transactions();
            openTany.Show();
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            Salaries ana3ayzSALARY = new Salaries();
            ana3ayzSALARY.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search_Staff src = new Search_Staff();
            src.Show();
        }
    }
}
