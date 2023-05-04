namespace BookSellingBase
{
    partial class CustomerMainForm
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
            this.Profile = new System.Windows.Forms.TabPage();
            this.changePWDButton = new System.Windows.Forms.Button();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.TabPage();
            this.OrderButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostTb = new System.Windows.Forms.TextBox();
            this.Orders = new System.Windows.Forms.TabPage();
            this.MyOrdersDg = new System.Windows.Forms.DataGridView();
            this.Catalog = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookComments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TraderComments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.traderNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Profile.SuspendLayout();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyOrdersDg)).BeginInit();
            this.Catalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.changePWDButton);
            this.Profile.Controls.Add(this.changeNameButton);
            this.Profile.Controls.Add(this.nameTb);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Location = new System.Drawing.Point(4, 25);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(926, 438);
            this.Profile.TabIndex = 3;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // changePWDButton
            // 
            this.changePWDButton.Location = new System.Drawing.Point(75, 123);
            this.changePWDButton.Name = "changePWDButton";
            this.changePWDButton.Size = new System.Drawing.Size(143, 32);
            this.changePWDButton.TabIndex = 3;
            this.changePWDButton.Text = "Change password";
            this.changePWDButton.UseVisualStyleBackColor = true;
            this.changePWDButton.Click += new System.EventHandler(this.changePWDButton_Click);
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(371, 29);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(143, 32);
            this.changeNameButton.TabIndex = 2;
            this.changeNameButton.Text = "Change name";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(172, 37);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(134, 22);
            this.nameTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.OrderButton);
            this.Basket.Controls.Add(this.dataGridView2);
            this.Basket.Controls.Add(this.label1);
            this.Basket.Controls.Add(this.totalCostTb);
            this.Basket.Location = new System.Drawing.Point(4, 25);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(926, 438);
            this.Basket.TabIndex = 2;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(265, 294);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(127, 31);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "Create Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.traderNameDataGridViewTextBoxColumn1,
            this.costDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridView2.DataSource = this.catalogBookBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(916, 247);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Cost:";
            // 
            // totalCostTb
            // 
            this.totalCostTb.Location = new System.Drawing.Point(20, 298);
            this.totalCostTb.Name = "totalCostTb";
            this.totalCostTb.ReadOnly = true;
            this.totalCostTb.Size = new System.Drawing.Size(131, 22);
            this.totalCostTb.TabIndex = 3;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.MyOrdersDg);
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(926, 438);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "My Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // MyOrdersDg
            // 
            this.MyOrdersDg.AllowUserToAddRows = false;
            this.MyOrdersDg.AutoGenerateColumns = false;
            this.MyOrdersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyOrdersDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.traderNameDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.Dispute});
            this.MyOrdersDg.DataSource = this.customerOrderBindingSource;
            this.MyOrdersDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyOrdersDg.Location = new System.Drawing.Point(3, 3);
            this.MyOrdersDg.Name = "MyOrdersDg";
            this.MyOrdersDg.RowHeadersWidth = 51;
            this.MyOrdersDg.RowTemplate.Height = 24;
            this.MyOrdersDg.Size = new System.Drawing.Size(920, 432);
            this.MyOrdersDg.TabIndex = 0;
            this.MyOrdersDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyOrdersDg_CellContentClick);
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.dataGridView1);
            this.Catalog.Location = new System.Drawing.Point(4, 25);
            this.Catalog.Name = "Catalog";
            this.Catalog.Padding = new System.Windows.Forms.Padding(3);
            this.Catalog.Size = new System.Drawing.Size(926, 438);
            this.Catalog.TabIndex = 0;
            this.Catalog.Text = "Catalog";
            this.Catalog.UseVisualStyleBackColor = true;
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
            this.yearDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.traderNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.Add,
            this.BookComments,
            this.TraderComments});
            this.dataGridView1.DataSource = this.catalogBookBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 432);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Catalog);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Controls.Add(this.Basket);
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 467);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 125;
            // 
            // BookComments
            // 
            this.BookComments.HeaderText = "Book Comments";
            this.BookComments.MinimumWidth = 6;
            this.BookComments.Name = "BookComments";
            this.BookComments.Text = "View";
            this.BookComments.UseColumnTextForButtonValue = true;
            this.BookComments.Width = 125;
            // 
            // TraderComments
            // 
            this.TraderComments.HeaderText = "Trader Comments";
            this.TraderComments.MinimumWidth = 6;
            this.TraderComments.Name = "TraderComments";
            this.TraderComments.Text = "View";
            this.TraderComments.UseColumnTextForButtonValue = true;
            this.TraderComments.Width = 125;
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
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // traderNameDataGridViewTextBoxColumn
            // 
            this.traderNameDataGridViewTextBoxColumn.DataPropertyName = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.HeaderText = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traderNameDataGridViewTextBoxColumn.Name = "traderNameDataGridViewTextBoxColumn";
            this.traderNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // catalogBookBindingSource1
            // 
            this.catalogBookBindingSource1.DataSource = typeof(BookSellingBase.Core.CatalogBook);
            // 
            // customerOrderBindingSource
            // 
            this.customerOrderBindingSource.DataSource = typeof(BookSellingBase.Core.CustomerOrder);
            // 
            // catalogBookBindingSource
            // 
            this.catalogBookBindingSource.DataSource = typeof(BookSellingBase.Core.CatalogBook);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // traderNameDataGridViewTextBoxColumn1
            // 
            this.traderNameDataGridViewTextBoxColumn1.DataPropertyName = "TraderName";
            this.traderNameDataGridViewTextBoxColumn1.HeaderText = "TraderName";
            this.traderNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.traderNameDataGridViewTextBoxColumn1.Name = "traderNameDataGridViewTextBoxColumn1";
            this.traderNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.traderNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            this.costDataGridViewTextBoxColumn1.ReadOnly = true;
            this.costDataGridViewTextBoxColumn1.Width = 80;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // traderNameDataGridViewTextBoxColumn2
            // 
            this.traderNameDataGridViewTextBoxColumn2.DataPropertyName = "TraderName";
            this.traderNameDataGridViewTextBoxColumn2.HeaderText = "TraderName";
            this.traderNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.traderNameDataGridViewTextBoxColumn2.Name = "traderNameDataGridViewTextBoxColumn2";
            this.traderNameDataGridViewTextBoxColumn2.Width = 125;
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
            // Dispute
            // 
            this.Dispute.HeaderText = "Dispute";
            this.Dispute.MinimumWidth = 6;
            this.Dispute.Name = "Dispute";
            this.Dispute.Text = "Dispute";
            this.Dispute.UseColumnTextForButtonValue = true;
            this.Dispute.Width = 125;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerMainForm";
            this.Text = "Book Selling Base";
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.Basket.ResumeLayout(false);
            this.Basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyOrdersDg)).EndInit();
            this.Catalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage Basket;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalCostTb;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage Catalog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView MyOrdersDg;
        private System.Windows.Forms.BindingSource customerOrderBindingSource;
        private System.Windows.Forms.Button changePWDButton;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource catalogBookBindingSource;
        private System.Windows.Forms.BindingSource catalogBookBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn BookComments;
        private System.Windows.Forms.DataGridViewButtonColumn TraderComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Dispute;
    }
}