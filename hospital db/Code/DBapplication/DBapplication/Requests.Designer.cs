
namespace DBapplication
{
    partial class Requests
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_scan = new System.Windows.Forms.ComboBox();
            this.ApproveScan = new System.Windows.Forms.Button();
            this.CancelScan = new System.Windows.Forms.Button();
            this.ShowScans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowingRequests = new System.Windows.Forms.DataGridView();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.ApproveRoom = new System.Windows.Forms.Button();
            this.CancelRoom = new System.Windows.Forms.Button();
            this.ShowRoomss = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_operation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ApproveOperation = new System.Windows.Forms.Button();
            this.CancelOperation = new System.Windows.Forms.Button();
            this.ShowOperationss = new System.Windows.Forms.Button();
            this.comboBox_appointment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApproveAppointment = new System.Windows.Forms.Button();
            this.CancelAppointment = new System.Windows.Forms.Button();
            this.ShowAppointmentss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Requests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operations Requests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Requests";
            // 
            // comboBox_scan
            // 
            this.comboBox_scan.FormattingEnabled = true;
            this.comboBox_scan.Location = new System.Drawing.Point(41, 60);
            this.comboBox_scan.Name = "comboBox_scan";
            this.comboBox_scan.Size = new System.Drawing.Size(138, 24);
            this.comboBox_scan.TabIndex = 4;
            this.comboBox_scan.SelectedIndexChanged += new System.EventHandler(this.comboBox_scan_SelectedIndexChanged);
            // 
            // ApproveScan
            // 
            this.ApproveScan.Location = new System.Drawing.Point(239, 57);
            this.ApproveScan.Name = "ApproveScan";
            this.ApproveScan.Size = new System.Drawing.Size(153, 44);
            this.ApproveScan.TabIndex = 5;
            this.ApproveScan.Text = "Approve Request";
            this.ApproveScan.UseVisualStyleBackColor = true;
            this.ApproveScan.Click += new System.EventHandler(this.ApproveScan_Click);
            // 
            // CancelScan
            // 
            this.CancelScan.Location = new System.Drawing.Point(438, 57);
            this.CancelScan.Name = "CancelScan";
            this.CancelScan.Size = new System.Drawing.Size(152, 44);
            this.CancelScan.TabIndex = 6;
            this.CancelScan.Text = "Cancel Request";
            this.CancelScan.UseVisualStyleBackColor = true;
            this.CancelScan.Click += new System.EventHandler(this.CancelScan_Click);
            // 
            // ShowScans
            // 
            this.ShowScans.Location = new System.Drawing.Point(638, 57);
            this.ShowScans.Name = "ShowScans";
            this.ShowScans.Size = new System.Drawing.Size(152, 44);
            this.ShowScans.TabIndex = 7;
            this.ShowScans.Text = "Show Requests";
            this.ShowScans.UseVisualStyleBackColor = true;
            this.ShowScans.Click += new System.EventHandler(this.ShowScans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // ShowingRequests
            // 
            this.ShowingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowingRequests.Location = new System.Drawing.Point(41, 382);
            this.ShowingRequests.Name = "ShowingRequests";
            this.ShowingRequests.RowHeadersWidth = 51;
            this.ShowingRequests.RowTemplate.Height = 26;
            this.ShowingRequests.Size = new System.Drawing.Size(749, 130);
            this.ShowingRequests.TabIndex = 9;
            // 
            // comboBox_room
            // 
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(41, 153);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(138, 24);
            this.comboBox_room.TabIndex = 10;
            // 
            // ApproveRoom
            // 
            this.ApproveRoom.Location = new System.Drawing.Point(240, 142);
            this.ApproveRoom.Name = "ApproveRoom";
            this.ApproveRoom.Size = new System.Drawing.Size(152, 44);
            this.ApproveRoom.TabIndex = 11;
            this.ApproveRoom.Text = "Approve Request";
            this.ApproveRoom.UseVisualStyleBackColor = true;
            this.ApproveRoom.Click += new System.EventHandler(this.ApproveRoom_Click);
            // 
            // CancelRoom
            // 
            this.CancelRoom.Location = new System.Drawing.Point(438, 143);
            this.CancelRoom.Name = "CancelRoom";
            this.CancelRoom.Size = new System.Drawing.Size(152, 43);
            this.CancelRoom.TabIndex = 12;
            this.CancelRoom.Text = "Cancel Request";
            this.CancelRoom.UseVisualStyleBackColor = true;
            this.CancelRoom.Click += new System.EventHandler(this.CancelRoom_Click);
            // 
            // ShowRoomss
            // 
            this.ShowRoomss.Location = new System.Drawing.Point(638, 142);
            this.ShowRoomss.Name = "ShowRoomss";
            this.ShowRoomss.Size = new System.Drawing.Size(152, 44);
            this.ShowRoomss.TabIndex = 13;
            this.ShowRoomss.Text = "Show Requests";
            this.ShowRoomss.UseVisualStyleBackColor = true;
            this.ShowRoomss.Click += new System.EventHandler(this.ShowRoomss_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // comboBox_operation
            // 
            this.comboBox_operation.FormattingEnabled = true;
            this.comboBox_operation.Location = new System.Drawing.Point(41, 247);
            this.comboBox_operation.Name = "comboBox_operation";
            this.comboBox_operation.Size = new System.Drawing.Size(138, 24);
            this.comboBox_operation.TabIndex = 15;
            this.comboBox_operation.SelectedIndexChanged += new System.EventHandler(this.comboBox_operation_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID";
            // 
            // ApproveOperation
            // 
            this.ApproveOperation.Location = new System.Drawing.Point(239, 240);
            this.ApproveOperation.Name = "ApproveOperation";
            this.ApproveOperation.Size = new System.Drawing.Size(151, 43);
            this.ApproveOperation.TabIndex = 17;
            this.ApproveOperation.Text = "Approve Request";
            this.ApproveOperation.UseVisualStyleBackColor = true;
            this.ApproveOperation.Click += new System.EventHandler(this.ApproveOperation_Click);
            // 
            // CancelOperation
            // 
            this.CancelOperation.Location = new System.Drawing.Point(438, 239);
            this.CancelOperation.Name = "CancelOperation";
            this.CancelOperation.Size = new System.Drawing.Size(152, 43);
            this.CancelOperation.TabIndex = 18;
            this.CancelOperation.Text = "Cancel Request";
            this.CancelOperation.UseVisualStyleBackColor = true;
            this.CancelOperation.Click += new System.EventHandler(this.CancelOperation_Click);
            // 
            // ShowOperationss
            // 
            this.ShowOperationss.Location = new System.Drawing.Point(638, 239);
            this.ShowOperationss.Name = "ShowOperationss";
            this.ShowOperationss.Size = new System.Drawing.Size(152, 43);
            this.ShowOperationss.TabIndex = 19;
            this.ShowOperationss.Text = "Show Requests";
            this.ShowOperationss.UseVisualStyleBackColor = true;
            this.ShowOperationss.Click += new System.EventHandler(this.ShowOperationss_Click);
            // 
            // comboBox_appointment
            // 
            this.comboBox_appointment.FormattingEnabled = true;
            this.comboBox_appointment.Location = new System.Drawing.Point(41, 329);
            this.comboBox_appointment.Name = "comboBox_appointment";
            this.comboBox_appointment.Size = new System.Drawing.Size(138, 24);
            this.comboBox_appointment.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            // 
            // ApproveAppointment
            // 
            this.ApproveAppointment.Location = new System.Drawing.Point(240, 321);
            this.ApproveAppointment.Name = "ApproveAppointment";
            this.ApproveAppointment.Size = new System.Drawing.Size(150, 42);
            this.ApproveAppointment.TabIndex = 22;
            this.ApproveAppointment.Text = "Approve Request";
            this.ApproveAppointment.UseVisualStyleBackColor = true;
            this.ApproveAppointment.Click += new System.EventHandler(this.ApproveAppointment_Click);
            // 
            // CancelAppointment
            // 
            this.CancelAppointment.Location = new System.Drawing.Point(438, 321);
            this.CancelAppointment.Name = "CancelAppointment";
            this.CancelAppointment.Size = new System.Drawing.Size(152, 42);
            this.CancelAppointment.TabIndex = 23;
            this.CancelAppointment.Text = "Cancel Request";
            this.CancelAppointment.UseVisualStyleBackColor = true;
            this.CancelAppointment.Click += new System.EventHandler(this.CancelAppointment_Click);
            // 
            // ShowAppointmentss
            // 
            this.ShowAppointmentss.Location = new System.Drawing.Point(638, 321);
            this.ShowAppointmentss.Name = "ShowAppointmentss";
            this.ShowAppointmentss.Size = new System.Drawing.Size(152, 42);
            this.ShowAppointmentss.TabIndex = 24;
            this.ShowAppointmentss.Text = "Show Requests";
            this.ShowAppointmentss.UseVisualStyleBackColor = true;
            this.ShowAppointmentss.Click += new System.EventHandler(this.ShowAppointmentss_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 524);
            this.Controls.Add(this.ShowAppointmentss);
            this.Controls.Add(this.CancelAppointment);
            this.Controls.Add(this.ApproveAppointment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_appointment);
            this.Controls.Add(this.ShowOperationss);
            this.Controls.Add(this.CancelOperation);
            this.Controls.Add(this.ApproveOperation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_operation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowRoomss);
            this.Controls.Add(this.CancelRoom);
            this.Controls.Add(this.ApproveRoom);
            this.Controls.Add(this.comboBox_room);
            this.Controls.Add(this.ShowingRequests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowScans);
            this.Controls.Add(this.CancelScan);
            this.Controls.Add(this.ApproveScan);
            this.Controls.Add(this.comboBox_scan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Requests";
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.ShowingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_scan;
        private System.Windows.Forms.Button ApproveScan;
        private System.Windows.Forms.Button CancelScan;
        private System.Windows.Forms.Button ShowScans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ShowingRequests;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.Button ApproveRoom;
        private System.Windows.Forms.Button CancelRoom;
        private System.Windows.Forms.Button ShowRoomss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_operation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ApproveOperation;
        private System.Windows.Forms.Button CancelOperation;
        private System.Windows.Forms.Button ShowOperationss;
        private System.Windows.Forms.ComboBox comboBox_appointment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ApproveAppointment;
        private System.Windows.Forms.Button CancelAppointment;
        private System.Windows.Forms.Button ShowAppointmentss;
    }
}