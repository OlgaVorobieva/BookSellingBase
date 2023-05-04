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
    public partial class AdminMainWindow : Form
    {
        UserRepository userRepository;
        OrderRepository orderRepository;
        BookRepository bookRepository;

        User currentUser;
        public AdminMainWindow(User user)
        {
            InitializeComponent();
            currentUser = user;


            userRepository = new UserRepository();
            BindUsers();

            orderRepository = new OrderRepository();
            BindOrders();

            BindTraderCom();

            bookRepository = new BookRepository();
            BindAuthors();
            BindBookCom();

            BindBooks();

        }

        private void BindBooks()
        {
            var books = bookRepository.GetBooks();
            var bm = new List<BookModel>();
            foreach (var book in books)
            {
                bm.Add(new BookModel(book));
            }
            BookDg.DataSource = bm;
        }

        private void BindTraderCom()
        {
            var traderComms = userRepository.GetAllTraderComments();
            comTrDg.DataSource = traderComms;
        }

        private void BindUsers()
        {
            var users = userRepository.GetAllUsers();
            UsersDg.DataSource = users;
        }

        private void BindOrders()
        {
            var orders = orderRepository.GetDisputeOrders();
            ordersDg.DataSource = orders;
        }

        private void BindAuthors()
        {
            var authors = bookRepository.GetAllAuthors();
            authorDg.DataSource = authors;
        }

        private void BindBookCom()
        {
            var bookComms = bookRepository.GetAllBookComments();
            comDg.DataSource = bookComms;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddNewBookForm addBook = new AddNewBookForm();
            addBook.ShowDialog();
            BindBooks();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            AddAutorForm addAutor = new AddAutorForm();
            addAutor.ShowDialog();
            BindAuthors();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.ShowDialog();
            BindUsers();
        }

        private void comDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comDg.Columns[e.ColumnIndex].Name == "Delete")
            {
                var comment = comDg.CurrentRow.DataBoundItem as BookComment;
                bookRepository.DeleteBookComment(comment.ID);
                MessageBox.Show("Deleted");

                BindBookCom();
            }
        }

        private void ordersDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var order = ordersDg.CurrentRow.DataBoundItem as DisputeOrder;
                DisputeForm disputeForm = new DisputeForm(currentUser, order.ID);
                disputeForm.ShowDialog();

                BindOrders();
            }
        }

        private void comTrDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var comment = comTrDg.CurrentRow.DataBoundItem as TraderComment;
                userRepository.DeleteTraderComment(comment.ID);
                MessageBox.Show("Deleted");

                BindTraderCom();
            }
        }
    }
}
