using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();
            Patient_page PP = new Patient_page();
            AddUserControl(PP);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ReservationsBtn_Click(object sender, EventArgs e)
        {
            Reservations_page RP = new Reservations_page();
            AddUserControl(RP);
        }
        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Patient_page PP = new Patient_page();
            AddUserControl(PP);
        }
        private void LookUpBtn_Click(object sender, EventArgs e)
        {
            look_Up_page LP = new look_Up_page();
            AddUserControl(LP);
        }
        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
