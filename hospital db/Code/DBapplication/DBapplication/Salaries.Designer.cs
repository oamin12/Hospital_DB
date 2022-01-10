
namespace DBapplication
{
    partial class Salaries
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
            this.comboBox_DrS = new System.Windows.Forms.ComboBox();
            this.textBox_DrS = new System.Windows.Forms.TextBox();
            this.DrSbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_NrS = new System.Windows.Forms.ComboBox();
            this.comboBox_EmpS = new System.Windows.Forms.ComboBox();
            this.textBox_NrS = new System.Windows.Forms.TextBox();
            this.textBox_EmpS = new System.Windows.Forms.TextBox();
            this.NrSbtn = new System.Windows.Forms.Button();
            this.EmpSbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors Salaries";
            // 
            // comboBox_DrS
            // 
            this.comboBox_DrS.FormattingEnabled = true;
            this.comboBox_DrS.Location = new System.Drawing.Point(71, 72);
            this.comboBox_DrS.Name = "comboBox_DrS";
            this.comboBox_DrS.Size = new System.Drawing.Size(135, 24);
            this.comboBox_DrS.TabIndex = 1;
            this.comboBox_DrS.SelectedIndexChanged += new System.EventHandler(this.comboBox_DrS_SelectedIndexChanged);
            // 
            // textBox_DrS
            // 
            this.textBox_DrS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DrS.Location = new System.Drawing.Point(296, 74);
            this.textBox_DrS.Name = "textBox_DrS";
            this.textBox_DrS.Size = new System.Drawing.Size(137, 28);
            this.textBox_DrS.TabIndex = 2;
            // 
            // DrSbtn
            // 
            this.DrSbtn.Location = new System.Drawing.Point(546, 78);
            this.DrSbtn.Name = "DrSbtn";
            this.DrSbtn.Size = new System.Drawing.Size(163, 31);
            this.DrSbtn.TabIndex = 3;
            this.DrSbtn.Text = "Update Salary";
            this.DrSbtn.UseVisualStyleBackColor = true;
            this.DrSbtn.Click += new System.EventHandler(this.DrSbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nurses Salaries";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Employees Salaries";
            // 
            // comboBox_NrS
            // 
            this.comboBox_NrS.FormattingEnabled = true;
            this.comboBox_NrS.Location = new System.Drawing.Point(76, 183);
            this.comboBox_NrS.Name = "comboBox_NrS";
            this.comboBox_NrS.Size = new System.Drawing.Size(129, 24);
            this.comboBox_NrS.TabIndex = 8;
            // 
            // comboBox_EmpS
            // 
            this.comboBox_EmpS.FormattingEnabled = true;
            this.comboBox_EmpS.Location = new System.Drawing.Point(81, 290);
            this.comboBox_EmpS.Name = "comboBox_EmpS";
            this.comboBox_EmpS.Size = new System.Drawing.Size(123, 24);
            this.comboBox_EmpS.TabIndex = 9;
            // 
            // textBox_NrS
            // 
            this.textBox_NrS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NrS.Location = new System.Drawing.Point(298, 181);
            this.textBox_NrS.Name = "textBox_NrS";
            this.textBox_NrS.Size = new System.Drawing.Size(134, 28);
            this.textBox_NrS.TabIndex = 10;
            // 
            // textBox_EmpS
            // 
            this.textBox_EmpS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmpS.Location = new System.Drawing.Point(302, 282);
            this.textBox_EmpS.Name = "textBox_EmpS";
            this.textBox_EmpS.Size = new System.Drawing.Size(129, 28);
            this.textBox_EmpS.TabIndex = 11;
            // 
            // NrSbtn
            // 
            this.NrSbtn.Location = new System.Drawing.Point(550, 183);
            this.NrSbtn.Name = "NrSbtn";
            this.NrSbtn.Size = new System.Drawing.Size(158, 33);
            this.NrSbtn.TabIndex = 12;
            this.NrSbtn.Text = "Update Salary";
            this.NrSbtn.UseVisualStyleBackColor = true;
            this.NrSbtn.Click += new System.EventHandler(this.NrSbtn_Click);
            // 
            // EmpSbtn
            // 
            this.EmpSbtn.Location = new System.Drawing.Point(551, 279);
            this.EmpSbtn.Name = "EmpSbtn";
            this.EmpSbtn.Size = new System.Drawing.Size(156, 34);
            this.EmpSbtn.TabIndex = 13;
            this.EmpSbtn.Text = "Update Salary";
            this.EmpSbtn.UseVisualStyleBackColor = true;
            this.EmpSbtn.Click += new System.EventHandler(this.EmpSbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "New Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "New Salary";
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpSbtn);
            this.Controls.Add(this.NrSbtn);
            this.Controls.Add(this.textBox_EmpS);
            this.Controls.Add(this.textBox_NrS);
            this.Controls.Add(this.comboBox_EmpS);
            this.Controls.Add(this.comboBox_NrS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DrSbtn);
            this.Controls.Add(this.textBox_DrS);
            this.Controls.Add(this.comboBox_DrS);
            this.Controls.Add(this.label1);
            this.Name = "Salaries";
            this.Text = "Salaries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DrS;
        private System.Windows.Forms.TextBox textBox_DrS;
        private System.Windows.Forms.Button DrSbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_NrS;
        private System.Windows.Forms.ComboBox comboBox_EmpS;
        private System.Windows.Forms.TextBox textBox_NrS;
        private System.Windows.Forms.TextBox textBox_EmpS;
        private System.Windows.Forms.Button NrSbtn;
        private System.Windows.Forms.Button EmpSbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}