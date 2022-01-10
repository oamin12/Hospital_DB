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
        int patid = 0;
        int patpersonid;
        Controller controllerobj;
        public DocForm(int ID , Controller c)
        {
            myID = ID;
            controllerobj = new Controller();
            InitializeComponent();
        }


        private void RefreshValues()
        {
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) {

                patblood.Text = "";
                pat_fname.Text = "";
                pat_lname.Text = "";
                pat_sex.Text = "";
                Pat_DOB.Text = "";
                surgeryCombo.Text = null;
                pat_ID_combo.Text = null;
                Appointments_dates_combo.Text = null;
                pat_blood_combo.Text = null;
                Allergies_combo.Text = null;
                Disease_combo.Text = null;
                reportbox.Text = "";

                return; }

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
            dt = controllerobj.Selectoptype();
            surgeryCombo.DataSource = dt;
            surgeryCombo.DisplayMember = "Oname";
            patblood.Text = "";
            pat_fname.Text = "";
            pat_lname.Text = "";
            pat_sex.Text = "";
            Pat_DOB.Text = "";
            pat_ID_combo.Text = null;
            surgeryCombo.Text = null;
            Appointments_dates_combo.Text = null;
            pat_blood_combo.Text = null;
           Allergies_combo.Text = null;
            Disease_combo.Text = null;
            reportbox.Text = "";


        }

        private void Pat_ID_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Refresh patient values
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) { return; }

            int.TryParse(asd, out patid);


            //show bloodType & allergies
            DataTable dt = controllerobj.SelectPatientdata(patid);
            if (dt == null) { return; }
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
            if (dt != null) {
            string report = dt.Rows[0][0].ToString();
            reportbox.Text = report;
        }



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
            pat_blood_combo.Text = "";
        }

        private void Add_Allergy_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pat_fname.Text)) { MessageBox.Show("No patient chosen!!"); return; }
            if (String.IsNullOrEmpty(Add_Allergy_textbox.Text)) { MessageBox.Show("No Allergy added!"); return; }
            int x = controllerobj.InsertAllergy(patid, Add_Allergy_textbox.Text);
            if (x != 0) { Add_Allergy_textbox.Text = ""; RefreshValues(); }
        }

        private void Add_Disease_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pat_fname.Text)) { MessageBox.Show("No patient chosen!!"); return; }
            if (String.IsNullOrEmpty(Add_Disease_textbox.Text)) { MessageBox.Show("No Disease added!"); return; }
            int x = controllerobj.InsertDisease(patid, Add_Disease_textbox.Text);
            if (x != 0) { Add_Disease_textbox.Text = ""; RefreshValues(); }
        }

        private void UpdateRep_button_Click(object sender, EventArgs e)
        {
            string appoint = Appointments_dates_combo.Text;
            if (String.IsNullOrEmpty(appoint)) { MessageBox.Show("no appointment chosen"); return; }
            int x = controllerobj.UpdateReport(patid , reportbox.Text , appoint);
            if (x != 0) { RefreshValues(); MessageBox.Show("report updated"); }
        }

        private void Appointments_dates_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshValues();
            
        }

        private void Dismiss_Patient_button_Click(object sender, EventArgs e)
        {
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) { MessageBox.Show("No patient Choosed"); return; }

            int.TryParse(asd, out patid);
            controllerobj.DeletePatientsAppointments(patid);
            controllerobj.DeletePatientsOperations(patid);
            controllerobj.DeletePatientsScans(patid);
            controllerobj.Patient_has_no_doctor(patid);
            controllerobj.Patient_leaves_Room(patid);
            pat_ID_combo.Text = "";
            DataTable dt = controllerobj.SelectDocPatient_IDs(myID);
            pat_ID_combo.DataSource = dt;
            pat_ID_combo.DisplayMember = "ID";
            MessageBox.Show("Dismiss done.");
            RefreshValues();

        }

        private void PatientSearch_Click(object sender, EventArgs e)
        {
            Find_pat findp = new Find_pat(myID, controllerobj);
            findp.Show();
        }

        public DocForm(int ID)
        {

            InitializeComponent();
        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            DocSchedule docs = new DocSchedule(myID , controllerobj);
            docs.Show();
        }

        private void req_surgery_Click(object sender, EventArgs e)
        {
            string asd = pat_ID_combo.Text;
            if (String.IsNullOrEmpty(asd)) { MessageBox.Show("No patient Choosed"); return; }
            int.TryParse(asd, out patid);
            if (string.IsNullOrEmpty(surgeryCombo.Text)) { MessageBox.Show("no surgey was chosen");return; }
            int x = controllerobj.getoptype(surgeryCombo.Text);
          
            int y = controllerobj.requestsurg(myID , patid , x);
            if (y != 0) { MessageBox.Show("request done") ; }



        }
    }
}
