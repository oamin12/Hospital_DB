
namespace DBapplication
{
    partial class Add_a_Doctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbo_Gender = new System.Windows.Forms.ComboBox();
            this.cmbo_Dep = new System.Windows.Forms.ComboBox();
            this.cmbo_super = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Add_doc = new System.Windows.Forms.Button();
            this.txtbox_salary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add a Doctor";
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(18, 86);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Fname.TabIndex = 10;
            this.txtbox_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Fname_KeyPress);
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(18, 140);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Lname.TabIndex = 11;
            this.txtbox_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Lname_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbo_Gender
            // 
            this.cmbo_Gender.FormattingEnabled = true;
            this.cmbo_Gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbo_Gender.Location = new System.Drawing.Point(17, 322);
            this.cmbo_Gender.Name = "cmbo_Gender";
            this.cmbo_Gender.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Gender.TabIndex = 14;
            this.cmbo_Gender.SelectedIndexChanged += new System.EventHandler(this.cmbo_Gender_SelectedIndexChanged);
            // 
            // cmbo_Dep
            // 
            this.cmbo_Dep.FormattingEnabled = true;
            this.cmbo_Dep.Location = new System.Drawing.Point(220, 86);
            this.cmbo_Dep.Name = "cmbo_Dep";
            this.cmbo_Dep.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Dep.TabIndex = 15;
            // 
            // cmbo_super
            // 
            this.cmbo_super.FormattingEnabled = true;
            this.cmbo_super.Location = new System.Drawing.Point(220, 140);
            this.cmbo_super.Name = "cmbo_super";
            this.cmbo_super.Size = new System.Drawing.Size(171, 24);
            this.cmbo_super.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Supervisor ID";
            // 
            // Add_doc
            // 
            this.Add_doc.Location = new System.Drawing.Point(12, 373);
            this.Add_doc.Name = "Add_doc";
            this.Add_doc.Size = new System.Drawing.Size(174, 43);
            this.Add_doc.TabIndex = 24;
            this.Add_doc.Text = "Add a Doctor";
            this.Add_doc.UseVisualStyleBackColor = true;
            this.Add_doc.Click += new System.EventHandler(this.Add_doc_Click);
            // 
            // txtbox_salary
            // 
            this.txtbox_salary.Location = new System.Drawing.Point(18, 200);
            this.txtbox_salary.Name = "txtbox_salary";
            this.txtbox_salary.Size = new System.Drawing.Size(168, 22);
            this.txtbox_salary.TabIndex = 25;
            this.txtbox_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_salary_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Salary";
            // 
            // Add_a_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_salary);
            this.Controls.Add(this.Add_doc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_super);
            this.Controls.Add(this.cmbo_Dep);
            this.Controls.Add(this.cmbo_Gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbox_Lname);
            this.Controls.Add(this.txtbox_Fname);
            this.Controls.Add(this.label1);
            this.Name = "Add_a_Doctor";
            this.Text = "Add_a_Doctor";
            this.Load += new System.EventHandler(this.Add_a_Doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbo_Gender;
        private System.Windows.Forms.ComboBox cmbo_Dep;
        private System.Windows.Forms.ComboBox cmbo_super;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Add_doc;
        private System.Windows.Forms.TextBox txtbox_salary;
        private System.Windows.Forms.Label label9;
    }
}