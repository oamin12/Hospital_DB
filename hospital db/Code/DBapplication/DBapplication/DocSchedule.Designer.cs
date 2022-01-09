namespace DBapplication
{
    partial class DocSchedule
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
            this.schedulegrid = new System.Windows.Forms.DataGridView();
            this.strt_date = new System.Windows.Forms.DateTimePicker();
            this.final_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show_schedule_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.appointments_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedulegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulegrid
            // 
            this.schedulegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulegrid.Location = new System.Drawing.Point(3, 177);
            this.schedulegrid.Name = "schedulegrid";
            this.schedulegrid.RowHeadersWidth = 51;
            this.schedulegrid.RowTemplate.Height = 24;
            this.schedulegrid.Size = new System.Drawing.Size(849, 391);
            this.schedulegrid.TabIndex = 0;
            // 
            // strt_date
            // 
            this.strt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.strt_date.Location = new System.Drawing.Point(568, 14);
            this.strt_date.Name = "strt_date";
            this.strt_date.Size = new System.Drawing.Size(200, 22);
            this.strt_date.TabIndex = 3;
            // 
            // final_date
            // 
            this.final_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.final_date.Location = new System.Drawing.Point(568, 70);
            this.final_date.Name = "final_date";
            this.final_date.Size = new System.Drawing.Size(200, 22);
            this.final_date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date: ";
            // 
            // show_schedule_button
            // 
            this.show_schedule_button.Location = new System.Drawing.Point(526, 126);
            this.show_schedule_button.Name = "show_schedule_button";
            this.show_schedule_button.Size = new System.Drawing.Size(174, 23);
            this.show_schedule_button.TabIndex = 8;
            this.show_schedule_button.Text = "Show Schedule";
            this.show_schedule_button.UseVisualStyleBackColor = true;
            this.show_schedule_button.Click += new System.EventHandler(this.show_schedule_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Postpone";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape2.Location = new System.Drawing.Point(451, 5);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(406, 162);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rectangleShape1.Location = new System.Drawing.Point(6, 5);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(403, 163);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(873, 580);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // appointments_combo
            // 
            this.appointments_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointments_combo.FormattingEnabled = true;
            this.appointments_combo.Location = new System.Drawing.Point(74, 75);
            this.appointments_combo.Name = "appointments_combo";
            this.appointments_combo.Size = new System.Drawing.Size(247, 24);
            this.appointments_combo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(104, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Appointment";
            // 
            // DocSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 580);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_schedule_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.final_date);
            this.Controls.Add(this.strt_date);
            this.Controls.Add(this.appointments_combo);
            this.Controls.Add(this.schedulegrid);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "DocSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.DocSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView schedulegrid;
        private System.Windows.Forms.DateTimePicker strt_date;
        private System.Windows.Forms.DateTimePicker final_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button show_schedule_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox appointments_combo;
        private System.Windows.Forms.Label label3;
    }
}