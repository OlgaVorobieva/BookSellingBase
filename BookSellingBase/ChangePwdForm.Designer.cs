
namespace BookSellingBase
{
    partial class ChangePwdForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.oldPwdTB = new System.Windows.Forms.TextBox();
            this.newPWDTD = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your current password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new password";
            // 
            // oldPwdTB
            // 
            this.oldPwdTB.Location = new System.Drawing.Point(88, 86);
            this.oldPwdTB.Name = "oldPwdTB";
            this.oldPwdTB.Size = new System.Drawing.Size(126, 22);
            this.oldPwdTB.TabIndex = 2;
            // 
            // newPWDTD
            // 
            this.newPWDTD.Location = new System.Drawing.Point(88, 171);
            this.newPWDTD.Name = "newPWDTD";
            this.newPWDTD.Size = new System.Drawing.Size(126, 22);
            this.newPWDTD.TabIndex = 3;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(88, 227);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(116, 41);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Apply";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ChangePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 314);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newPWDTD);
            this.Controls.Add(this.oldPwdTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePwdForm";
            this.Text = "ChangePwdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPwdTB;
        private System.Windows.Forms.TextBox newPWDTD;
        private System.Windows.Forms.Button changeButton;
    }
}