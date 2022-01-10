
namespace DBapplication
{
    partial class Add_employee
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
            this.Add_Emp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbo_Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbo_empType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbo_Dep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Salary";
            // 
            // txtbox_salary
            // 
            this.txtbox_salary.Location = new System.Drawing.Point(18, 193);
            this.txtbox_salary.Name = "txtbox_salary";
            this.txtbox_salary.Size = new System.Drawing.Size(169, 22);
            this.txtbox_salary.TabIndex = 43;
            // 
            // Add_Emp
            // 
            this.Add_Emp.Location = new System.Drawing.Point(12, 364);
            this.Add_Emp.Name = "Add_Emp";
            this.Add_Emp.Size = new System.Drawing.Size(174, 43);
            this.Add_Emp.TabIndex = 42;
            this.Add_Emp.Text = "Add an Employee";
            this.Add_Emp.UseVisualStyleBackColor = true;
            this.Add_Emp.Click += new System.EventHandler(this.Add_Emp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name";
            // 
            // cmbo_Gender
            // 
            this.cmbo_Gender.FormattingEnabled = true;
            this.cmbo_Gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbo_Gender.Location = new System.Drawing.Point(17, 313);
            this.cmbo_Gender.Name = "cmbo_Gender";
            this.cmbo_Gender.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Gender.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(18, 131);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Lname.TabIndex = 29;
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(18, 77);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Fname.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add an Employee";
            // 
            // cmbo_empType
            // 
            this.cmbo_empType.FormattingEnabled = true;
            this.cmbo_empType.Location = new System.Drawing.Point(220, 131);
            this.cmbo_empType.Name = "cmbo_empType";
            this.cmbo_empType.Size = new System.Drawing.Size(171, 24);
            this.cmbo_empType.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Type";
            // 
            // cmbo_Dep
            // 
            this.cmbo_Dep.FormattingEnabled = true;
            this.cmbo_Dep.Location = new System.Drawing.Point(220, 77);
            this.cmbo_Dep.Name = "cmbo_Dep";
            this.cmbo_Dep.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Dep.TabIndex = 33;
            this.cmbo_Dep.SelectedIndexChanged += new System.EventHandler(this.cmbo_Dep_SelectedIndexChanged);
            // 
            // Add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_salary);
            this.Controls.Add(this.Add_Emp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_empType);
            this.Controls.Add(this.cmbo_Dep);
            this.Controls.Add(this.cmbo_Gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_Lname);
            this.Controls.Add(this.txtbox_Fname);
            this.Controls.Add(this.label1);
            this.Name = "Add_employee";
            this.Text = "Add_employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_salary;
        private System.Windows.Forms.Button Add_Emp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbo_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_empType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbo_Dep;
    }
}