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
 
    public partial class ChangePwdForm : Form
    {  
        User currentUser;
        UserRepository userRepository;
        public ChangePwdForm(User user)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            currentUser = user;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (oldPwdTB.Text == currentUser.Password.Trim())
            {
                userRepository.ChangePassword(currentUser,newPWDTD.Text);
                MessageBox.Show("Password has been changed");
                DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Wrong old Password");
            }
        }
    }
}
