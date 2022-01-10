namespace DBapplication
{
    partial class DocForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.schedule_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pat_fname = new System.Windows.Forms.Label();
            this.pat_sex = new System.Windows.Forms.Label();
            this.pat_blood_combo = new System.Windows.Forms.ComboBox();
            this.Allergies_combo = new System.Windows.Forms.ComboBox();
            this.Change_btype_button = new System.Windows.Forms.Button();
            this.Add_Allergy_button = new System.Windows.Forms.Button();
            this.Add_Disease_button = new System.Windows.Forms.Button();
            this.Disease_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pat_ID_combo = new System.Windows.Forms.ComboBox();
            this.Add_Allergy_textbox = new System.Windows.Forms.TextBox();
            this.Add_Disease_textbox = new System.Windows.Forms.TextBox();
            this.Appointments_dates_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pat_lname = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.reportbox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UpdateRep_button = new System.Windows.Forms.Button();
            this.PatientSearch = new System.Windows.Forms.Button();
            this.Dismiss_Patient_button = new System.Windows.Forms.Button();
            this.req_surgery = new System.Windows.Forms.Button();
            this.patblood = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pat_DOB = new System.Windows.Forms.Label();
            this.surgeryCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // schedule_btn
            // 
            this.schedule_btn.Location = new System.Drawing.Point(14, 12);
            this.schedule_btn.Name = "schedule_btn";
            this.schedule_btn.Size = new System.Drawing.Size(121, 28);
            this.schedule_btn.TabIndex = 0;
            this.schedule_btn.Text = "Schedule";
            this.schedule_btn.UseVisualStyleBackColor = true;
            this.schedule_btn.Click += new System.EventHandler(this.schedule_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Blood Type :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Allergies : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 7;
            // 
            // pat_fname
            // 
            this.pat_fname.AutoSize = true;
            this.pat_fname.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pat_fname.Location = new System.Drawing.Point(134, 184);
            this.pat_fname.Name = "pat_fname";
            this.pat_fname.Size = new System.Drawing.Size(47, 16);
            this.pat_fname.TabIndex = 11;
            this.pat_fname.Text = "fname";
            // 
            // pat_sex
            // 
            this.pat_sex.AutoSize = true;
            this.pat_sex.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pat_sex.Location = new System.Drawing.Point(134, 294);
            this.pat_sex.Name = "pat_sex";
            this.pat_sex.Size = new System.Drawing.Size(79, 16);
            this.pat_sex.TabIndex = 13;
            this.pat_sex.Text = "pat gender";
            // 
            // pat_blood_combo
            // 
            this.pat_blood_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pat_blood_combo.FormattingEnabled = true;
            this.pat_blood_combo.Items.AddRange(new object[] {
            "O-",
            "O+",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+"});
            this.pat_blood_combo.Location = new System.Drawing.Point(264, 335);
            this.pat_blood_combo.Name = "pat_blood_combo";
            this.pat_blood_combo.Size = new System.Drawing.Size(100, 24);
            this.pat_blood_combo.TabIndex = 14;
            // 
            // Allergies_combo
            // 
            this.Allergies_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Allergies_combo.FormattingEnabled = true;
            this.Allergies_combo.Location = new System.Drawing.Point(137, 407);
            this.Allergies_combo.Name = "Allergies_combo";
            this.Allergies_combo.Size = new System.Drawing.Size(121, 24);
            this.Allergies_combo.TabIndex = 15;
            // 
            // Change_btype_button
            // 
            this.Change_btype_button.Location = new System.Drawing.Point(370, 323);
            this.Change_btype_button.Name = "Change_btype_button";
            this.Change_btype_button.Size = new System.Drawing.Size(129, 46);
            this.Change_btype_button.TabIndex = 16;
            this.Change_btype_button.Text = "Change";
            this.Change_btype_button.UseVisualStyleBackColor = true;
            this.Change_btype_button.Click += new System.EventHandler(this.Change_btype_button_Click);
            // 
            // Add_Allergy_button
            // 
            this.Add_Allergy_button.Location = new System.Drawing.Point(370, 398);
            this.Add_Allergy_button.Name = "Add_Allergy_button";
            this.Add_Allergy_button.Size = new System.Drawing.Size(129, 41);
            this.Add_Allergy_button.TabIndex = 17;
            this.Add_Allergy_button.Text = "Add Allergy";
            this.Add_Allergy_button.UseVisualStyleBackColor = true;
            this.Add_Allergy_button.Click += new System.EventHandler(this.Add_Allergy_button_Click);
            // 
            // Add_Disease_button
            // 
            this.Add_Disease_button.Location = new System.Drawing.Point(370, 461);
            this.Add_Disease_button.Name = "Add_Disease_button";
            this.Add_Disease_button.Size = new System.Drawing.Size(129, 41);
            this.Add_Disease_button.TabIndex = 21;
            this.Add_Disease_button.Text = "Add Disease";
            this.Add_Disease_button.UseVisualStyleBackColor = true;
            this.Add_Disease_button.Click += new System.EventHandler(this.Add_Disease_button_Click);
            // 
            // Disease_combo
            // 
            this.Disease_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Disease_combo.FormattingEnabled = true;
            this.Disease_combo.Location = new System.Drawing.Point(137, 470);
            this.Disease_combo.Name = "Disease_combo";
            this.Disease_combo.Size = new System.Drawing.Size(121, 24);
            this.Disease_combo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diseases : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 18;
            // 
            // pat_ID_combo
            // 
            this.pat_ID_combo.FormattingEnabled = true;
            this.pat_ID_combo.Location = new System.Drawing.Point(137, 103);
            this.pat_ID_combo.Name = "pat_ID_combo";
            this.pat_ID_combo.Size = new System.Drawing.Size(197, 24);
            this.pat_ID_combo.TabIndex = 22;
            this.pat_ID_combo.SelectedIndexChanged += new System.EventHandler(this.Pat_ID_combo_SelectionChangeCommitted);
            // 
            // Add_Allergy_textbox
            // 
            this.Add_Allergy_textbox.Location = new System.Drawing.Point(264, 407);
            this.Add_Allergy_textbox.Name = "Add_Allergy_textbox";
            this.Add_Allergy_textbox.Size = new System.Drawing.Size(100, 22);
            this.Add_Allergy_textbox.TabIndex = 23;
            // 
            // Add_Disease_textbox
            // 
            this.Add_Disease_textbox.Location = new System.Drawing.Point(264, 470);
            this.Add_Disease_textbox.Name = "Add_Disease_textbox";
            this.Add_Disease_textbox.Size = new System.Drawing.Size(100, 22);
            this.Add_Disease_textbox.TabIndex = 24;
            // 
            // Appointments_dates_combo
            // 
            this.Appointments_dates_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Appointments_dates_combo.FormattingEnabled = true;
            this.Appointments_dates_combo.Location = new System.Drawing.Point(137, 137);
            this.Appointments_dates_combo.Name = "Appointments_dates_combo";
            this.Appointments_dates_combo.Size = new System.Drawing.Size(197, 24);
            this.Appointments_dates_combo.TabIndex = 26;
            this.Appointments_dates_combo.SelectionChangeCommitted += new System.EventHandler(this.Appointments_dates_combo_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Appointment:  :";
            // 
            // pat_lname
            // 
            this.pat_lname.AutoSize = true;
            this.pat_lname.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pat_lname.Location = new System.Drawing.Point(134, 211);
            this.pat_lname.Name = "pat_lname";
            this.pat_lname.Size = new System.Drawing.Size(45, 16);
            this.pat_lname.TabIndex = 28;
            this.pat_lname.Text = "lname";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "LastName: ";
            // 
            // reportbox
            // 
            this.reportbox.Location = new System.Drawing.Point(857, 86);
            this.reportbox.Name = "reportbox";
            this.reportbox.Size = new System.Drawing.Size(467, 238);
            this.reportbox.TabIndex = 29;
            this.reportbox.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(854, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Report : ";
            // 
            // UpdateRep_button
            // 
            this.UpdateRep_button.Location = new System.Drawing.Point(1019, 365);
            this.UpdateRep_button.Name = "UpdateRep_button";
            this.UpdateRep_button.Size = new System.Drawing.Size(129, 41);
            this.UpdateRep_button.TabIndex = 31;
            this.UpdateRep_button.Text = "Update Report";
            this.UpdateRep_button.UseVisualStyleBackColor = true;
            this.UpdateRep_button.Click += new System.EventHandler(this.UpdateRep_button_Click);
            // 
            // PatientSearch
            // 
            this.PatientSearch.Location = new System.Drawing.Point(158, 12);
            this.PatientSearch.Name = "PatientSearch";
            this.PatientSearch.Size = new System.Drawing.Size(161, 28);
            this.PatientSearch.TabIndex = 32;
            this.PatientSearch.Text = "Search for patient";
            this.PatientSearch.UseVisualStyleBackColor = true;
            this.PatientSearch.Click += new System.EventHandler(this.PatientSearch_Click);
            // 
            // Dismiss_Patient_button
            // 
            this.Dismiss_Patient_button.Location = new System.Drawing.Point(370, 571);
            this.Dismiss_Patient_button.Name = "Dismiss_Patient_button";
            this.Dismiss_Patient_button.Size = new System.Drawing.Size(129, 40);
            this.Dismiss_Patient_button.TabIndex = 33;
            this.Dismiss_Patient_button.Text = "Dismiss";
            this.Dismiss_Patient_button.UseVisualStyleBackColor = true;
            this.Dismiss_Patient_button.Click += new System.EventHandler(this.Dismiss_Patient_button_Click);
            // 
            // req_surgery
            // 
            this.req_surgery.Location = new System.Drawing.Point(370, 513);
            this.req_surgery.Name = "req_surgery";
            this.req_surgery.Size = new System.Drawing.Size(129, 43);
            this.req_surgery.TabIndex = 34;
            this.req_surgery.Text = "Request Surgery";
            this.req_surgery.UseVisualStyleBackColor = true;
            this.req_surgery.Click += new System.EventHandler(this.req_surgery_Click);
            // 
            // patblood
            // 
            this.patblood.AutoSize = true;
            this.patblood.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patblood.Location = new System.Drawing.Point(134, 335);
            this.patblood.Name = "patblood";
            this.patblood.Size = new System.Drawing.Size(68, 16);
            this.patblood.TabIndex = 37;
            this.patblood.Text = "pat blood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "DOB:";
            // 
            // Pat_DOB
            // 
            this.Pat_DOB.AutoSize = true;
            this.Pat_DOB.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_DOB.Location = new System.Drawing.Point(134, 248);
            this.Pat_DOB.Name = "Pat_DOB";
            this.Pat_DOB.Size = new System.Drawing.Size(57, 16);
            this.Pat_DOB.TabIndex = 39;
            this.Pat_DOB.Text = "pat bod";
            // 
            // surgeryCombo
            // 
            this.surgeryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surgeryCombo.FormattingEnabled = true;
            this.surgeryCombo.Location = new System.Drawing.Point(137, 523);
            this.surgeryCombo.Name = "surgeryCombo";
            this.surgeryCombo.Size = new System.Drawing.Size(121, 24);
            this.surgeryCombo.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "SurgeryType";
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 642);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.surgeryCombo);
            this.Controls.Add(this.Pat_DOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patblood);
            this.Controls.Add(this.req_surgery);
            this.Controls.Add(this.Dismiss_Patient_button);
            this.Controls.Add(this.PatientSearch);
            this.Controls.Add(this.UpdateRep_button);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.reportbox);
            this.Controls.Add(this.pat_lname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Appointments_dates_combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_Disease_textbox);
            this.Controls.Add(this.Add_Allergy_textbox);
            this.Controls.Add(this.pat_ID_combo);
            this.Controls.Add(this.Add_Disease_button);
            this.Controls.Add(this.Disease_combo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Add_Allergy_button);
            this.Controls.Add(this.Change_btype_button);
            this.Controls.Add(this.Allergies_combo);
            this.Controls.Add(this.pat_blood_combo);
            this.Controls.Add(this.pat_sex);
            this.Controls.Add(this.pat_fname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schedule_btn);
            this.Name = "DocForm";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.DocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button schedule_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label pat_fname;
        private System.Windows.Forms.Label pat_sex;
        private System.Windows.Forms.ComboBox pat_blood_combo;
        private System.Windows.Forms.ComboBox Allergies_combo;
        private System.Windows.Forms.Button Change_btype_button;
        private System.Windows.Forms.Button Add_Allergy_button;
        private System.Windows.Forms.Button Add_Disease_button;
        private System.Windows.Forms.ComboBox Disease_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox pat_ID_combo;
        private System.Windows.Forms.TextBox Add_Allergy_textbox;
        private System.Windows.Forms.TextBox Add_Disease_textbox;
        private System.Windows.Forms.ComboBox Appointments_dates_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pat_lname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox reportbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button UpdateRep_button;
        private System.Windows.Forms.Button PatientSearch;
        private System.Windows.Forms.Button Dismiss_Patient_button;
        private System.Windows.Forms.Button req_surgery;
        private System.Windows.Forms.Label patblood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pat_DOB;
        private System.Windows.Forms.ComboBox surgeryCombo;
        private System.Windows.Forms.Label label11;
    }
}