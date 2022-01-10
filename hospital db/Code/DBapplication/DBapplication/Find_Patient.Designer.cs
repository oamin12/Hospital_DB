namespace DBapplication
{
    partial class Find_pat
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
            this.Patient_ID_Data = new System.Windows.Forms.DataGridView();
            this.GetId_btn = new System.Windows.Forms.Button();
            this.Name_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_ID_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Patient_ID_Data
            // 
            this.Patient_ID_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patient_ID_Data.Location = new System.Drawing.Point(12, 97);
            this.Patient_ID_Data.Name = "Patient_ID_Data";
            this.Patient_ID_Data.RowHeadersWidth = 51;
            this.Patient_ID_Data.RowTemplate.Height = 24;
            this.Patient_ID_Data.Size = new System.Drawing.Size(776, 438);
            this.Patient_ID_Data.TabIndex = 0;
            // 
            // GetId_btn
            // 
            this.GetId_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetId_btn.Location = new System.Drawing.Point(563, 30);
            this.GetId_btn.Name = "GetId_btn";
            this.GetId_btn.Size = new System.Drawing.Size(126, 39);
            this.GetId_btn.TabIndex = 1;
            this.GetId_btn.Text = "Get ID";
            this.GetId_btn.UseVisualStyleBackColor = true;
            this.GetId_btn.Click += new System.EventHandler(this.GetId_btn_Click);
            // 
            // Name_Combo
            // 
            this.Name_Combo.FormattingEnabled = true;
            this.Name_Combo.Location = new System.Drawing.Point(325, 35);
            this.Name_Combo.Name = "Name_Combo";
            this.Name_Combo.Size = new System.Drawing.Size(197, 24);
            this.Name_Combo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(217, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // Find_pat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Combo);
            this.Controls.Add(this.GetId_btn);
            this.Controls.Add(this.Patient_ID_Data);
            this.Name = "Find_pat";
            this.Text = "Search My Patients";
            this.Load += new System.EventHandler(this.Find_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patient_ID_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Patient_ID_Data;
        private System.Windows.Forms.Button GetId_btn;
        private System.Windows.Forms.ComboBox Name_Combo;
        private System.Windows.Forms.Label label1;
    }
}