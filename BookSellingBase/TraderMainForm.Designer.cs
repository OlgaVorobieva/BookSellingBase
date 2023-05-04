namespace BookSellingBase
{
    partial class TraderMainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Catalog = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.traderOrdersDg = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commDg = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.TabPage();
            this.changePWDButton = new System.Windows.Forms.Button();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sended = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Dispute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traderOrdersDg)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commDg)).BeginInit();
            this.Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderCommentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Catalog);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.addButton);
            this.Catalog.Controls.Add(this.dataGridView1);
            this.Catalog.Location = new System.Drawing.Point(4, 25);
            this.Catalog.Name = "Catalog";
            this.Catalog.Padding = new System.Windows.Forms.Padding(3);
            this.Catalog.Size = new System.Drawing.Size(1157, 614);
            this.Catalog.TabIndex = 0;
            this.Catalog.Text = "My Catalog";
            this.Catalog.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(8, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.traderOrdersDg);
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(1157, 614);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // traderOrdersDg
            // 
            this.traderOrdersDg.AllowUserToAddRows = false;
            this.traderOrdersDg.AutoGenerateColumns = false;
            this.traderOrdersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traderOrdersDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.Sended,
            this.Dispute});
            this.traderOrdersDg.DataSource = this.traderOrderBindingSource;
            this.traderOrdersDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traderOrdersDg.Location = new System.Drawing.Point(3, 3);
            this.traderOrdersDg.Name = "traderOrdersDg";
            this.traderOrdersDg.RowHeadersWidth = 51;
            this.traderOrdersDg.RowTemplate.Height = 24;
            this.traderOrdersDg.Size = new System.Drawing.Size(1151, 608);
            this.traderOrdersDg.TabIndex = 0;
            this.traderOrdersDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.traderOrdersDg_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commDg);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 614);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Comments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // commDg
            // 
            this.commDg.AllowUserToAddRows = false;
            this.commDg.AutoGenerateColumns = false;
            this.commDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn1,
            this.ratingValueDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.commDg.DataSource = this.traderCommentBindingSource;
            this.commDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commDg.Location = new System.Drawing.Point(3, 3);
            this.commDg.Name = "commDg";
            this.commDg.RowHeadersWidth = 51;
            this.commDg.RowTemplate.Height = 24;
            this.commDg.Size = new System.Drawing.Size(1151, 608);
            this.commDg.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.changePWDButton);
            this.Profile.Controls.Add(this.changeNameButton);
            this.Profile.Controls.Add(this.nameTb);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Location = new System.Drawing.Point(4, 25);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(1157, 614);
            this.Profile.TabIndex = 2;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // changePWDButton
            // 
            this.changePWDButton.Location = new System.Drawing.Point(32, 120);
            this.changePWDButton.Name = "changePWDButton";
            this.changePWDButton.Size = new System.Drawing.Size(143, 32);
            this.changePWDButton.TabIndex = 7;
            this.changePWDButton.Text = "Change password";
            this.changePWDButton.UseVisualStyleBackColor = true;
            this.changePWDButton.Click += new System.EventHandler(this.changePWDButton_Click);
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(438, 29);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(143, 32);
            this.changeNameButton.TabIndex = 6;
            this.changeNameButton.Text = "Change name";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(129, 34);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(280, 22);
            this.nameTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // Sended
            // 
            this.Sended.DataPropertyName = "ID";
            this.Sended.HeaderText = "Sended";
            this.Sended.MinimumWidth = 6;
            this.Sended.Name = "Sended";
            this.Sended.Text = "Sended";
            this.Sended.UseColumnTextForButtonValue = true;
            this.Sended.Width = 125;
            // 
            // Dispute
            // 
            this.Dispute.DataPropertyName = "ID";
            this.Dispute.HeaderText = "Dispute";
            this.Dispute.MinimumWidth = 6;
            this.Dispute.Name = "Dispute";
            this.Dispute.Text = "Dispute";
            this.Dispute.UseColumnTextForButtonValue = true;
            this.Dispute.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // catalogBookBindingSource
            // 
            this.catalogBookBindingSource.DataSource = typeof(BookSellingBase.Core.CatalogBook);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // traderOrderBindingSource
            // 
            this.traderOrderBindingSource.DataSource = typeof(BookSellingBase.Core.TraderOrder);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ratingValueDataGridViewTextBoxColumn
            // 
            this.ratingValueDataGridViewTextBoxColumn.DataPropertyName = "RatingValue";
            this.ratingValueDataGridViewTextBoxColumn.HeaderText = "RatingValue";
            this.ratingValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingValueDataGridViewTextBoxColumn.Name = "ratingValueDataGridViewTextBoxColumn";
            this.ratingValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // traderCommentBindingSource
            // 
            this.traderCommentBindingSource.DataSource = typeof(BookSellingBase.Core.TraderComment);
            // 
            // TraderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "TraderMainForm";
            this.Text = "TraderMainForm";
            this.tabControl1.ResumeLayout(false);
            this.Catalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traderOrdersDg)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commDg)).EndInit();
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderCommentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Catalog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource catalogBookBindingSource;
        private System.Windows.Forms.DataGridView traderOrdersDg;
        private System.Windows.Forms.BindingSource traderOrderBindingSource;
        private System.Windows.Forms.Button changePWDButton;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView commDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource traderCommentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Sended;
        private System.Windows.Forms.DataGridViewButtonColumn Dispute;
    }
}