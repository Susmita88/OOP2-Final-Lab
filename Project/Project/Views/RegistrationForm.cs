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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterBtnClick(object sender, EventArgs e)
        {
            var user = new
            {
                Id=0,
                Name = textBoxName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
                Email = textBoxEmail.Text,
                Type= comboBoxRegister.Text,

            };
            var result = UserController.AddUser(user);
            if (result)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("Could not Add User");
            }
        }
    }
}
