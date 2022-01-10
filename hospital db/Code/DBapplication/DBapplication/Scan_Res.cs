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

        private void ReserveScanButton_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyyMMdd");
            int r = controllerObj.RequestScan(Convert.ToInt32(PickPatient_ComboBox.SelectedValue.GetHashCode()), theDate, Convert.ToInt32(PickScan_Combobox.SelectedValue.GetHashCode()));
            if(r == 0 )
            {
                MessageBox.Show("Request not added");
            }
            else
            {
                MessageBox.Show("Scan Request added successfully");
            }
        }

    }
}
