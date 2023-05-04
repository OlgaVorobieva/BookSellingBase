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
    public partial class AddUserForm : Form
    {
        UserRepository userRepository;
        public AddUserForm()
        {
            InitializeComponent();

            UserTypeCb.Items.Add("Trader");
            UserTypeCb.Items.Add("Customer");

            userRepository = new UserRepository();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Login = LoginTb.Text.Trim();
            newUser.Password = PWDTb.Text.Trim();
            newUser.Name = NameTb.Text;
            newUser.UserType = UserTypeCb.SelectedItem.ToString();
            userRepository.CreateNewUser(newUser);
            MessageBox.Show("User created successfully");
            DialogResult = DialogResult.OK;
        }
    }
}
