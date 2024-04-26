using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ECON_Flower
{
    public partial class CustomerMain : Form
    {
        private int customerID;

        public CustomerMain(string firstName, int customerId)
        {
            InitializeComponent();
            lblCustomerName.Text = firstName;
            lblCustomerID.Text = customerId.ToString();
            customerID = customerId;
            ShowProductForm(customerId);
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ShowProductForm(customerID);
        }

        private void ShowProductForm(int customerId)
        {
            Product productForm = new Product(customerId);
            productForm.TopLevel = false;
            paneldisplay.Controls.Clear();
            paneldisplay.Controls.Add(productForm);
            productForm.Show();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}