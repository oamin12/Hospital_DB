
namespace DBapplication
{
    partial class Accounting
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
            this.RequestsBtn = new System.Windows.Forms.Button();
            this.MoneyBtn = new System.Windows.Forms.Button();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Affairs";
            // 
            // RequestsBtn
            // 
            this.RequestsBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsBtn.Location = new System.Drawing.Point(166, 128);
            this.RequestsBtn.Name = "RequestsBtn";
            this.RequestsBtn.Size = new System.Drawing.Size(245, 85);
            this.RequestsBtn.TabIndex = 1;
            this.RequestsBtn.Text = "Requests";
            this.RequestsBtn.UseVisualStyleBackColor = true;
            this.RequestsBtn.Click += new System.EventHandler(this.RequestsBtn_Click);
            // 
            // MoneyBtn
            // 
            this.MoneyBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBtn.Location = new System.Drawing.Point(417, 128);
            this.MoneyBtn.Name = "MoneyBtn";
            this.MoneyBtn.Size = new System.Drawing.Size(245, 85);
            this.MoneyBtn.TabIndex = 2;
            this.MoneyBtn.Text = "Transactions";
            this.MoneyBtn.UseVisualStyleBackColor = true;
            this.MoneyBtn.Click += new System.EventHandler(this.MoneyBtn_Click);
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBtn.Location = new System.Drawing.Point(166, 219);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(245, 84);
            this.SalaryBtn.TabIndex = 3;
            this.SalaryBtn.Text = "Edit Salaries";
            this.SalaryBtn.UseVisualStyleBackColor = true;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(417, 219);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(245, 84);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search for a Staff Member";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 467);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SalaryBtn);
            this.Controls.Add(this.MoneyBtn);
            this.Controls.Add(this.RequestsBtn);
            this.Controls.Add(this.label1);
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RequestsBtn;
        private System.Windows.Forms.Button MoneyBtn;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}