
namespace DBapplication
{
    partial class Add_a_User
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
            this.txtbox_UserName = new System.Windows.Forms.TextBox();
            this.txtbox_Pass = new System.Windows.Forms.TextBox();
            this.cmbo_usertype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbo_ID = new System.Windows.Forms.ComboBox();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add a User";
            // 
            // txtbox_UserName
            // 
            this.txtbox_UserName.Location = new System.Drawing.Point(18, 237);
            this.txtbox_UserName.Name = "txtbox_UserName";
            this.txtbox_UserName.Size = new System.Drawing.Size(148, 22);
            this.txtbox_UserName.TabIndex = 12;
            // 
            // txtbox_Pass
            // 
            this.txtbox_Pass.Location = new System.Drawing.Point(18, 299);
            this.txtbox_Pass.Name = "txtbox_Pass";
            this.txtbox_Pass.Size = new System.Drawing.Size(148, 22);
            this.txtbox_Pass.TabIndex = 13;
            // 
            // cmbo_usertype
            // 
            this.cmbo_usertype.FormattingEnabled = true;
            this.cmbo_usertype.Location = new System.Drawing.Point(19, 124);
            this.cmbo_usertype.Name = "cmbo_usertype";
            this.cmbo_usertype.Size = new System.Drawing.Size(149, 24);
            this.cmbo_usertype.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // cmbo_ID
            // 
            this.cmbo_ID.FormattingEnabled = true;
            this.cmbo_ID.Location = new System.Drawing.Point(18, 190);
            this.cmbo_ID.Name = "cmbo_ID";
            this.cmbo_ID.Size = new System.Drawing.Size(149, 24);
            this.cmbo_ID.TabIndex = 19;
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Location = new System.Drawing.Point(18, 352);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(150, 45);
            this.btn_Add_User.TabIndex = 20;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // Add_a_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add_User);
            this.Controls.Add(this.cmbo_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_usertype);
            this.Controls.Add(this.txtbox_Pass);
            this.Controls.Add(this.txtbox_UserName);
            this.Controls.Add(this.label1);
            this.Name = "Add_a_User";
            this.Text = "Add_a_User";
            this.Load += new System.EventHandler(this.Add_a_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_UserName;
        private System.Windows.Forms.TextBox txtbox_Pass;
        private System.Windows.Forms.ComboBox cmbo_usertype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbo_ID;
        private System.Windows.Forms.Button btn_Add_User;
    }
}