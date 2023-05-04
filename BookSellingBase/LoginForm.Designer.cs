namespace BookSellingBase
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.PwdTb = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(76, 258);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(119, 44);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(73, 78);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(184, 22);
            this.loginTb.TabIndex = 1;
            // 
            // PwdTb
            // 
            this.PwdTb.Location = new System.Drawing.Point(73, 155);
            this.PwdTb.Name = "PwdTb";
            this.PwdTb.Size = new System.Drawing.Size(184, 22);
            this.PwdTb.TabIndex = 2;
            this.PwdTb.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(70, 41);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpass.Location = new System.Drawing.Point(70, 125);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(69, 17);
            this.labelpass.TabIndex = 4;
            this.labelpass.Text = "Password";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 357);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.PwdTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox PwdTb;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelpass;
    }
}

