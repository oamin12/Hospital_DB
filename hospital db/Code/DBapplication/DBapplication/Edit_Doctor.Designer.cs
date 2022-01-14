
namespace DBapplication
{
    partial class Edit_Doctor
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbo_super = new System.Windows.Forms.ComboBox();
            this.cmbo_Dep = new System.Windows.Forms.ComboBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.btn_chngDr = new System.Windows.Forms.Button();
            this.btn_chngHead = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbo_drID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit a Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Supervisor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Department";
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
            // cmbo_super
            // 
            this.cmbo_super.FormattingEnabled = true;
            this.cmbo_super.Location = new System.Drawing.Point(6, 154);
            this.cmbo_super.Name = "cmbo_super";
            this.cmbo_super.Size = new System.Drawing.Size(171, 24);
            this.cmbo_super.TabIndex = 27;
            // 
            // cmbo_Dep
            // 
            this.cmbo_Dep.FormattingEnabled = true;
            this.cmbo_Dep.Location = new System.Drawing.Point(6, 154);
            this.cmbo_Dep.Name = "cmbo_Dep";
            this.cmbo_Dep.Size = new System.Drawing.Size(171, 24);
            this.cmbo_Dep.TabIndex = 26;
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.Location = new System.Drawing.Point(8, 102);
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Lname.TabIndex = 25;
            this.txtbox_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Lname_KeyPress);
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.Location = new System.Drawing.Point(8, 48);
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(169, 22);
            this.txtbox_Fname.TabIndex = 24;
            this.txtbox_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Fname_KeyPress);
            // 
            // btn_chngDr
            // 
            this.btn_chngDr.Location = new System.Drawing.Point(8, 248);
            this.btn_chngDr.Name = "btn_chngDr";
            this.btn_chngDr.Size = new System.Drawing.Size(156, 52);
            this.btn_chngDr.TabIndex = 33;
            this.btn_chngDr.Text = "Change Doctor\'s Data";
            this.btn_chngDr.UseVisualStyleBackColor = true;
            this.btn_chngDr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_chngHead
            // 
            this.btn_chngHead.Location = new System.Drawing.Point(15, 248);
            this.btn_chngHead.Name = "btn_chngHead";
            this.btn_chngHead.Size = new System.Drawing.Size(156, 52);
            this.btn_chngHead.TabIndex = 34;
            this.btn_chngHead.Text = "Change Dep. Head";
            this.btn_chngHead.UseVisualStyleBackColor = true;
            this.btn_chngHead.Click += new System.EventHandler(this.btn_chngHead_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(431, 287);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(156, 52);
            this.btn_show.TabIndex = 35;
            this.btn_show.Text = "Show Doctors";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 215);
            this.dataGridView1.TabIndex = 36;
            // 
            // cmbo_drID
            // 
            this.cmbo_drID.FormattingEnabled = true;
            this.cmbo_drID.Location = new System.Drawing.Point(13, 48);
            this.cmbo_drID.Name = "cmbo_drID";
            this.cmbo_drID.Size = new System.Drawing.Size(171, 24);
            this.cmbo_drID.TabIndex = 37;
            this.cmbo_drID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_chngDr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbo_super);
            this.groupBox1.Controls.Add(this.txtbox_Lname);
            this.groupBox1.Controls.Add(this.txtbox_Fname);
            this.groupBox1.Location = new System.Drawing.Point(10, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 348);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbo_drID);
            this.groupBox2.Controls.Add(this.btn_chngHead);
            this.groupBox2.Controls.Add(this.cmbo_Dep);
            this.groupBox2.Location = new System.Drawing.Point(206, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 347);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Doctor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Department";
            // 
            // Edit_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Doctor";
            this.Text = "Edit Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbo_super;
        private System.Windows.Forms.ComboBox cmbo_Dep;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.Button btn_chngDr;
        private System.Windows.Forms.Button btn_chngHead;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbo_drID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}