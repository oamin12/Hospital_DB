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
    public partial class ROOM_RES : UserControl
    {
        Controller controllerObj;
        public ROOM_RES()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable PN = controllerObj.SelectPatients();
            Patient_Pick_combobox.DataSource = PN;
            Patient_Pick_combobox.DisplayMember = "FName";
            Patient_Pick_combobox.ValueMember = "ID";
        }

        private void Reserve_bed_button_Click(object sender, EventArgs e)
        {
             //int r = controllerObj.ReserveRoom(, Convert.ToInt32(Patient_Pick_combobox.Text));
        }

        private void ROOM_RES_Load(object sender, EventArgs e)
        {

        }
    }
}
