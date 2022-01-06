
namespace DBapplication
{
    partial class ROOM_RES
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
            this.Patient_Pick_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomPick_Combobox = new System.Windows.Forms.ComboBox();
            this.Reserve_bed_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Patient_Pick_combobox
            // 
            this.Patient_Pick_combobox.FormattingEnabled = true;
            this.Patient_Pick_combobox.Location = new System.Drawing.Point(415, 90);
            this.Patient_Pick_combobox.Name = "Patient_Pick_combobox";
            this.Patient_Pick_combobox.Size = new System.Drawing.Size(260, 24);
            this.Patient_Pick_combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick Room";
            // 
            // RoomPick_Combobox
            // 
            this.RoomPick_Combobox.FormattingEnabled = true;
            this.RoomPick_Combobox.Location = new System.Drawing.Point(415, 179);
            this.RoomPick_Combobox.Name = "RoomPick_Combobox";
            this.RoomPick_Combobox.Size = new System.Drawing.Size(260, 24);
            this.RoomPick_Combobox.TabIndex = 3;
            // 
            // Reserve_bed_button
            // 
            this.Reserve_bed_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve_bed_button.Location = new System.Drawing.Point(338, 292);
            this.Reserve_bed_button.Name = "Reserve_bed_button";
            this.Reserve_bed_button.Size = new System.Drawing.Size(212, 60);
            this.Reserve_bed_button.TabIndex = 4;
            this.Reserve_bed_button.Text = "Reserve Bed";
            this.Reserve_bed_button.UseVisualStyleBackColor = true;
            this.Reserve_bed_button.Click += new System.EventHandler(this.Reserve_bed_button_Click);
            // 
            // ROOM_RES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Reserve_bed_button);
            this.Controls.Add(this.RoomPick_Combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Patient_Pick_combobox);
            this.Name = "ROOM_RES";
            this.Size = new System.Drawing.Size(910, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Patient_Pick_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RoomPick_Combobox;
        private System.Windows.Forms.Button Reserve_bed_button;
    }
}
