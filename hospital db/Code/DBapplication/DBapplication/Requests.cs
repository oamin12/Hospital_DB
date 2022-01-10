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
    public partial class Requests : Form
    {
        Controller controllerObj = new Controller();
        public Requests()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectScansIDs();
            comboBox_scan.DataSource = dt;
            comboBox_scan.DisplayMember = "ScanRequestID";

            dt= controllerObj.SelectRoomsIDs();
            comboBox_room.DataSource = dt;
            comboBox_room.DisplayMember = "RoomRequestID";

            dt = controllerObj.SelectOperationssIDs();
            comboBox_operation.DataSource = dt;
            comboBox_operation.DisplayMember = "Operation_ID";

            dt = controllerObj.SelectAppointmentssIDs();
            comboBox_appointment.DataSource = dt;
            comboBox_appointment.DisplayMember = "AppointmentRequestID";
            
        }

        private void comboBox_scan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApproveScan_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateScanAccept(comboBox_scan.Text);
            //if (result == 0)
            //{
            //    MessageBox.Show("Please select a scan request to be approved");
            //}
            //else
            //{
            //    MessageBox.Show("The scan request is approved successfully!");
            //}
            int result2 = controllerObj.InsertApprovedScan(comboBox_scan.Text);
            if (result2 == 0)
            {
                MessageBox.Show("There is no scan request to be approved");
            }
            else
            {
                MessageBox.Show("The scan request is approved and sent to the [Has_a_scan] table successfully!");
            }
            int c = 0;
            int result3 = controllerObj.InsertScanTransaction(c++,comboBox_scan.Text);
        }

        private void CancelScan_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateScanCancel(comboBox_scan.Text);
            if (result == 0)
            {
                MessageBox.Show("There is no scan request to be cancelled");
            }
            else
            {
                MessageBox.Show("The scan request is cancelled successfully!");
            }
        }

        private void ShowScans_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllScanReq(); ;
            ShowingRequests.DataSource = dt;
            ShowingRequests.Refresh();
        }

        private void ApproveRoom_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateRoomAccept(comboBox_room.Text);
            int result2 = controllerObj.InsertApprovedRoom(comboBox_room.Text);
            if (result2 == 0)
            {
                MessageBox.Show("There is no room request to be approved");
            }
            else
            {
                MessageBox.Show("The room request is approved and sent to the [Room] table successfully!");
            }
            int c = 0;
            int result3 = controllerObj.InsertScanTransaction(c++, comboBox_room.Text);
        }

        private void CancelRoom_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateRoomCancel(comboBox_room.Text);
            if (result == 0)
            {
                MessageBox.Show("There is no room request to be cancelled");
            }
            else
            {
                MessageBox.Show("The room request is cancelled successfully!");
            }
        }

        private void ShowRoomss_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllRoomReq(); ;
            ShowingRequests.DataSource = dt;
            ShowingRequests.Refresh();
        }

        private void comboBox_operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApproveOperation_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateOperationAccept(comboBox_operation.Text);
            int result2 = controllerObj.InsertApprovedOperation(comboBox_operation.Text);
            if (result2 == 0)
            {
                MessageBox.Show("There is no operation request to be approved");
            }
            else
            {
                MessageBox.Show("The operation request is approved and sent to the [operations] table successfully!");
            }
            int c = 0;
            int result3 = controllerObj.InsertScanTransaction(c++, comboBox_operation.Text);
        }

        private void CancelOperation_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateOperationCancel(comboBox_operation.Text);
            if (result == 0)
            {
                MessageBox.Show("There is no operation request to be cancelled");
            }
            else
            {
                MessageBox.Show("The operation request is cancelled successfully!");
            }
        }

        private void ShowOperationss_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllOperationReq(); ;
            ShowingRequests.DataSource = dt;
            ShowingRequests.Refresh();
        }

        private void ApproveAppointment_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateAppointmentAccept(comboBox_appointment.Text);
            int result2 = controllerObj.InsertApprovedAppointment(comboBox_appointment.Text);
            if (result2 == 0)
            {
                MessageBox.Show("There is no appointment request to be approved");
            }
            else
            {
                MessageBox.Show("The appointment request is approved and sent to the [Appointment] table successfully!");
            }
            int c = 0;
            int result3 = controllerObj.InsertScanTransaction(c++, comboBox_appointment.Text);
        }

        private void CancelAppointment_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateAppointmentCancel(comboBox_appointment.Text);
            if (result == 0)
            {
                MessageBox.Show("There is no appointment request to be cancelled");
            }
            else
            {
                MessageBox.Show("The appointment request is cancelled successfully!");
            }
        }

        private void ShowAppointmentss_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllAppointmentReq(); ;
            ShowingRequests.DataSource = dt;
            ShowingRequests.Refresh();
        }
    }
}
