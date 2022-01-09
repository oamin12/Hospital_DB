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
    public partial class Patient_page : UserControl
    {
        Controller controllerObj;
        int personId = 0;
        public Patient_page()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable Dp = controllerObj.SelectDepNAmeID();
            PickDep_combo.DataSource = Dp;
            PickDep_combo.DisplayMember = "DepName";
            PickDep_combo.ValueMember = "DepID";

            string[] genders = new string[] { "M", "F" };
            GenderCombo.DataSource = genders;

        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            if(FnameText.Text == "" || LnameText.Text == "")
            {
                MessageBox.Show("Please enter first and Last name");
            }
            else if(bloodtype.Text == "")
            {
                MessageBox.Show("Please enter blood type");
            }
            else if(bloodtype.Text != "A" && bloodtype.Text != "B" && bloodtype.Text != "AB" && bloodtype.Text != "O")
            {
                MessageBox.Show("please enter valid blood type");
            }
            else if(int.TryParse(FnameText.Text, out _) || int.TryParse(LnameText.Text, out _))
            {
                MessageBox.Show("Name cant be numbers");
            }
            else
            {
                string theDate = BODdateTime.Value.ToString("yyyyMMdd");
                int r = controllerObj.InsertPersonNoID(FnameText.Text.ToString(), LnameText.Text.ToString(), theDate, GenderCombo.SelectedItem.ToString());
                if(r ==1)
                {
                    personId = controllerObj.GetLastPersonId();
                    if (personId == 0)
                    {
                        MessageBox.Show("please re enter data");
                    }
                    else
                    {
                        int p = controllerObj.InsertNewPatient(personId, bloodtype.Text.ToString(), Convert.ToInt32(PickDoctor_combo.SelectedValue));
                        if(p == 1)
                        {
                            MessageBox.Show("Patient added successfuly");
                        }
                        else
                        {
                            MessageBox.Show("failed to add patient");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("please re enter data");
                }
            }


        }

        private void PickDep_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dp = controllerObj.SelectDoCtorNameId_Department(Convert.ToInt32(PickDep_combo.SelectedValue.GetHashCode()));
            PickDoctor_combo.DataSource = Dp;
            PickDoctor_combo.DisplayMember = "FName";
            PickDoctor_combo.ValueMember = "ID";
        }
    }
}
