
namespace DBapplication
{
    partial class Search_Staff
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
            this.comboBox_srcName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_src = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_src)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By FName";
            // 
            // comboBox_srcName
            // 
            this.comboBox_srcName.FormattingEnabled = true;
            this.comboBox_srcName.Location = new System.Drawing.Point(201, 103);
            this.comboBox_srcName.Name = "comboBox_srcName";
            this.comboBox_srcName.Size = new System.Drawing.Size(159, 24);
            this.comboBox_srcName.TabIndex = 1;
            this.comboBox_srcName.SelectedIndexChanged += new System.EventHandler(this.comboBox_srcName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_src
            // 
            this.dataGridView_src.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_src.Location = new System.Drawing.Point(12, 270);
            this.dataGridView_src.Name = "dataGridView_src";
            this.dataGridView_src.RowHeadersWidth = 51;
            this.dataGridView_src.RowTemplate.Height = 26;
            this.dataGridView_src.Size = new System.Drawing.Size(723, 156);
            this.dataGridView_src.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // Search_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_src);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_srcName);
            this.Controls.Add(this.label1);
            this.Name = "Search_Staff";
            this.Text = "Search Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_src)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_srcName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_src;
        private System.Windows.Forms.Label label2;
    }
}