
namespace BookSellingBase
{
    partial class AddNewBookForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.categoryTb = new System.Windows.Forms.ComboBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discriptionRTb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.authorClb = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // categoryTb
            // 
            this.categoryTb.FormattingEnabled = true;
            this.categoryTb.Location = new System.Drawing.Point(113, 159);
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(164, 24);
            this.categoryTb.TabIndex = 0;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(116, 38);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(393, 22);
            this.nameTb.TabIndex = 1;
            // 
            // yearTb
            // 
            this.yearTb.Location = new System.Drawing.Point(113, 204);
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(104, 22);
            this.yearTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // discriptionRTb
            // 
            this.discriptionRTb.Location = new System.Drawing.Point(116, 78);
            this.discriptionRTb.Name = "discriptionRTb";
            this.discriptionRTb.Size = new System.Drawing.Size(393, 63);
            this.discriptionRTb.TabIndex = 6;
            this.discriptionRTb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Author";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(388, 497);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 29);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // authorClb
            // 
            this.authorClb.FormattingEnabled = true;
            this.authorClb.Location = new System.Drawing.Point(113, 252);
            this.authorClb.Name = "authorClb";
            this.authorClb.Size = new System.Drawing.Size(186, 225);
            this.authorClb.TabIndex = 14;
            // 
            // AddNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 608);
            this.Controls.Add(this.authorClb);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discriptionRTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.categoryTb);
            this.Name = "AddNewBookForm";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox categoryTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox discriptionRTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox authorClb;
    }
}