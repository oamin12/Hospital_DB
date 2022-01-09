
namespace DBapplication
{
    partial class Scan_Res
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReserveScanButton = new System.Windows.Forms.Button();
            this.PickScan_Combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PickPatient_ComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReserveScanButton
            // 
            this.ReserveScanButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveScanButton.Location = new System.Drawing.Point(326, 279);
            this.ReserveScanButton.Name = "ReserveScanButton";
            this.ReserveScanButton.Size = new System.Drawing.Size(212, 60);
            this.ReserveScanButton.TabIndex = 9;
            this.ReserveScanButton.Text = "Reserve scan";
            this.ReserveScanButton.UseVisualStyleBackColor = true;
            this.ReserveScanButton.Click += new System.EventHandler(this.ReserveScanButton_Click);
            // 
            // PickScan_Combobox
            // 
            this.PickScan_Combobox.FormattingEnabled = true;
            this.PickScan_Combobox.Location = new System.Drawing.Point(389, 142);
            this.PickScan_Combobox.Name = "PickScan_Combobox";
            this.PickScan_Combobox.Size = new System.Drawing.Size(260, 24);
            this.PickScan_Combobox.TabIndex = 8;
           // this.PickScan_Combobox.SelectedIndexChanged += new System.EventHandler(this.PickScan_Combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scan type";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose patient";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PickPatient_ComboBox
            // 
            this.PickPatient_ComboBox.FormattingEnabled = true;
            this.PickPatient_ComboBox.Location = new System.Drawing.Point(389, 79);
            this.PickPatient_ComboBox.Name = "PickPatient_ComboBox";
            this.PickPatient_ComboBox.Size = new System.Drawing.Size(260, 24);
            this.PickPatient_ComboBox.TabIndex = 5;
            //this.PickPatient_ComboBox.SelectedIndexChanged += new System.EventHandler(this.PickPatient_ComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 10;
            //this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time and date";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Scan_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ReserveScanButton);
            this.Controls.Add(this.PickScan_Combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PickPatient_ComboBox);
            this.Name = "Scan_Res";
            this.Size = new System.Drawing.Size(878, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReserveScanButton;
        private System.Windows.Forms.ComboBox PickScan_Combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PickPatient_ComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}
