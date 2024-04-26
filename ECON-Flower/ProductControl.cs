using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ECON_Flower
{
    public partial class ProductControl : UserControl
    {
        public event EventHandler AddToCartClicked;
        public event EventHandler RemoveFromCartClicked;

        public ProductControl()
        {
            InitializeComponent();
            btn_remove.Visible = false; // Hide the remove button initially
        }

        // Properties for accessing and setting control values
        public Image ProductImageSource
        {
            get => ProductImage.Image;
            set => ProductImage.Image = value;
        }

        public string ID
        {
            get => ProductID.Text;
            set => ProductID.Text = value;
        }

        public string ProductNameSource
        {
            get => ProductName.Text;
            set => ProductName.Text = value;
        }

        public string ProductDescription
        {
            get => Description.Text;
            set => Description.Text = value;
        }

        private double _productPrice;
        public double ProductPrice
        {
            get => _productPrice;
            set
            {
                _productPrice = value;
                UpdatePriceLabel(value);
            }
        }
        private void UpdatePriceLabel(double price)
        {
            CultureInfo uaeCulture = new CultureInfo("ar-AE");
            Price.Text = price.ToString("C", uaeCulture);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            RemoveFromCartClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowAddToCartButton()
        {
            btn_add.Visible = true;
        }

        public void HideAddToCartButton()
        {
            btn_add.Visible = false;
        }

        public void ShowRemoveButton()
        {
            btn_remove.Visible = true;
        }

        public void HideRemoveButton()
        {
            btn_remove.Visible = false;
        }
        private void ProductName_Click(object sender, EventArgs e)
        {
        
        }
        private void ProductControl_Load(object sender, EventArgs e)
        {
        
        }
    }
}