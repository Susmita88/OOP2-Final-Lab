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
    public partial class ItemInfoUpdate : Form
    {
        public ItemInfoUpdate()
        {
            InitializeComponent();
            GridItem.DataSource = ElectronicItemController.GetAllElectronicsItems();


        }      

           
        private void ItemInfoUpdate_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            dynamic item = ElectronicItemController.GetElectronicItem(textBoxSearch.Text);
            if (item != null)
            {
                textBoxItemName.Text = item.ItemName;
                textBoxItemPrice.Text = item.ItemPrice;

            }
            else
            {
                textBoxItemName.Text = "";
                textBoxItemPrice.Text = "";
                MessageBox.Show("Can't Find Item");
            }
        }

        private void UpdateBtnClick(object sender, EventArgs e)
        {
            var item = new
            {
                ItemName = textBoxItemName.Text,
                ItemPrice = textBoxItemPrice.Text,

            };
            var r = UserController.UpdateUser(item);
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
            var r = ElectronicItemController.DeleteElectronicItem(textBoxItemName.Text);
            if (r)
            {
                textBoxItemName.Text = "";
                textBoxItemPrice.Text = "";
                MessageBox.Show("Success on Delete");
            }
            else
            {
                textBoxItemName.Text = "";
                textBoxItemPrice.Text = "";
                MessageBox.Show("Could not Delete");
            }
        }
    }
}
