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
    public partial class Reservations_page : UserControl
    {
        public Reservations_page()
        {
            InitializeComponent();

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ChooseResTypePanel.Controls.Clear();
            ChooseResTypePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BedsButton_Click(object sender, EventArgs e)
        {
            ROOM_RES Rs = new ROOM_RES();
            AddUserControl(Rs);
        }

        private void ScansButton_Click(object sender, EventArgs e)
        {
            Scan_Res SR = new Scan_Res();
            AddUserControl(SR);
        }

        private void SurgeriesButton_Click(object sender, EventArgs e)
        {
            Surgery_Res Ss = new Surgery_Res();
            AddUserControl(Ss);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
