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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            GridIUser.DataSource = UserController.GetAllUsers();
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
           dynamic user= UserController.GetUser(textBoxSearch.Text);
            if(user != null)
            {
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.Username;

            }
            else
            {
                textBoxName.Text ="";
                textBoxUsername.Text ="";
                MessageBox.Show("Can't Find User");
            }
        }

        private void UpdateBtnClick(object sender, EventArgs e)
        {
            var user = new { 
                Name= textBoxName.Text,
                Username= textBoxUsername.Text,

            };
            var r = UserController.UpdateUser(user);
            if (r)
            {
                MessageBox.Show("Success on Update");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void DeleteBtnClick(object sender, EventArgs e)
        {
            var r = UserController.DeleteUser(textBoxUsername.Text);
            if (r)
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("Success on Delete");
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("Could not Delete");
            }

        }

        private void RegistrationBtnClick(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
