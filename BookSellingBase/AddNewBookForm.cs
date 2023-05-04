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
    public partial class AddNewBookForm : Form
    {
        BookRepository bookRepository;
        public AddNewBookForm()
        {
            InitializeComponent();
            bookRepository = new BookRepository();

            var authors = bookRepository.GetAllAuthors();

            ((ListBox)authorClb).DataSource = authors;
            ((ListBox)authorClb).DisplayMember = "Name";

            var categories = bookRepository.GetAllCategories();
            categoryTb.DataSource = categories;
            categoryTb.DisplayMember = "Name";

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Name = nameTb.Text,
                Discription = discriptionRTb.Text,
                Year = Convert.ToInt32(yearTb.Text),
                CategoryID = (categoryTb.SelectedItem as Category).ID,
                AuthorList = new List<Author>()
            };
            var checkedAuthors = authorClb.CheckedItems;

            foreach (var authorChecked in checkedAuthors)
            {
                if (authorChecked is Author author)
                {
                    newBook.AuthorList.Add(author);
                }
            }
            bookRepository.CreateBook(newBook);

            DialogResult = DialogResult.OK;

        }
    }
}
