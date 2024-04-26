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
    public partial class Admin : Form
    {
        private int customerId;

        public Admin()
        {
            InitializeComponent();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerList CL = new CustomerList();
            CL.TopLevel = false;
            pnldisplay.Controls.Add(CL);
            CL.BringToFront();
            CL.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ProductList PL = new ProductList();
            PL.TopLevel = false;
            pnldisplay.Controls.Add(PL);
            PL.BringToFront();
            PL.Show();

        }

        private void btn_orderlist_Click(object sender, EventArgs e)
        {
            OrderPanel OP = new OrderPanel();
            OP.TopLevel = false;
            pnldisplay.Controls.Add(OP);
            OP.BringToFront();
            OP.Show();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Product P = new Product(customerId);
            P.TopLevel = false;
            pnldisplay.Controls.Add(P);
            P.BringToFront();
            P.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Open the main form
            Main mainForm = new Main();
            mainForm.Show();
        }
    }
}
