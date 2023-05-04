using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSellingBase
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            using (var loginForm = new LoginForm())
            {
                result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (loginForm.user.UserType == "Trader")
                    {
                        Application.Run(new TraderMainForm(loginForm.user));
                    }
                    else if (loginForm.user.UserType == "Customer")
                    {
                        Application.Run(new CustomerMainForm(loginForm.user));
                    }
                    else if (loginForm.user.UserType == "Admin") 
                    {
                        Application.Run(new AdminMainWindow(loginForm.user));
                    }
                }
            }
        }
    }
}
