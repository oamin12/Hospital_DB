
namespace DBapplication
{
    partial class look_Up_page
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowPatient = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.LnameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(662, 127);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(238, 52);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowPatient
            // 
            this.ShowPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowPatient.Location = new System.Drawing.Point(120, 235);
            this.ShowPatient.Name = "ShowPatient";
            this.ShowPatient.RowHeadersWidth = 51;
            this.ShowPatient.RowTemplate.Height = 24;
            this.ShowPatient.Size = new System.Drawing.Size(780, 180);
            this.ShowPatient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Pateint\'s name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(232, 116);
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(190, 22);
            this.FnameText.TabIndex = 2;
            // 
            // LnameText
            // 
            this.LnameText.Location = new System.Drawing.Point(232, 175);
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(190, 22);
            this.LnameText.TabIndex = 3;
            // 
            // look_Up_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowPatient);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LnameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "look_Up_page";
            this.Size = new System.Drawing.Size(1055, 467);
            this.Load += new System.EventHandler(this.look_Up_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ShowPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.TextBox LnameText;
    }
}
