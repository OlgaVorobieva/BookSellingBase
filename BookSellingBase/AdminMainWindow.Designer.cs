
namespace BookSellingBase
{
    partial class AdminMainWindow
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
            this.adminTc = new System.Windows.Forms.TabControl();
            this.comBookTp = new System.Windows.Forms.TabPage();
            this.comDg = new System.Windows.Forms.DataGridView();
            this.bookCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comTraderTp = new System.Windows.Forms.TabPage();
            this.comTrDg = new System.Windows.Forms.DataGridView();
            this.traderCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersTp = new System.Windows.Forms.TabPage();
            this.ordersDg = new System.Windows.Forms.DataGridView();
            this.disputeOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTp = new System.Windows.Forms.TabPage();
            this.addUserButton = new System.Windows.Forms.Button();
            this.UsersDg = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BooksTp = new System.Windows.Forms.TabPage();
            this.addBookButton = new System.Windows.Forms.Button();
            this.BookDg = new System.Windows.Forms.DataGridView();
            this.AuthorTp = new System.Windows.Forms.TabPage();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorDg = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.traderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.traderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adminTc.SuspendLayout();
            this.comBookTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCommentBindingSource)).BeginInit();
            this.comTraderTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comTrDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderCommentBindingSource)).BeginInit();
            this.OrdersTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disputeOrderBindingSource)).BeginInit();
            this.UsersTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.BooksTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDg)).BeginInit();
            this.AuthorTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTc
            // 
            this.adminTc.Controls.Add(this.comBookTp);
            this.adminTc.Controls.Add(this.comTraderTp);
            this.adminTc.Controls.Add(this.OrdersTp);
            this.adminTc.Controls.Add(this.UsersTp);
            this.adminTc.Controls.Add(this.BooksTp);
            this.adminTc.Controls.Add(this.AuthorTp);
            this.adminTc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.adminTc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTc.Location = new System.Drawing.Point(0, 0);
            this.adminTc.Name = "adminTc";
            this.adminTc.SelectedIndex = 0;
            this.adminTc.Size = new System.Drawing.Size(1000, 520);
            this.adminTc.TabIndex = 0;
            // 
            // comBookTp
            // 
            this.comBookTp.Controls.Add(this.comDg);
            this.comBookTp.Location = new System.Drawing.Point(4, 25);
            this.comBookTp.Name = "comBookTp";
            this.comBookTp.Padding = new System.Windows.Forms.Padding(3);
            this.comBookTp.Size = new System.Drawing.Size(993, 492);
            this.comBookTp.TabIndex = 0;
            this.comBookTp.Text = "Book Comments";
            this.comBookTp.UseVisualStyleBackColor = true;
            // 
            // comDg
            // 
            this.comDg.AllowUserToAddRows = false;
            this.comDg.AutoGenerateColumns = false;
            this.comDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn1,
            this.ratingValueDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.Delete});
            this.comDg.DataSource = this.bookCommentBindingSource;
            this.comDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comDg.Location = new System.Drawing.Point(3, 3);
            this.comDg.Name = "comDg";
            this.comDg.RowHeadersWidth = 51;
            this.comDg.RowTemplate.Height = 24;
            this.comDg.Size = new System.Drawing.Size(987, 486);
            this.comDg.TabIndex = 0;
            this.comDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comDg_CellContentClick);
            // 
            // bookCommentBindingSource
            // 
            this.bookCommentBindingSource.DataSource = typeof(BookSellingBase.Core.BookComment);
            // 
            // comTraderTp
            // 
            this.comTraderTp.Controls.Add(this.comTrDg);
            this.comTraderTp.Location = new System.Drawing.Point(4, 25);
            this.comTraderTp.Name = "comTraderTp";
            this.comTraderTp.Size = new System.Drawing.Size(993, 492);
            this.comTraderTp.TabIndex = 5;
            this.comTraderTp.Text = "Trader Comments";
            this.comTraderTp.UseVisualStyleBackColor = true;
            // 
            // comTrDg
            // 
            this.comTrDg.AllowUserToAddRows = false;
            this.comTrDg.AutoGenerateColumns = false;
            this.comTrDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comTrDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.traderIDDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn2,
            this.ratingValueDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn2,
            this.DeleteCom});
            this.comTrDg.DataSource = this.traderCommentBindingSource;
            this.comTrDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comTrDg.Location = new System.Drawing.Point(0, 0);
            this.comTrDg.Name = "comTrDg";
            this.comTrDg.RowHeadersWidth = 51;
            this.comTrDg.RowTemplate.Height = 24;
            this.comTrDg.Size = new System.Drawing.Size(993, 492);
            this.comTrDg.TabIndex = 0;
            this.comTrDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comTrDg_CellContentClick);
            // 
            // traderCommentBindingSource
            // 
            this.traderCommentBindingSource.DataSource = typeof(BookSellingBase.Core.TraderComment);
            // 
            // OrdersTp
            // 
            this.OrdersTp.Controls.Add(this.ordersDg);
            this.OrdersTp.Location = new System.Drawing.Point(4, 25);
            this.OrdersTp.Name = "OrdersTp";
            this.OrdersTp.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTp.Size = new System.Drawing.Size(993, 492);
            this.OrdersTp.TabIndex = 1;
            this.OrdersTp.Text = "Orders";
            this.OrdersTp.UseVisualStyleBackColor = true;
            // 
            // ordersDg
            // 
            this.ordersDg.AllowUserToAddRows = false;
            this.ordersDg.AutoGenerateColumns = false;
            this.ordersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.traderNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.Dispute});
            this.ordersDg.DataSource = this.disputeOrderBindingSource;
            this.ordersDg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDg.Location = new System.Drawing.Point(3, 3);
            this.ordersDg.Name = "ordersDg";
            this.ordersDg.RowHeadersWidth = 51;
            this.ordersDg.RowTemplate.Height = 24;
            this.ordersDg.Size = new System.Drawing.Size(987, 486);
            this.ordersDg.TabIndex = 0;
            this.ordersDg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDg_CellContentClick);
            // 
            // disputeOrderBindingSource
            // 
            this.disputeOrderBindingSource.DataSource = typeof(BookSellingBase.Core.DisputeOrder);
            // 
            // UsersTp
            // 
            this.UsersTp.Controls.Add(this.addUserButton);
            this.UsersTp.Controls.Add(this.UsersDg);
            this.UsersTp.Location = new System.Drawing.Point(4, 25);
            this.UsersTp.Name = "UsersTp";
            this.UsersTp.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTp.Size = new System.Drawing.Size(993, 492);
            this.UsersTp.TabIndex = 2;
            this.UsersTp.Text = "Users";
            this.UsersTp.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(750, 375);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(95, 35);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // UsersDg
            // 
            this.UsersDg.AllowUserToAddRows = false;
            this.UsersDg.AutoGenerateColumns = false;
            this.UsersDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.UsersDg.DataSource = this.userBindingSource;
            this.UsersDg.Location = new System.Drawing.Point(6, 6);
            this.UsersDg.Name = "UsersDg";
            this.UsersDg.ReadOnly = true;
            this.UsersDg.RowHeadersWidth = 51;
            this.UsersDg.RowTemplate.Height = 24;
            this.UsersDg.Size = new System.Drawing.Size(979, 351);
            this.UsersDg.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookSellingBase.Core.User);
            // 
            // BooksTp
            // 
            this.BooksTp.Controls.Add(this.addBookButton);
            this.BooksTp.Controls.Add(this.BookDg);
            this.BooksTp.Location = new System.Drawing.Point(4, 25);
            this.BooksTp.Name = "BooksTp";
            this.BooksTp.Padding = new System.Windows.Forms.Padding(3);
            this.BooksTp.Size = new System.Drawing.Size(992, 491);
            this.BooksTp.TabIndex = 3;
            this.BooksTp.Text = "Books";
            this.BooksTp.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(647, 355);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(91, 36);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // BookDg
            // 
            this.BookDg.AllowUserToAddRows = false;
            this.BookDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDg.Location = new System.Drawing.Point(6, 6);
            this.BookDg.Name = "BookDg";
            this.BookDg.ReadOnly = true;
            this.BookDg.RowHeadersWidth = 51;
            this.BookDg.RowTemplate.Height = 24;
            this.BookDg.Size = new System.Drawing.Size(979, 333);
            this.BookDg.TabIndex = 0;
            // 
            // AuthorTp
            // 
            this.AuthorTp.Controls.Add(this.addAuthorButton);
            this.AuthorTp.Controls.Add(this.authorDg);
            this.AuthorTp.Location = new System.Drawing.Point(4, 25);
            this.AuthorTp.Name = "AuthorTp";
            this.AuthorTp.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTp.Size = new System.Drawing.Size(993, 492);
            this.AuthorTp.TabIndex = 4;
            this.AuthorTp.Text = "Authors";
            this.AuthorTp.UseVisualStyleBackColor = true;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(648, 336);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(117, 32);
            this.addAuthorButton.TabIndex = 1;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // authorDg
            // 
            this.authorDg.AllowUserToAddRows = false;
            this.authorDg.AutoGenerateColumns = false;
            this.authorDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.authorDg.DataSource = this.authorBindingSource;
            this.authorDg.Location = new System.Drawing.Point(12, 3);
            this.authorDg.Name = "authorDg";
            this.authorDg.ReadOnly = true;
            this.authorDg.RowHeadersWidth = 51;
            this.authorDg.RowTemplate.Height = 24;
            this.authorDg.Size = new System.Drawing.Size(960, 303);
            this.authorDg.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Width = 125;
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
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(BookSellingBase.Core.Author);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.Width = 125;
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
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // traderIDDataGridViewTextBoxColumn
            // 
            this.traderIDDataGridViewTextBoxColumn.DataPropertyName = "TraderID";
            this.traderIDDataGridViewTextBoxColumn.HeaderText = "TraderID";
            this.traderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traderIDDataGridViewTextBoxColumn.Name = "traderIDDataGridViewTextBoxColumn";
            this.traderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // textDataGridViewTextBoxColumn1
            // 
            this.textDataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn1.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn1.Name = "textDataGridViewTextBoxColumn1";
            this.textDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn2
            // 
            this.customerNameDataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn2.Name = "customerNameDataGridViewTextBoxColumn2";
            this.customerNameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ratingValueDataGridViewTextBoxColumn1
            // 
            this.ratingValueDataGridViewTextBoxColumn1.DataPropertyName = "RatingValue";
            this.ratingValueDataGridViewTextBoxColumn1.HeaderText = "RatingValue";
            this.ratingValueDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ratingValueDataGridViewTextBoxColumn1.Name = "ratingValueDataGridViewTextBoxColumn1";
            this.ratingValueDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.Width = 125;
            // 
            // DeleteCom
            // 
            this.DeleteCom.HeaderText = "DeleteCom";
            this.DeleteCom.MinimumWidth = 6;
            this.DeleteCom.Name = "DeleteCom";
            this.DeleteCom.Text = "Delete";
            this.DeleteCom.UseColumnTextForButtonValue = true;
            this.DeleteCom.Width = 125;
            // 
            // traderNameDataGridViewTextBoxColumn
            // 
            this.traderNameDataGridViewTextBoxColumn.DataPropertyName = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.HeaderText = "TraderName";
            this.traderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traderNameDataGridViewTextBoxColumn.Name = "traderNameDataGridViewTextBoxColumn";
            this.traderNameDataGridViewTextBoxColumn.Width = 125;
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
            // Dispute
            // 
            this.Dispute.HeaderText = "Solve Dispute";
            this.Dispute.MinimumWidth = 6;
            this.Dispute.Name = "Dispute";
            this.Dispute.Text = "Solve";
            this.Dispute.UseColumnTextForButtonValue = true;
            this.Dispute.Width = 125;
            // 
            // AdminMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.adminTc);
            this.Name = "AdminMainWindow";
            this.Text = "AdminMainWindow";
            this.adminTc.ResumeLayout(false);
            this.comBookTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCommentBindingSource)).EndInit();
            this.comTraderTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comTrDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderCommentBindingSource)).EndInit();
            this.OrdersTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disputeOrderBindingSource)).EndInit();
            this.UsersTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.BooksTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookDg)).EndInit();
            this.AuthorTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTc;
        private System.Windows.Forms.TabPage comBookTp;
        private System.Windows.Forms.TabPage OrdersTp;
        private System.Windows.Forms.TabPage UsersTp;
        private System.Windows.Forms.TabPage BooksTp;
        private System.Windows.Forms.DataGridView comDg;
        private System.Windows.Forms.DataGridView ordersDg;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView UsersDg;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.DataGridView BookDg;
        private System.Windows.Forms.TabPage AuthorTp;
        private System.Windows.Forms.DataGridView authorDg;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource disputeOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.TabPage comTraderTp;
        private System.Windows.Forms.BindingSource bookCommentBindingSource;
        private System.Windows.Forms.DataGridView comTrDg;
        private System.Windows.Forms.BindingSource traderCommentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Dispute;
    }
}