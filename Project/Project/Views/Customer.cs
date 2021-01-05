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
    public partial class Customer : Form
    {

        public Customer()
        {
            InitializeComponent();
            GridCustomer.DataSource = ElectronicItemController.GetAllElectronicsItems();

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
