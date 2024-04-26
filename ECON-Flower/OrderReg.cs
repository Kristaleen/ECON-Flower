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
using Mysqlx.Crud;

namespace ECON_Flower
{
    public partial class OrderReg : Form
    {
        private int customerId;
        private int cartId;
        private MySqlConnection mySqlConnection;
        public bool OrderCompleted { get; set; }

        public OrderReg(int customerId, int cartId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.cartId = cartId;


            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");

            // Adding Columns to the datagrid
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ProductName", "Product Name");
            dataGridView1.Columns.Add("ProductDescription", "Product Description");
            dataGridView1.Columns.Add("ProductPrice", "Product Price");

            // Populate DataGridView
            LoadCartItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCartItems()
        {
            try
            {
                mySqlConnection.Open();

                // Retrieve customer ID, cart ID, and total price
                string customerSql = "SELECT CustomerID FROM cart WHERE CartID = @CartId";
                MySqlCommand customerCmd = new MySqlCommand(customerSql, mySqlConnection);
                customerCmd.Parameters.AddWithValue("@CartId", cartId);
                object customerIdResult = customerCmd.ExecuteScalar();

                // Update customer ID label
                if (customerIdResult != null)
                {
                    lblCustomerID.Text = customerIdResult.ToString();
                }

                // Update cart ID label
                lblCartID.Text = cartId.ToString();

                // Retrieve address
                string addressSql = "SELECT Address FROM customer WHERE CustomerID = @CustomerId";
                MySqlCommand addressCmd = new MySqlCommand(addressSql, mySqlConnection);
                addressCmd.Parameters.AddWithValue("@CustomerId", customerId);
                object addressResult = addressCmd.ExecuteScalar();

                // Update address label
                if (addressResult != null)
                {
                    Address.Text = addressResult.ToString();
                }

                // Retrieve total price
                string totalPriceSql = "SELECT SUM(ci.Price) " +
                                        "FROM cart_item ci " +
                                        "WHERE ci.CartID = @CartId";
                MySqlCommand totalPriceCmd = new MySqlCommand(totalPriceSql, mySqlConnection);
                totalPriceCmd.Parameters.AddWithValue("@CartId", cartId);
                object totalPriceResult = totalPriceCmd.ExecuteScalar();

                // Update total price label
                if (totalPriceResult != null && totalPriceResult != DBNull.Value)
                {
                    double totalPrice = Convert.ToDouble(totalPriceResult);
                    TotalPrice.Text = totalPrice.ToString("C", new System.Globalization.CultureInfo("ar-AE"));
                }

                // Retrieve and display cart items
                string cartItemsSql = "SELECT ci.ProductID, p.ProductName, p.Description, ci.Price " +
                                        "FROM cart_item ci " +
                                        "JOIN product p ON ci.ProductID = p.ProductID " +
                                        "WHERE ci.CartID = @CartId";
                MySqlCommand cartItemsCmd = new MySqlCommand(cartItemsSql, mySqlConnection);
                cartItemsCmd.Parameters.AddWithValue("@CartId", cartId);
                MySqlDataReader reader = cartItemsCmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["ProductID"],
                        reader["ProductName"],
                        reader["Description"],
                        reader["Price"]
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart items: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            InsertPlaceOrder();
        }

        private void InsertPlaceOrder()
        {
            try
            {
                mySqlConnection.Open();

                // Insert into order table
                string insertOrderQuery = "INSERT INTO `order` (CartID, CustomerID, GuestEmail, OrderDate, TotalPrice, ShippingAddress, PaymentMethod, DeliveryDate) " +
                                "VALUES (@CartID, @CustomerID, @GuestEmail, CURRENT_TIMESTAMP, @TotalPrice, @ShippingAddress, @PaymentMethod, @DeliveryDate);" +
                                "SELECT LAST_INSERT_ID();";
                MySqlCommand insertOrderCommand = new MySqlCommand(insertOrderQuery, mySqlConnection);
                insertOrderCommand.Parameters.AddWithValue("@CartID", cartId);
                insertOrderCommand.Parameters.AddWithValue("@CustomerID", customerId);
                insertOrderCommand.Parameters.AddWithValue("@GuestEmail", ""); 

                // Retrieve the total price
                string totalPriceSql = "SELECT SUM(ci.Price) " +
                                        "FROM cart_item ci " +
                                        "WHERE ci.CartID = @CartId";
                MySqlCommand totalPriceCmd = new MySqlCommand(totalPriceSql, mySqlConnection);
                totalPriceCmd.Parameters.AddWithValue("@CartId", cartId);
                object totalPriceResult = totalPriceCmd.ExecuteScalar();
                if (totalPriceResult != null && totalPriceResult != DBNull.Value)
                {
                    insertOrderCommand.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(totalPriceResult));
                }
                else
                {
                    MessageBox.Show("Error: Unable to retrieve total price.");
                    return;
                }

                insertOrderCommand.Parameters.AddWithValue("@ShippingAddress", Address.Text);
                insertOrderCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod.SelectedItem.ToString());
                insertOrderCommand.Parameters.AddWithValue("@DeliveryDate", Date.Value);
                insertOrderCommand.ExecuteNonQuery();

                // For Successful Data Addition
                int orderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());

                MessageBox.Show($"Order placed successfully! Your Order ID is: {orderId}: USE THIS TO TRACK YOUR ORDER");
                OrderCompleted = true;

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

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
