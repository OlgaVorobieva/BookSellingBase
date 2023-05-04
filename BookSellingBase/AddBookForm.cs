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
    public partial class AddBookForm : Form
    {
        User currentUser;
        BookRepository bookRepository;
        List<BookNameID> books;
        public AddBookForm(User user)
        {
            InitializeComponent();

            bookRepository = new BookRepository();//GetBooksNames();
            currentUser = user;
            books = bookRepository.GetBooksNames();
            //List<string> bookNames = new List<string>();
            for (var i = 0; i < books.Count; i++) 
            {
                bookNameCb.Items.Add(books[i].Name);
            }
            
            //bookNameCb.Items.AddRange(bookNames.ToArray());
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            bookRepository.CreateNewTraderBook(currentUser.ID, books[bookNameCb.SelectedIndex].ID, Convert.ToDouble(costTb.Text), Convert.ToInt32(countTb.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
