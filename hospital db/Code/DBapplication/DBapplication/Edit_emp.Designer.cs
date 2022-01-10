
namespace DBapplication
{
    partial class Edit_emp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_chngNurse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbo_Dep = new System.Windows.Forms.ComboBox();
            this.cmbo_EmpID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_chngNurse);
            this.groupBox1.Controls.Add(this.cmbo_Dep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbox_Lname);
            this.groupBox1.Controls.Add(this.txtbox_Fname);
            this.groupBox1.Location = new System.Drawing.Point(23, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 348);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btn_chngNurse
            // 
            this.btn_chngNurse.Location = new System.Drawing.Point(8, 248);
            this.btn_chngNurse.Name = "btn_chngNurse";
            this.btn_chngNurse.Size = new System.Drawing.Size(156, 52);
            this.btn_chngNurse.TabIndex = 33;
            this.btn_chngNurse.Text = "Change Employees Data";
            this.btn_chngNurse.UseVisualStyleBackColor = true;
            this.btn_chngNurse.Click += new System.EventHandler(this.btn_chngNurse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(8, 102);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Lname.TabIndex = 25;
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(8, 48);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Fname.TabIndex = 24;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(444, 314);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(156, 52);
            this.btn_show.TabIndex = 48;
            this.btn_show.Text = "Show Employees";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 215);
            this.dataGridView1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Edit an Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Department";
            // 
            // cmbo_Dep
            // 
            this.cmbo_Dep.FormattingEnabled = true;
            this.cmbo_Dep.Location = new System.Drawing.Point(6, 175);
            this.cmbo_Dep.Name = "cmbo_Dep";
            this.cmbo_Dep.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Dep.TabIndex = 38;
            // 
            // cmbo_EmpID
            // 
            this.cmbo_EmpID.FormattingEnabled = true;
            this.cmbo_EmpID.Location = new System.Drawing.Point(229, 114);
            this.cmbo_EmpID.Name = "cmbo_EmpID";
            this.cmbo_EmpID.Size = new System.Drawing.Size(171, 24);
            this.cmbo_EmpID.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Employee ID";
            // 
            // Edit_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbo_EmpID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Edit_emp";
            this.Text = "Edit_emp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_chngNurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbo_Dep;
        private System.Windows.Forms.ComboBox cmbo_EmpID;
        private System.Windows.Forms.Label label5;
    }
}