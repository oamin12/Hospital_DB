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
            this.ReqBtn = new System.Windows.Forms.Button();
            this.MoneyBtn = new System.Windows.Forms.Button();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Affairs";
            // 
            // ReqBtn
            // 
            this.ReqBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqBtn.Location = new System.Drawing.Point(91, 157);
            this.ReqBtn.Name = "ReqBtn";
            this.ReqBtn.Size = new System.Drawing.Size(280, 94);
            this.ReqBtn.TabIndex = 1;
            this.ReqBtn.Text = "Requests";
            this.ReqBtn.UseVisualStyleBackColor = true;
            this.ReqBtn.Click += new System.EventHandler(this.ReqBtn_Click);
            // 
            // MoneyBtn
            // 
            this.MoneyBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBtn.Location = new System.Drawing.Point(377, 157);
            this.MoneyBtn.Name = "MoneyBtn";
            this.MoneyBtn.Size = new System.Drawing.Size(280, 94);
            this.MoneyBtn.TabIndex = 2;
            this.MoneyBtn.Text = "Add/Withdraw Money ";
            this.MoneyBtn.UseVisualStyleBackColor = true;
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBtn.Location = new System.Drawing.Point(91, 257);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(280, 94);
            this.SalaryBtn.TabIndex = 3;
            this.SalaryBtn.Text = "Edit Salaries";
            this.SalaryBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(377, 257);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(280, 94);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search for a Staff Member";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 477);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SalaryBtn);
            this.Controls.Add(this.MoneyBtn);
            this.Controls.Add(this.ReqBtn);
            this.Controls.Add(this.label1);
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReqBtn;
        private System.Windows.Forms.Button MoneyBtn;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button SearchBtn;
    }
}