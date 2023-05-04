using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSellingBase.Core;

namespace BookSellingBase
{
    public partial class CustomerMainForm : Form
    {
        User currentUser;
        BookRepository bookRepository;
        OrderRepository orderRepository;
        UserRepository userRepository;
        List<CatalogBook> basketBooks = new List<CatalogBook>();
        BindingList<CatalogBook> basketSource;

        List<CatalogBook> catalogBooks;// = new List<CatalogBook>();
        BindingList<CatalogBook> catalogList;
        BindingSource catalogSource;

        public CustomerMainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            userRepository = new UserRepository();

            bookRepository = new BookRepository();

            catalogBooks = bookRepository.AllBookList();
            catalogList = new BindingList<CatalogBook>(catalogBooks);
            catalogSource = new BindingSource
            {
                DataSource = catalogList
            };
            dataGridView1.DataSource = catalogSource;

            orderRepository = new OrderRepository();
            BindOrdersDg();

            basketSource = new BindingList<CatalogBook>(basketBooks);
            dataGridView2.DataSource = basketSource;

            nameTb.Text = user.Name;
        }

        private void BindOrdersDg()
        {
            var orders = orderRepository.GetAllCustomerOrders(currentUser.ID);
            MyOrdersDg.DataSource = orders;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
            {
                var book = dataGridView1.CurrentRow.DataBoundItem as CatalogBook;
                if (!basketBooks.Any(x => x.TraderBookID == book.TraderBookID))
                {
                    basketBooks.Add(book);
                    basketSource.ResetBindings();
                    OrderButton.Enabled = basketBooks.Any();
                }
                MessageBox.Show("Added");
            }
            else if (e.ColumnIndex == 9)
            {
                if (dataGridView1.CurrentRow.DataBoundItem is CatalogBook book)
                {
                    var bookCommentsForm = new BookCommentsForm(book, currentUser);
                    bookCommentsForm.ShowDialog();
                    ReloadBookCatalog();
                }
            }
            else if (e.ColumnIndex == 10)
            {
                if (dataGridView1.CurrentRow.DataBoundItem is CatalogBook book)
                {
                    var traderCommentsForm = new TraderCommentsForm(book, currentUser);
                    traderCommentsForm.ShowDialog();
                }
            }
        }

        private void ReloadBookCatalog()
        {
            catalogBooks = bookRepository.AllBookList();
            catalogList = new BindingList<CatalogBook>(catalogBooks);

            catalogSource.DataSource = catalogList;
            catalogSource.ResetBindings(false);
        }

        #region profile
        private void changeNameButton_Click(object sender, EventArgs e)
        {
            var newName = nameTb.Text;
            if (newName != currentUser.Name)
            {
                userRepository.ChangeName(currentUser, newName, "Customer");
                MessageBox.Show("Name has been changed");
            }
        }

        private void changePWDButton_Click(object sender, EventArgs e)
        {
            ChangePwdForm changeForm = new ChangePwdForm(currentUser);
            changeForm.ShowDialog();
        }
        #endregion

        #region basket

        private double CalculateBasketTotalSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var book = dataGridView2.Rows[i].DataBoundItem as CatalogBook;
                sum += book.Cost * book.Count;
            }
            return sum;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
                totalCostTb.Text = CalculateBasketTotalSum().ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                var book = dataGridView2.CurrentRow.DataBoundItem as CatalogBook;
                basketBooks.Remove(book);
                basketSource.ResetBindings();
                totalCostTb.Text = CalculateBasketTotalSum().ToString();
                MessageBox.Show("Deleted");
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var isValid = true;
            var newCustomerOrder = new CustomerOrder()
            {
                CustomerID = currentUser.ID,
                TotalCost = CalculateBasketTotalSum(),
                Details = new List<CustomerOrderDetail>()
            };
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                var book = dataGridView2.Rows[i].DataBoundItem as CatalogBook;
                if (book.Count == 0)
                {
                    isValid = false;
                    break;
                }
                var detail = new CustomerOrderDetail()
                {
                    TradBookID = book.TraderBookID,
                    Count = book.Count
                };
                newCustomerOrder.Details.Add(detail);
            }
            if (isValid)
            {
                orderRepository.CreateCustomerOrder(newCustomerOrder);
                MessageBox.Show("Order created successfully");

                basketBooks.Clear();
                basketSource.ResetBindings();
                OrderButton.Enabled = false;
                totalCostTb.Text = CalculateBasketTotalSum().ToString();
            }
            else
            {
                MessageBox.Show("Book count should be greater than 0");
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridView2.CurrentRow.ErrorText = "";

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dataGridView2.CurrentRow.IsNewRow) { return; }

                if (dataGridView2.CurrentRow.DataBoundItem is CatalogBook book)
                {
                    int newCount;
                    if (!int.TryParse(e.FormattedValue.ToString(), out newCount) || newCount < 0 || newCount > book.TraderCount)
                    {
                        e.Cancel = true;
                        dataGridView2.CurrentRow.ErrorText = $"the value must be a Positive integer and no more than {book.TraderCount}";
                    }
                }
            }
        }

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) 
            {
                BindOrdersDg();
            }
        }

        private void MyOrdersDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MyOrdersDg.Columns[e.ColumnIndex].Name == "Dispute" && Convert.ToInt32(MyOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) < 4)
            {
                var order = MyOrdersDg.CurrentRow.DataBoundItem as CustomerOrder;
                if (order.Status != (int)OrderStatus.Discuss)
                {
                    orderRepository.ChangeOrderStatus(order.ID, (int)OrderStatus.Discuss);
                }
                DisputeForm disForm = new DisputeForm(currentUser, order.ID);
                disForm.ShowDialog();
            }
            else if (MyOrdersDg.Columns[e.ColumnIndex].Name == "Dispute" && Convert.ToInt32(MyOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) > 3)
            {
                var type = Convert.ToInt32(MyOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) == 4 ? "Customer" : "Trader";
                MessageBox.Show("Disput has been resolved in favor of the "+ type);
            }
        }
    }
    }