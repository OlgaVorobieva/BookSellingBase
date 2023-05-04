namespace BookSellingBase
{
    partial class AddBookForm
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
            this.bookNameCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costTb = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookNameCb
            // 
            this.bookNameCb.FormattingEnabled = true;
            this.bookNameCb.Location = new System.Drawing.Point(22, 62);
            this.bookNameCb.Name = "bookNameCb";
            this.bookNameCb.Size = new System.Drawing.Size(172, 24);
            this.bookNameCb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set count";
            // 
            // countTb
            // 
            this.countTb.Location = new System.Drawing.Point(22, 137);
            this.countTb.Name = "countTb";
            this.countTb.Size = new System.Drawing.Size(100, 22);
            this.countTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set cost";
            // 
            // costTb
            // 
            this.costTb.Location = new System.Drawing.Point(22, 215);
            this.costTb.Name = "costTb";
            this.costTb.Size = new System.Drawing.Size(100, 22);
            this.costTb.TabIndex = 5;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(203, 207);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(93, 39);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Add";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 303);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.costTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookNameCb);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookNameCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.Button AddBookButton;
    }
}