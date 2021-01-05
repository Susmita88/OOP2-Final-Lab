using Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtnClick(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string type = comboBoxlogin.SelectedItem.ToString();
            var r = UserController.AuthenticateUser(username, password);
            if(r!= null)
            {
                if (type == "Admin")
                {
                    new DashboardForm().Show();
                }
                
            }
            else
            {
                MessageBox.Show("User is Not valid");
            }
        }

       

        private void ItemBtnClick(object sender, EventArgs e)
        {
            new Customer().Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
