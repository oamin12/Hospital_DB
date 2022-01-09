﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Find_Patient : Form
    {
        int myID;
        Controller controllerobj;
        public Find_Patient(int ID, Controller c)
        {
            myID = ID;
            InitializeComponent();
            controllerobj = c;
        }

        private void Find_Patient_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.SelectPatientsnames();
            Name_Combo.DataSource = dt;
            Name_Combo.DisplayMember = "FName";
            Name_Combo.Text = "";

        }

        private void GetId_btn_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (String.IsNullOrEmpty(Name_Combo.Text)) { dt = controllerobj.SelectallPatientnameanddata(myID); Patient_ID_Data.DataSource = dt;
                Patient_ID_Data.Refresh(); return; }
            string fname = Name_Combo.Text;
            dt = controllerobj.SelectPatientnameanddata(fname , myID);
            Patient_ID_Data.DataSource = dt;
            Patient_ID_Data.Refresh();
        }


    }
}