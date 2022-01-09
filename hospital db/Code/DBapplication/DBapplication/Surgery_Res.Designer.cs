
namespace DBapplication
{
    partial class Surgery_Res
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
            this.label3 = new System.Windows.Forms.Label();
            this.ReserveSuregeryButton = new System.Windows.Forms.Button();
            this.DoctroPick_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientPick_combo = new System.Windows.Forms.ComboBox();
            this.OperationTypePick_combo = new System.Windows.Forms.ComboBox();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Operation type";
            // 
            // ReserveSuregeryButton
            // 
            this.ReserveSuregeryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveSuregeryButton.Location = new System.Drawing.Point(361, 303);
            this.ReserveSuregeryButton.Name = "ReserveSuregeryButton";
            this.ReserveSuregeryButton.Size = new System.Drawing.Size(212, 60);
            this.ReserveSuregeryButton.TabIndex = 16;
            this.ReserveSuregeryButton.Text = "Reserve surgery";
            this.ReserveSuregeryButton.UseVisualStyleBackColor = true;
            this.ReserveSuregeryButton.Click += new System.EventHandler(this.ReserveSuregeryButton_Click);
            // 
            // DoctroPick_combo
            // 
            this.DoctroPick_combo.FormattingEnabled = true;
            this.DoctroPick_combo.Location = new System.Drawing.Point(198, 139);
            this.DoctroPick_combo.Name = "DoctroPick_combo";
            this.DoctroPick_combo.Size = new System.Drawing.Size(238, 24);
            this.DoctroPick_combo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose patient";
            // 
            // PatientPick_combo
            // 
            this.PatientPick_combo.FormattingEnabled = true;
            this.PatientPick_combo.Location = new System.Drawing.Point(198, 79);
            this.PatientPick_combo.Name = "PatientPick_combo";
            this.PatientPick_combo.Size = new System.Drawing.Size(238, 24);
            this.PatientPick_combo.TabIndex = 12;
            // 
            // OperationTypePick_combo
            // 
            this.OperationTypePick_combo.FormattingEnabled = true;
            this.OperationTypePick_combo.Location = new System.Drawing.Point(198, 206);
            this.OperationTypePick_combo.Name = "OperationTypePick_combo";
            this.OperationTypePick_combo.Size = new System.Drawing.Size(238, 24);
            this.OperationTypePick_combo.TabIndex = 19;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Location = new System.Drawing.Point(607, 78);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(238, 22);
            this.StartTimePicker.TabIndex = 20;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Location = new System.Drawing.Point(607, 139);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(238, 22);
            this.EndTimePicker.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "End time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Start time";
            // 
            // locationCombo
            // 
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(607, 206);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(238, 24);
            this.locationCombo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Room";
            // 
            // Surgery_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.locationCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.OperationTypePick_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReserveSuregeryButton);
            this.Controls.Add(this.DoctroPick_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientPick_combo);
            this.Name = "Surgery_Res";
            this.Size = new System.Drawing.Size(910, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReserveSuregeryButton;
        private System.Windows.Forms.ComboBox DoctroPick_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientPick_combo;
        private System.Windows.Forms.ComboBox OperationTypePick_combo;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.Label label6;
    }
}
