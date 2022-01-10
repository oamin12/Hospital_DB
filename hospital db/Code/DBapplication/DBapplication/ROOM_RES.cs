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
        int NurseId = 0;
        public ROOM_RES()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable PN = controllerObj.SelectPatients();
            Patient_Pick_combobox.DataSource = PN;
            Patient_Pick_combobox.DisplayMember = "FName";
            Patient_Pick_combobox.ValueMember = "ID";

            DataTable RNumber = controllerObj.SelectAllRooms();
            RoomPick_Combobox.DataSource = RNumber;
            RoomPick_Combobox.DisplayMember = "ID";

        }

        private void Reserve_bed_button_Click(object sender, EventArgs e)
        {
            if (RoomPick_Combobox.SelectedItem == null)
            {
                MessageBox.Show("please pick a room");
            }
            else if (Patient_Pick_combobox.SelectedItem == null)
            {
                MessageBox.Show("please pick a patient");
            }
            else
            {
                NurseId = controllerObj.RetrieveCorrespondingNurse(Convert.ToInt32(RoomPick_Combobox.Text));
                if (NurseId == 0)
                {
                    MessageBox.Show("failed to load corresponding nurse");
                }
                else
                {
                    int r = controllerObj.RequestRoom(Convert.ToInt32(RoomPick_Combobox.Text), NurseId, Convert.ToInt32(Patient_Pick_combobox.SelectedValue));
                    if (r == 1)
                    {
                        MessageBox.Show("Room Reserved successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Room not reserved");
                    }
                }
            }
        }

        private void ROOM_RES_Load(object sender, EventArgs e)
        {

        }
    }
}
