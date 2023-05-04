using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookSellingBase.Core;

namespace BookSellingBase
{
    public partial class LoginForm : Form
    {
        //const String connectionString = "Persist Security Info=False;Integrated Security=true;server=(local);Initial Catalog=BooksellingBase";
        //SqlConnection connection = new SqlConnection(connectionString);
        UserRepository userRepository;
        public User user { get; private set; } = null;
        public LoginForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userLogin = loginTb.Text.Trim();
            string userPassword = PwdTb.Text.Trim();

            if (userLogin == "admin" && userPassword == "admin")
            {
                user = new User
                {
                    UserType = "Admin"
                };
            }
            else
            {
                user = userRepository.Login(userLogin, userPassword);
            }

            if (user == null)
            {
                MessageBox.Show("Wrong Login or Password");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
