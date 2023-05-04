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
    public partial class DisputeForm : Form
    {
        User currentUser;
        int currentOrderID;
        OrderRepository orderRepository;
        public DisputeForm(User user, int orderID)
        {
            InitializeComponent();
            currentUser = user;
            currentOrderID = orderID;

            orderRepository = new OrderRepository();
            BindComments();
            bookNamelbl.Text = "Открыт";

            if (currentUser.UserType == "Admin")
            {
                commentTextBox.Visible = false;
                commentLbl.Visible = false;
                AddButton.Visible = false;
            }
            else 
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                submitButton.Visible = false;
            }
        }

        private void BindComments()
        {
            var comments = orderRepository.GetOrderDisputeComments(currentOrderID);
            dataGridView1.DataSource = comments;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                var newComment = new DisputeComment
                {
                    Text = commentTextBox.Text,
                    OrderID = currentOrderID,
                    UserID = currentUser.UserID,
                    Date = DateTime.Now
                };
                orderRepository.AddDisputeComment(newComment);

                commentTextBox.Text = string.Empty;

                BindComments();
            }
        }

        private bool ValidateText()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(commentTextBox.Text))
            {
                errorProvider1.SetError(commentTextBox, "Please enter text");
                bStatus = false;
            }
            else
                errorProvider1.SetError(commentTextBox, "");
            return bStatus;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int newStatus = radioButton1.Checked ? (int)OrderStatus.CustomerRight : (int)OrderStatus.TraderRight;
            orderRepository.ChangeOrderStatus(currentOrderID, newStatus);
            MessageBox.Show("Decision has been made");
            DialogResult = DialogResult.OK;
        }
    }
}
