using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECON_Flower
{
    public partial class Main : Form
    {
        private int customerID;
        public Main()
        {
            InitializeComponent();
            this.customerID = customerID;
            LoginForm loginForm = new LoginForm();
            loginForm.CustomerLoggedIn += LoginForm_CustomerLoggedIn;
        
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            pnldisplay.Visible = false;
            loginPNL.Visible = true;

            LoginForm loginForm = new LoginForm();
            loginForm.CustomerLoggedIn += LoginForm_CustomerLoggedIn;
            loginForm.TopLevel = false;
            loginPNL.Controls.Add(loginForm); // Add the login form to the loginPNL panel
            loginForm.BringToFront();
            loginForm.Show();

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            pnldisplay.Visible = true;
            loginPNL.Visible = false;

            Product Product = new Product(this.customerID);
            Product.TopLevel = false;
            pnldisplay.Controls.Add(Product);
            Product.BringToFront();
            Product.Show();

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            pnldisplay.Visible = true;
            loginPNL.Visible = false;

            TrackOrder trackOrder = new TrackOrder();
            trackOrder.TopLevel = false;
            pnldisplay.Controls.Add(trackOrder);
            trackOrder.BringToFront();
            trackOrder.Show();
            
        }

        private void LoginForm_CustomerLoggedIn(object sender, CustomerLoggedInEventArgs e)
        {
            // Show the CustomerMain form after successful login
            CustomerMain customerMainForm = new CustomerMain(e.FirstName, e.CustomerId);
            customerMainForm.ShowDialog();
        }
    }
}
