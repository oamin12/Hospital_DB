
namespace DBapplication
{
    partial class Reservations_page
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
            this.ChooseResTypePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FollowUpsButton = new System.Windows.Forms.Button();
            this.CheckUpsButton = new System.Windows.Forms.Button();
            this.SurgeriesButton = new System.Windows.Forms.Button();
            this.ScansButton = new System.Windows.Forms.Button();
            this.BedsButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseResTypePanel
            // 
            this.ChooseResTypePanel.Location = new System.Drawing.Point(145, 54);
            this.ChooseResTypePanel.Name = "ChooseResTypePanel";
            this.ChooseResTypePanel.Size = new System.Drawing.Size(910, 413);
            this.ChooseResTypePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 54);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BedsButton);
            this.panel3.Controls.Add(this.ScansButton);
            this.panel3.Controls.Add(this.SurgeriesButton);
            this.panel3.Controls.Add(this.CheckUpsButton);
            this.panel3.Controls.Add(this.FollowUpsButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 413);
            this.panel3.TabIndex = 3;
            // 
            // FollowUpsButton
            // 
            this.FollowUpsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FollowUpsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.FollowUpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FollowUpsButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowUpsButton.Location = new System.Drawing.Point(0, 311);
            this.FollowUpsButton.Name = "FollowUpsButton";
            this.FollowUpsButton.Size = new System.Drawing.Size(139, 66);
            this.FollowUpsButton.TabIndex = 0;
            this.FollowUpsButton.Text = "Follow Ups";
            this.FollowUpsButton.UseVisualStyleBackColor = false;
           // this.FollowUpsButton.Click += new System.EventHandler(this.FollowUpsButton_Click);
            // 
            // CheckUpsButton
            // 
            this.CheckUpsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CheckUpsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.CheckUpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckUpsButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUpsButton.Location = new System.Drawing.Point(0, 239);
            this.CheckUpsButton.Name = "CheckUpsButton";
            this.CheckUpsButton.Size = new System.Drawing.Size(139, 66);
            this.CheckUpsButton.TabIndex = 1;
            this.CheckUpsButton.Text = "Check Ups";
            this.CheckUpsButton.UseVisualStyleBackColor = false;
           // this.CheckUpsButton.Click += new System.EventHandler(this.CheckUpsButton_Click);
            // 
            // SurgeriesButton
            // 
            this.SurgeriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SurgeriesButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.SurgeriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SurgeriesButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurgeriesButton.Location = new System.Drawing.Point(0, 167);
            this.SurgeriesButton.Name = "SurgeriesButton";
            this.SurgeriesButton.Size = new System.Drawing.Size(139, 66);
            this.SurgeriesButton.TabIndex = 2;
            this.SurgeriesButton.Text = "Surgeries";
            this.SurgeriesButton.UseVisualStyleBackColor = false;
            this.SurgeriesButton.Click += new System.EventHandler(this.SurgeriesButton_Click);
            // 
            // ScansButton
            // 
            this.ScansButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScansButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.ScansButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScansButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScansButton.Location = new System.Drawing.Point(0, 95);
            this.ScansButton.Name = "ScansButton";
            this.ScansButton.Size = new System.Drawing.Size(139, 66);
            this.ScansButton.TabIndex = 3;
            this.ScansButton.Text = "Scans";
            this.ScansButton.UseVisualStyleBackColor = false;
            this.ScansButton.Click += new System.EventHandler(this.ScansButton_Click);
            // 
            // BedsButton
            // 
            this.BedsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BedsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BedsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BedsButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedsButton.Location = new System.Drawing.Point(0, 23);
            this.BedsButton.Name = "BedsButton";
            this.BedsButton.Size = new System.Drawing.Size(139, 66);
            this.BedsButton.TabIndex = 4;
            this.BedsButton.Text = "Beds";
            this.BedsButton.UseVisualStyleBackColor = false;
            this.BedsButton.Click += new System.EventHandler(this.BedsButton_Click);
            // 
            // Reservations_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChooseResTypePanel);
            this.Name = "Reservations_page";
            this.Size = new System.Drawing.Size(1055, 467);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ChooseResTypePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BedsButton;
        private System.Windows.Forms.Button ScansButton;
        private System.Windows.Forms.Button SurgeriesButton;
        private System.Windows.Forms.Button CheckUpsButton;
        private System.Windows.Forms.Button FollowUpsButton;
    }
}
