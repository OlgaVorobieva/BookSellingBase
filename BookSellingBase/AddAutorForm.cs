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
    public partial class AddAutorForm : Form
    {
        BookRepository bookRepository;
        public AddAutorForm()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bookRepository.CreateNewAuthor(nameTb.Text);
            MessageBox.Show("Author has been added");
            DialogResult = DialogResult.OK;
        }
    }
}
