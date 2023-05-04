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
    public partial class CatalogCustomer : Form
    {
        Dictionary<int, CatalogBook> orderedBooks = new Dictionary<int, CatalogBook>();
        BookRepository bookRepository;
        public CatalogCustomer()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
        }

        private void CatalogCustomer_Load(object sender, EventArgs e)
        {
            var books = bookRepository.AllBookList();
            dataGridView1.DataSource = books;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
            {
                var book = dataGridView1.CurrentRow.DataBoundItem as CatalogBook;
                orderedBooks[book.ID] = book;
                MessageBox.Show("Added");
            }
        }
    }
}
