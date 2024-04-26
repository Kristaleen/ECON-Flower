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
using MySql.Data.MySqlClient;
using System.IO;
using static Mysqlx.Expect.Open.Types;

namespace ECON_Flower
{
    public partial class Product : Form
    {
        private MySqlConnection mySqlConnection;
        private List<ProductControl> selectedProducts = new List<ProductControl>();
        private int loggedInCustomerId;


        public Product(int customerId)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            PopulateAllProducts();
            loggedInCustomerId = customerId;

            // Load cart items for the logged-in customer
            if (customerId != 0)
            {
                LoadCartItems(customerId);
            }

        }

        private void InitializeDatabaseConnection()
        {
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");
        }

        private void PopulateAllProducts()
        {
            try
            {
                mySqlConnection.Open();

                // Clear existing controls in the panel
                flowLayoutPanel1.Controls.Clear();

                // SQL command to select products from the database with the specified category
                string sql = $"SELECT ProductID, ProductName, Description, Price, ProductImage FROM product";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Read product details
                    int productID = reader.GetInt32("ProductID");
                    string productName = reader.GetString("ProductName");
                    string description = reader.GetString("Description");
                    double price = reader.GetDouble("Price");
                    byte[] productImageBytes = (byte[])reader["ProductImage"];

                    // Convert byte[] to Image
                    using (MemoryStream ms = new MemoryStream(productImageBytes))
                    {
                        Image productImage = Image.FromStream(ms);

                        // Product control to be placed in FlowLayoutPanel
                        ProductControl productControl = new ProductControl();
                        productControl.ID = productID.ToString();
                        productControl.ProductNameSource = productName;
                        productControl.ProductDescription = description;
                        productControl.ProductPrice = price;
                        productControl.ProductImageSource = productImage;

                        // Subscribe to AddToCartClicked event
                        productControl.AddToCartClicked += ProductControl_AddToCartClicked;

                        // Add product control to FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(productControl);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void PopulateProducts(int CategoryID)
        {
            try
            {
                mySqlConnection.Open();

                flowLayoutPanel1.Controls.Clear();

                // SQL command to select products from the database with the specified category
                string sql = $"SELECT ProductID, ProductName, Description, Price, ProductImage FROM product WHERE CategoryID = {CategoryID}";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Read product details
                    int productID = reader.GetInt32("ProductID");
                    string productName = reader.GetString("ProductName");
                    string description = reader.GetString("Description");
                    double price = reader.GetDouble("Price");
                    byte[] productImageBytes = (byte[])reader["ProductImage"];

                    // Convert byte[] to Image
                    using (MemoryStream ms = new MemoryStream(productImageBytes))
                    {
                        Image productImage = Image.FromStream(ms);

                        // Product control to be placed in FlowLayoutPanel
                        ProductControl productControl = new ProductControl();
                        productControl.ID = productID.ToString();
                        productControl.ProductNameSource = productName;
                        productControl.ProductDescription = description;
                        productControl.ProductPrice = price;
                        productControl.ProductImageSource = productImage;

                        // Subscribe to AddToCartClicked event
                        productControl.AddToCartClicked += ProductControl_AddToCartClicked;

                        // Add product control to FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(productControl);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateProducts(1); //birthday category
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateProducts(3); // Anniversary category
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateProducts(5); // Wedding category
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopulateProducts(4); // Newborn category
        }

        // Event handler for Add to Cart button clicked
        private void ProductControl_AddToCartClicked(object sender, EventArgs e)
        {
            try
            {
                ProductControl productControl = sender as ProductControl;
                int productId = int.Parse(productControl.ID);
                int customerId = GetCustomerId();
                int cartId = GetCartId(customerId);

                if (customerId != 0)
                {
                    AddProductToCart(customerId, cartId, productId, productControl.ProductPrice);
                }
                else
                {
                    AddToCart(productControl);
                    DisplayCartProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add product to the cart_item table
        private void AddProductToCart(int customerId, int cartId, int productId, double price)
        {
            try
            {
                mySqlConnection.Open();

                if (cartId != 0)
                {
                    MySqlCommand addCommand = new MySqlCommand("INSERT INTO cart_item (CartID, ProductID, Price, created_at) VALUES (@CartID, @ProductID, @Price, NOW())", mySqlConnection);
                    addCommand.Parameters.AddWithValue("@CartID", cartId);
                    addCommand.Parameters.AddWithValue("@ProductID", productId);
                    addCommand.Parameters.AddWithValue("@Price", price);
                    addCommand.ExecuteNonQuery();

                    // Reload cart items
                    ReloadCartItems(customerId);
                }
                else
                {
                    // Handle case where cart ID is not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }


        // Add selected products to the cart_item table
        private void AddSelectedProductsToCart(int loggedInCustomerId)
        {
            int cartId = GetCartId(loggedInCustomerId);
            if (cartId != 0)
            {
                foreach (ProductControl productControl in selectedProducts)
                {
                    int productId = int.Parse(productControl.ID);
                    double price = productControl.ProductPrice;
                    AddProductToCart(loggedInCustomerId, cartId, productId, productControl.ProductPrice);

                }
            }
        }

        // Add product control to selected products list
        private void AddToCart(ProductControl productControl)
        {
            ProductControl clonedProductControl = CloneProductControl(productControl);
            selectedProducts.Add(clonedProductControl);
            clonedProductControl.HideAddToCartButton();
            clonedProductControl.ShowRemoveButton();
        }

        // Clone product control
        private ProductControl CloneProductControl(ProductControl productControl)
        {
            ProductControl clonedProductControl = new ProductControl();
            clonedProductControl.ID = productControl.ID;
            clonedProductControl.ProductNameSource = productControl.ProductNameSource;
            clonedProductControl.ProductDescription = productControl.ProductDescription;
            clonedProductControl.ProductPrice = productControl.ProductPrice;
            clonedProductControl.ProductImageSource = productControl.ProductImageSource;
            //clonedProductControl.AddToCartClicked += ProductControl_AddToCartClicked;
            clonedProductControl.RemoveFromCartClicked += ProductControl_RemoveFromCartClicked;
            //clonedProductControl.HideAddToCartButton();
            clonedProductControl.ShowRemoveButton();
            return clonedProductControl;
        }

        // Display selected products in the cart panel
        private void DisplayCartProducts()
        {
            flowLayoutPanel2.Controls.Clear();

            foreach (ProductControl productControl in selectedProducts)
            {
                // Add product control to flowLayoutPanel2
                flowLayoutPanel2.Controls.Add(productControl);
                // Update total price label
                UpdateTotalPriceLabel();

                // Hide Add to Cart button and show Remove button
                productControl.HideAddToCartButton();
                productControl.ShowRemoveButton();
                // Subscribe to RemoveFromCartClicked event
                productControl.RemoveFromCartClicked += ProductControl_RemoveFromCartClicked;
                
            }
        }


        // Update total price label
        private void UpdateTotalPriceLabel()
        {
            double totalPrice = selectedProducts.Sum(productControl => productControl.ProductPrice);

            // Check if total price is greater than 0 before updating the label
            if (totalPrice > 0)
            {
                TotalPrice.Visible = true;
                TotalPrice.Text = $"Total Price: {totalPrice.ToString("C", new CultureInfo("ar-AE"))}";
            }
            else
            {
                TotalPrice.Visible = false;
            }
        }



        // Event handler for Remove from Cart button clicked
        private void ProductControl_RemoveFromCartClicked(object sender, EventArgs e)
        {
            try
            {
                ProductControl productControl = sender as ProductControl;
                int productId = int.Parse(productControl.ID);
                int customerId = GetCustomerId();
                if (customerId != 0)
                {
                    RemoveProductFromCart(customerId, productId);
                }
                else
                {
                    RemoveFromCart(productControl);
                }
                // Remove product control from flowLayoutPanel2
                flowLayoutPanel2.Controls.Remove(productControl);
                // Update total price label
                UpdateTotalPriceLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing product from cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove product control from selected products list
        private void RemoveFromCart(ProductControl productControl)
        {
            ProductControl selectedProduct = selectedProducts.FirstOrDefault(p => p.ID == productControl.ID);
            if (selectedProduct != null)
            {
                selectedProducts.Remove(selectedProduct);
            }
        }

        // Remove product from the cart_item table
        private void RemoveProductFromCart(int customerId, int productId)
        {
            int cartId = GetCartId(customerId);
            if (cartId != 0)
            {
                try
                {
                    mySqlConnection.Open(); // Open the database connection

                    MySqlCommand removeCommand = new MySqlCommand("DELETE FROM cart_item WHERE CartID = @CartID AND ProductID = @ProductID", mySqlConnection);
                    removeCommand.Parameters.AddWithValue("@CartID", cartId);
                    removeCommand.Parameters.AddWithValue("@ProductID", productId);
                    removeCommand.ExecuteNonQuery();

                    // Reload cart items
                    ReloadCartItems(customerId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing product from cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close(); // Close the database connection in the finally block
                }
            }
        }

        // Reload cart items after removal
        private void ReloadCartItems(int customerId)
        {
            flowLayoutPanel2.Controls.Clear();
            LoadCartItems(customerId);
        }

        // Get customer ID from the login form
        private int GetCustomerId()
        {
            return loggedInCustomerId;
        }

        // Get cart ID for the given customer ID
        private int GetCartId(int loggedInCustomerId)
        {
            int cartId = 0;
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT CartID FROM cart WHERE CustomerID = @CustomerId";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@CustomerId", loggedInCustomerId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    cartId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting cart ID: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return cartId;
        }

        private bool isPanelVisible = false; // Initialize visibility flag

        private void button6_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                // Panel is currently visible, send it to back to hide it
                pnl_cart.SendToBack();
            }
            else
            {
                // Panel is currently hidden, bring it to front to show it
                pnl_cart.BringToFront();
            }

            // Toggle the visibility flag
            isPanelVisible = !isPanelVisible;
        }

        // Load cart items for the given customer ID
        private void LoadCartItems(int customerId)
        {
            try
            {
                // Make sure the connection is closed before opening it again
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlConnection.Close();
                }

                mySqlConnection.Open();

                string sql = "SELECT p.ProductID, p.ProductName, p.Description, p.Price, p.ProductImage " +
                             "FROM cart_item ci " +
                             "JOIN product p ON ci.ProductID = p.ProductID " +
                             "WHERE ci.CartID = (SELECT CartID FROM cart WHERE CustomerID = @CustomerId)";
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AddProductControlToCart(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart items: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection in the finally block
                mySqlConnection.Close();
            }
        }

        // Add product control to cart panel
        private void AddProductControlToCart(MySqlDataReader reader)
        {
            int productID = reader.GetInt32("ProductID");
            string productName = reader.GetString("ProductName");
            string description = reader.GetString("Description");
            double price = reader.GetDouble("Price");
            byte[] productImageBytes = (byte[])reader["ProductImage"];

            using (MemoryStream ms = new MemoryStream(productImageBytes))
            {
                Image productImage = Image.FromStream(ms);
                ProductControl productControl = new ProductControl();
                productControl.ID = productID.ToString();
                productControl.ProductNameSource = productName;
                productControl.ProductDescription = description;
                productControl.ProductPrice = price;
                productControl.ProductImageSource = productImage;

                // Hide Add to Cart button and show Remove button
                productControl.HideAddToCartButton();
                productControl.ShowRemoveButton();

                // Subscribe to RemoveFromCartClicked event
                productControl.RemoveFromCartClicked += ProductControl_RemoveFromCartClicked;

                // Add product control to flowLayoutPanel2
                flowLayoutPanel2.Controls.Add(productControl);
                UpdateTotalPriceLabel();
            }
        }
        // Event handler for Checkout button clicked
        private void btn_order_Click(object sender, EventArgs e)
        {
            int customerId = GetCustomerId();
            int cartId = GetCartId(customerId);

            if (customerId != 0)
            {
                if (cartId != 0 && CartContainsItems(cartId))
                {
                    OpenOrderForm(customerId);
                }
                else
                {
                    MessageBox.Show("Your cart is empty. Please add products to proceed with the order.");
                }
            }
            else if (selectedProducts.Count > 0)
            {
                OpenOrderForm();
            }
            else
            {
                MessageBox.Show("Your cart is empty. Please add products to proceed with the order.");
            }
        }

        // Method to check if the cart contains items
        private bool CartContainsItems(int cartId)
        {
            try
            {
                mySqlConnection.Open();
                string selectCartItemQuery = "SELECT COUNT(*) FROM cart_item WHERE CartID = @CartID";
                MySqlCommand command = new MySqlCommand(selectCartItemQuery, mySqlConnection);
                command.Parameters.AddWithValue("@CartID", cartId);
                int itemCount = Convert.ToInt32(command.ExecuteScalar());
                return itemCount >= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking cart items: " + ex.Message);
                return false;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        // Method to open the order form
        private void OpenOrderForm(int customerId = -1)
        {
            try
            {
                // Check if there are selected products or a valid customer ID
                if ((selectedProducts.Count == 0 && customerId == -1) || (customerId != -1 && !CartContainsItems(GetCartId(customerId))))
                {
                    MessageBox.Show("Your cart is empty. Please add products to proceed with the order.");
                    return;
                }

                // Instantiate the order form based on the provided customer ID or selected products

                if (customerId != -1)
                {
                    OrderReg orderReg = new OrderReg(customerId, GetCartId(customerId));
                    orderReg.TopLevel = false;
                    pnl_cart.Controls.Add(orderReg);
                    orderReg.BringToFront();
                    orderReg.FormClosed += (sender, e) =>
                    {
                        if (orderReg.OrderCompleted) 
                        {
                            flowLayoutPanel2.Controls.Clear(); 
                        }
                    };
                    orderReg.Show();
                }
                else
                {
                    OrderForm orderForm = new OrderForm(selectedProducts);
                    orderForm.TopLevel = false;
                    pnl_cart.Controls.Add(orderForm);
                    orderForm.BringToFront();
                    orderForm.FormClosed += (sender, e) =>
                    {
                        if (orderForm.OrderCompleted) // Check if the order was successfully completed
                        {
                            flowLayoutPanel2.Controls.Clear(); ; // Clear the cart panel if the order was successful
                        }
                    };
                    orderForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the order form: " + ex.Message);
            }



        }

    }        
}



