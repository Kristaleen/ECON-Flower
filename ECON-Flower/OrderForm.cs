using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
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

namespace ECON_Flower
{
    public partial class OrderForm : Form
    {
        private List<ProductControl> cartProducts;
        private MySqlConnection mySqlConnection;
        public bool OrderCompleted { get; set; }

        public OrderForm(List<ProductControl> cartProducts)
        {
            InitializeComponent();
            this.cartProducts = cartProducts;

            
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");

            // Adding Columns to the datagrid
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ProductName", "Product Name");
            dataGridView1.Columns.Add("ProductDescription", "Product Description");
            dataGridView1.Columns.Add("ProductPrice", "Product Price");

            DisplayCartProducts();
            CalculateTotalPrice();
        }

        private void DisplayCartProducts()
        {
            dataGridView1.Rows.Clear();

            foreach (ProductControl productControl in cartProducts)
            {
                // Add the product details to DataGridView rows
                dataGridView1.Rows.Add(productControl.ID, productControl.ProductNameSource, productControl.ProductDescription, productControl.ProductPrice);
            }
        }

        private void CalculateTotalPrice()
        {
            double totalPrice = 0.0;

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the row is not null and is not a new row
                if (row != null && !row.IsNewRow)
                {
                    // Parse the price value from the DataGridView cell
                    double price = 0.0;
                    if (double.TryParse(Convert.ToString(row.Cells["ProductPrice"].Value), out price))
                    {
                        // Add the price to the total
                        totalPrice += price;
                    }
                }
            }

            // Update the total price label with the calculated total
            TotalPrice.Text = $"TOTAL PRICE: {totalPrice.ToString("C", new CultureInfo("ar-AE"))}";
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            InsertDataIntoDatabaseForGuest();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }


        private void InsertDataIntoDatabaseForGuest()
        {
            try
            {
                mySqlConnection.Open();

                // Generate a shorter session ID for guest customers
                string sessionId = GenerateRandomSessionId();

                // Insert into cart table
                string insertCartQuery = "INSERT INTO cart (SessionID, created_at) VALUES (@SessionID, CURRENT_TIMESTAMP);";
                MySqlCommand insertCartCommand = new MySqlCommand(insertCartQuery, mySqlConnection);
                insertCartCommand.Parameters.AddWithValue("@SessionID", sessionId); // Using generated SessionID
                insertCartCommand.ExecuteNonQuery();

                // Retrieve the generated CartID
                int cartId = 0;
                string selectCartIdQuery = "SELECT LAST_INSERT_ID();"; // Assuming LAST_INSERT_ID() returns the last inserted auto_increment value
                using (MySqlCommand command = new MySqlCommand(selectCartIdQuery, mySqlConnection))
                {
                    cartId = Convert.ToInt32(command.ExecuteScalar());
                }

                // Insert into cart_item table for each product in the cart
                foreach (ProductControl productControl in cartProducts)
                {
                    string insertCartItemQuery = "INSERT INTO cart_item (CartID, ProductID, Price, created_at) " +
                                                 "VALUES (@CartID, @ProductID, @Price, CURRENT_TIMESTAMP);";
                    MySqlCommand insertCartItemCommand = new MySqlCommand(insertCartItemQuery, mySqlConnection);
                    insertCartItemCommand.Parameters.AddWithValue("@CartID", cartId);
                    insertCartItemCommand.Parameters.AddWithValue("@ProductID", productControl.ID);
                    insertCartItemCommand.Parameters.AddWithValue("@Price", productControl.ProductPrice);
                    insertCartItemCommand.ExecuteNonQuery();
                }

                // Insert into order table
                string insertOrderQuery = "INSERT INTO `order` (CartID, GuestEmail, OrderDate, TotalPrice, ShippingAddress, PaymentMethod, DeliveryDate) " +
                                 "VALUES (@CartID, @GuestEmail, CURRENT_TIMESTAMP, @TotalPrice, @ShippingAddress, @PaymentMethod, @DeliveryDate);" +
                                 "SELECT LAST_INSERT_ID();"; 
                MySqlCommand insertOrderCommand = new MySqlCommand(insertOrderQuery, mySqlConnection);
                insertOrderCommand.Parameters.AddWithValue("@CartID", cartId);
                insertOrderCommand.Parameters.AddWithValue("@GuestEmail", txtEmail.Text);

                string totalPriceString = TotalPrice.Text;
                // Remove non-numeric characters from the string
                totalPriceString = new string(totalPriceString.Where(char.IsDigit).ToArray());
                decimal totalPrice;
                if (decimal.TryParse(totalPriceString, out totalPrice))
                {
                    // Use totalPrice for further processing (e.g., inserting into the database)
                    insertOrderCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                }
                else
                {
                    // Handle the case where the input string couldn't be parsed as a decimal
                    Console.WriteLine("Error: Unable to parse TotalPrice.Text as a decimal.");
                }

                insertOrderCommand.Parameters.AddWithValue("@ShippingAddress", txtAddress.Text);
                insertOrderCommand.Parameters.AddWithValue("@PaymentMethod", txtPaymentMethod.SelectedItem.ToString());
                insertOrderCommand.Parameters.AddWithValue("@DeliveryDate", DateTime.Now.AddDays(7));
                insertOrderCommand.ExecuteNonQuery();

                //For Successful Data Addition
                int orderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());

                MessageBox.Show($"Order placed successfully! Your Order ID is: {orderId}: USE THIS TO TRACK YOUR ORDER");
                OrderCompleted = true;
                ClearOrderForm();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private string GenerateRandomSessionId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ClearOrderForm()
        {
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPaymentMethod.SelectedIndex = -1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}