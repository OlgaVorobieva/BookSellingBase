using System;
using System.Windows.Forms;
using BookSellingBase.Core;

namespace BookSellingBase
{
    public partial class TraderMainForm : Form
    {
        BookRepository bookRepository;
        OrderRepository orderRepository;
        UserRepository userRepository;
        User currentUser;
        public TraderMainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            nameTb.Text = currentUser.Name;
            userRepository = new UserRepository();
            bookRepository = new BookRepository();
            BindCatalog();

            var comms = userRepository.GetTraderComments(currentUser.ID);
            commDg.DataSource = comms;

            orderRepository = new OrderRepository();
            BindTraderOrdersDg();
        }

        private void BindCatalog()
        {
            var books = bookRepository.TraderBookList(currentUser.Name);
            dataGridView1.DataSource = books;
        }

        private void BindTraderOrdersDg()
        {
            var orders = orderRepository.GetAllTraderOrders(currentUser.ID);
            traderOrdersDg.DataSource = orders;
        }

        #region profile
        private void changeNameButton_Click(object sender, EventArgs e)
        {
            var newName = nameTb.Text;
            if (newName != currentUser.Name)
            {
                userRepository.ChangeName(currentUser, newName, "Trader");
                MessageBox.Show("Name has been changed");
            }
        }

        private void changePWDButton_Click(object sender, EventArgs e)
        {
            ChangePwdForm changeForm = new ChangePwdForm(currentUser);
            changeForm.ShowDialog();
        }
        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBookForm addForm = new AddBookForm(currentUser);
            addForm.ShowDialog();
            BindCatalog();
        }

        private void traderOrdersDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (traderOrdersDg.Columns[e.ColumnIndex].Name == "Sended" && traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "1")
            {
                var order = traderOrdersDg.CurrentRow.DataBoundItem as TraderOrder;
                orderRepository.ChangeOrderStatus(order.ID, (int)OrderStatus.Created);
                MessageBox.Show("Sended");

                BindTraderOrdersDg();
            }
            else if (traderOrdersDg.Columns[e.ColumnIndex].Name == "Dispute" && traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "3")
            {
                var order = traderOrdersDg.CurrentRow.DataBoundItem as TraderOrder;
                DisputeForm disForm = new DisputeForm(currentUser, order.ID);
                disForm.ShowDialog();

            }
            else if (traderOrdersDg.Columns[e.ColumnIndex].Name == "Dispute" && Convert.ToInt32(traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) > 3)
            {
                var type = Convert.ToInt32(traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) == 4 ? "Customer" : "Trader";
                MessageBox.Show("Disput has been resolved in favor of the " + type);
            }
            else if (traderOrdersDg.Columns[e.ColumnIndex].Name == "Dispute" && Convert.ToInt32(traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) < 3)
            {
                MessageBox.Show("Disput is not started");
            }
            else if (traderOrdersDg.Columns[e.ColumnIndex].Name == "Sended" && Convert.ToInt32(traderOrdersDg.CurrentRow.Cells["statusDataGridViewTextBoxColumn"].Value) != 1) 
            {
                MessageBox.Show("Order has already been sended");
            }

        }
    }
}
