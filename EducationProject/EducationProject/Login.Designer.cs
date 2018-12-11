namespace EducationProject
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginSurname = new System.Windows.Forms.TextBox();
            this.txtBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLoginName = new System.Windows.Forms.TextBox();
            this.cbxLoginUserType = new System.Windows.Forms.ComboBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtBoxLoginSurname);
            this.groupBox1.Controls.Add(this.txtBoxLoginEmail);
            this.groupBox1.Controls.Add(this.txtBoxLoginName);
            this.groupBox1.Controls.Add(this.cbxLoginUserType);
            this.groupBox1.Controls.Add(this.labelUserType);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(54, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoginBox";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(151, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtBoxLoginSurname
            // 
            this.txtBoxLoginSurname.Location = new System.Drawing.Point(151, 83);
            this.txtBoxLoginSurname.Name = "txtBoxLoginSurname";
            this.txtBoxLoginSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoginSurname.TabIndex = 7;
            // 
            // txtBoxLoginEmail
            // 
            this.txtBoxLoginEmail.Location = new System.Drawing.Point(151, 129);
            this.txtBoxLoginEmail.Name = "txtBoxLoginEmail";
            this.txtBoxLoginEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoginEmail.TabIndex = 6;
            // 
            // txtBoxLoginName
            // 
            this.txtBoxLoginName.Location = new System.Drawing.Point(151, 39);
            this.txtBoxLoginName.Name = "txtBoxLoginName";
            this.txtBoxLoginName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoginName.TabIndex = 5;
            // 
            // cbxLoginUserType
            // 
            this.cbxLoginUserType.FormattingEnabled = true;
            this.cbxLoginUserType.Location = new System.Drawing.Point(151, 181);
            this.cbxLoginUserType.Name = "cbxLoginUserType";
            this.cbxLoginUserType.Size = new System.Drawing.Size(121, 21);
            this.cbxLoginUserType.TabIndex = 4;
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Location = new System.Drawing.Point(20, 184);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(56, 13);
            this.labelUserType.TabIndex = 3;
            this.labelUserType.Text = "UserType:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 136);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(20, 86);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxLoginSurname;
        private System.Windows.Forms.TextBox txtBoxLoginEmail;
        private System.Windows.Forms.TextBox txtBoxLoginName;
        private System.Windows.Forms.ComboBox cbxLoginUserType;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
    }
}