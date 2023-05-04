using BookSellingBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSellingBase
{
    public partial class TraderCommentsForm : Form
    {
        CatalogBook currentCatalogBook;
        User currentUser;

        UserRepository userRepository;
        List<TraderComment> traderComments;
        BindingList<TraderComment> commentList;
        BindingSource commentsSource;

        public TraderCommentsForm(CatalogBook catalogBook, User user)
        {
            InitializeComponent();

            currentCatalogBook = catalogBook;
            currentUser = user;

            userRepository = new UserRepository();

            traderComments = userRepository.GetTraderComments(currentCatalogBook.TraderID);
            commentList = new BindingList<TraderComment>(traderComments);
            commentsSource = new BindingSource();
            commentsSource.DataSource = commentList;
            dataGridView1.DataSource = commentsSource;

            bookNamelbl.Text = currentCatalogBook.TraderName;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateText() && ValidateRaiting())
            {

            var newComment = new TraderComment
            {
                Text = commentTextBox.Text,
                TraderID = currentCatalogBook.TraderID,
                RatingValue = Convert.ToSingle(raitingTextBox.Text),
                CustomerID = currentUser.ID,
                Date = DateTime.Now
            };
            userRepository.CreateTraderComment(newComment);

            commentTextBox.Text = string.Empty;
            raitingTextBox.Text = string.Empty;

            traderComments = userRepository.GetTraderComments(currentCatalogBook.TraderID);
            commentList = new BindingList<TraderComment>(traderComments);

            commentsSource.DataSource = commentList;
            commentsSource.ResetBindings(false);
            }
        }

        private void commentTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateText();
        }
        private void raitingTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRaiting();
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

        private bool ValidateRaiting()
        {
            bool bStatus = true;
            if (string.IsNullOrWhiteSpace(raitingTextBox.Text))
            {
                errorProvider1.SetError(raitingTextBox, "Please enter Raiting");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(raitingTextBox, "");

                bStatus = float.TryParse(raitingTextBox.Text, out float raitingValue);
                if (bStatus)
                {
                    errorProvider1.SetError(raitingTextBox, "");
                }
                else
                {
                    errorProvider1.SetError(raitingTextBox, "Raiting is not a correct number");
                }
            }
            return bStatus;
        }

    }
}

