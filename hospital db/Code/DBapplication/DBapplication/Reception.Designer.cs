
namespace DBapplication
{
    partial class Reception
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.newPatientBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.LookUpBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(0, 127);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1055, 467);
            this.main_panel.TabIndex = 1;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // newPatientBtn
            // 
            this.newPatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newPatientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPatientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.newPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPatientBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientBtn.Location = new System.Drawing.Point(352, 0);
            this.newPatientBtn.Name = "newPatientBtn";
            this.newPatientBtn.Size = new System.Drawing.Size(351, 53);
            this.newPatientBtn.TabIndex = 0;
            this.newPatientBtn.Text = "New Patient";
            this.newPatientBtn.UseVisualStyleBackColor = true;
            this.newPatientBtn.Click += new System.EventHandler(this.newPatientBtn_Click);
            // 
            // ReservationsBtn
            // 
            this.ReservationsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReservationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReservationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ReservationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsBtn.Location = new System.Drawing.Point(0, 0);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(351, 53);
            this.ReservationsBtn.TabIndex = 1;
            this.ReservationsBtn.Text = "Reservations";
            this.ReservationsBtn.UseVisualStyleBackColor = true;
            this.ReservationsBtn.Click += new System.EventHandler(this.ReservationsBtn_Click);
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LookUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LookUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LookUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LookUpBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpBtn.Location = new System.Drawing.Point(704, 0);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(351, 53);
            this.LookUpBtn.TabIndex = 2;
            this.LookUpBtn.Text = "look up patient";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LookUpBtn);
            this.panel1.Controls.Add(this.ReservationsBtn);
            this.panel1.Controls.Add(this.newPatientBtn);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reception";
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Reception";
            this.Text = "Reception";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button newPatientBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.Button LookUpBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}