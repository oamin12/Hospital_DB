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
    public partial class DocForm : Form
    {
        int myID;
        int patid;
        int patpersonid;
        Controller controllerobj;
        public DocForm(int ID , Controller c)
        {
            myID = ID;
            controllerobj = c;
            InitializeComponent();
        }


        private void RefreshValues()
        {
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) { return; }

            int.TryParse(asd, out patid);


            //show bloodType & allergies
            DataTable dt = controllerobj.SelectPatientdata(patid);
            int.TryParse(dt.Rows[0][1].ToString(), out patpersonid);
            patblood.Text = dt.Rows[0][2].ToString();

            dt = controllerobj.SelectPatientAllergies(patid);
            Allergies_combo.DataSource = dt;
            Allergies_combo.DisplayMember = "allergies";


            dt = controllerobj.SelectPatientDiseases(patid);
            Disease_combo.DataSource = dt;
            Disease_combo.DisplayMember = "Diseases";

            dt = controllerobj.SelectAppointmentsDates(myID, patid);
            Appointments_dates_combo.DataSource = dt;
            Appointments_dates_combo.DisplayMember = "Date_time";

            string appoint = Appointments_dates_combo.Text;

            dt = controllerobj.SelectAppointmentReport(myID, patid, appoint);
            string report = dt.Rows[0][0].ToString();
            reportbox.Text = report;




            //show patients data
            dt = controllerobj.SelectPatientPersondata(patpersonid);

            pat_fname.Text = dt.Rows[0][1].ToString();
            pat_lname.Text = dt.Rows[0][2].ToString();
            string dob = dt.Rows[0][3].ToString();



            var datetime = Convert.ToDateTime(dob);

            Pat_DOB.Text = datetime.ToShortDateString();
            pat_sex.Text = dt.Rows[0][4].ToString();

        }
        private void DocForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.SelectDocPatient_IDs(myID);
  
            pat_ID_combo.DataSource = dt;
            pat_ID_combo.DisplayMember = "ID";
            patblood.Text = "";
            pat_fname.Text = "";
            pat_lname.Text = "";
            pat_sex.Text = "";
            Pat_DOB.Text = "";
            pat_ID_combo.Text = "";


        }

        private void Pat_ID_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Refresh patient values
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) { return; }
            
            int.TryParse(asd, out patid);


            //show bloodType & allergies
            DataTable dt = controllerobj.SelectPatientdata(patid);
            int.TryParse(dt.Rows[0][1].ToString(), out patpersonid);
            patblood.Text = dt.Rows[0][2].ToString();

            dt = controllerobj.SelectPatientAllergies(patid);
            Allergies_combo.DataSource = dt;
            Allergies_combo.DisplayMember = "allergies";


            dt = controllerobj.SelectPatientDiseases(patid);
            Disease_combo.DataSource = dt;
            Disease_combo.DisplayMember = "Diseases";

            dt = controllerobj.SelectAppointmentsDates(myID , patid);
            Appointments_dates_combo.DataSource = dt;
            Appointments_dates_combo.DisplayMember = "Date_time";

            string appoint = Appointments_dates_combo.Text;

            dt = controllerobj.SelectAppointmentReport(myID, patid , appoint);
            string report = dt.Rows[0][0].ToString();
            reportbox.Text = report;




            //show patients data
            dt = controllerobj.SelectPatientPersondata(patpersonid);
         
            pat_fname.Text = dt.Rows[0][1].ToString();
            pat_lname.Text = dt.Rows[0][2].ToString();
            string dob = dt.Rows[0][3].ToString();

            

            var datetime = Convert.ToDateTime(dob);

            Pat_DOB.Text =  datetime.ToShortDateString();
            pat_sex.Text = dt.Rows[0][4].ToString();

        }

        private void Change_btype_button_Click(object sender, EventArgs e)
        {
         
            if (String.IsNullOrEmpty(pat_fname.Text)) { MessageBox.Show("No patient chosen!!"); return; }
            if(pat_blood_combo.SelectedItem == null) { MessageBox.Show("No blood type chosen!!"); return; }
            controllerobj.UpdateBloodType(patid , pat_blood_combo.Text  );
            RefreshValues();
        }

        private void Add_Allergy_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pat_fname.Text)) { MessageBox.Show("No patient chosen!!"); return; }
            if (String.IsNullOrEmpty(Add_Allergy_textbox.Text)) { MessageBox.Show("No Allergy added!"); return; }
        }
    }
}
