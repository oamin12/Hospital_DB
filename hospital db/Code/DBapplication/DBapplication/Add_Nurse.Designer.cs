
namespace DBapplication
{
    partial class Add_Nurse
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_salary = new System.Windows.Forms.TextBox();
            this.btn_add_nurse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbo_super = new System.Windows.Forms.ComboBox();
            this.cmbo_Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Salary";
            // 
            // txtbox_salary
            // 
            this.txtbox_salary.Location = new System.Drawing.Point(231, 143);
            this.txtbox_salary.Name = "txtbox_salary";
            this.txtbox_salary.Size = new System.Drawing.Size(169, 22);
            this.txtbox_salary.TabIndex = 43;
            // 
            // btn_add_nurse
            // 
            this.btn_add_nurse.Location = new System.Drawing.Point(21, 376);
            this.btn_add_nurse.Name = "btn_add_nurse";
            this.btn_add_nurse.Size = new System.Drawing.Size(174, 43);
            this.btn_add_nurse.TabIndex = 42;
            this.btn_add_nurse.Text = "Add a Nurse";
            this.btn_add_nurse.UseVisualStyleBackColor = true;
            this.btn_add_nurse.Click += new System.EventHandler(this.btn_add_nurse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Supervisor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name";
            // 
            // cmbo_super
            // 
            this.cmbo_super.FormattingEnabled = true;
            this.cmbo_super.Location = new System.Drawing.Point(231, 87);
            this.cmbo_super.Name = "cmbo_super";
            this.cmbo_super.Size = new System.Drawing.Size(171, 24);
            this.cmbo_super.TabIndex = 34;
            // 
            // cmbo_Gender
            // 
            this.cmbo_Gender.FormattingEnabled = true;
            this.cmbo_Gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbo_Gender.Location = new System.Drawing.Point(26, 325);
            this.cmbo_Gender.Name = "cmbo_Gender";
            this.cmbo_Gender.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Gender.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(27, 203);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(169, 22);
            this.txtbox_ID.TabIndex = 30;
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(27, 143);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Lname.TabIndex = 29;
            this.txtbox_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Lname_KeyPress);
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(27, 89);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Fname.TabIndex = 28;
            this.txtbox_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Fname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add a Nurse";
            // 
            // Add_Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_salary);
            this.Controls.Add(this.btn_add_nurse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_super);
            this.Controls.Add(this.cmbo_Gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.txtbox_Lname);
            this.Controls.Add(this.txtbox_Fname);
            this.Controls.Add(this.label1);
            this.Name = "Add_Nurse";
            this.Text = "Add_Nurse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_salary;
        private System.Windows.Forms.Button btn_add_nurse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbo_super;
        private System.Windows.Forms.ComboBox cmbo_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.Label label1;
    }
}