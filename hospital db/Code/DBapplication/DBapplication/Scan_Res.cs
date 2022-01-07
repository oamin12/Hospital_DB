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
    public partial class Scan_Res : UserControl
    {
        Controller controllerObj;
        public Scan_Res()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable PN = controllerObj.SelectPatients();
            PickPatient_ComboBox.DataSource = PN;
            PickPatient_ComboBox.DisplayMember = "FName";
            PickPatient_ComboBox.ValueMember = "ID";

            DataTable Ss = controllerObj.SelectScanType();
            PickScan_Combobox.DataSource = Ss;
            PickScan_Combobox.DisplayMember = "SType";
            PickScan_Combobox.ValueMember = "ID";



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReserveScanButton_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int r = controllerObj.RequestScan(Convert.ToInt32(PickScan_Combobox.Text),Convert.ToInt32(PickPatient_ComboBox.Text), theDate);

        }
    }
}
