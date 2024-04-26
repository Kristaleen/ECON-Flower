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
    public partial class OrderPanel : Form
    {
        private string connectionString = "server=127.0.0.1; user=root; database=flowerdb; password=password";
        private DataTable ordersDataTable;

        public OrderPanel()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM `order`";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    ordersDataTable = new DataTable();
                    adapter.Fill(ordersDataTable);
                }
                dataGridViewOrders.DataSource = ordersDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.Click -= btn_save_Click;
            try
            {
                // Ask for confirmation before proceeding with saving changes
                DialogResult confirmationResult = MessageBox.Show("Are you sure you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommandBuilder builder = new MySqlCommandBuilder();
                        builder.DataAdapter = new MySqlDataAdapter("SELECT * FROM `order`", connection);
                        builder.GetUpdateCommand();
                        int rowsAffected = builder.DataAdapter.Update(ordersDataTable);

                        // Check for completed orders and delete associated cart items
                        foreach (DataRow row in ordersDataTable.Rows)
                        {
                            string orderStatus = row["OrderStatus"].ToString();
                            int cartId = Convert.ToInt32(row["CartID"]);

                            if (orderStatus == "Completed")
                            {
                                DeleteCartItems(connection, cartId);
                            }
                        }
                    }
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
            finally
            {
                // Re-subscribe the event handler
                btn_save.Click += btn_save_Click;
            }
        }

        private void DeleteCartItems(MySqlConnection connection, int cartId)
        {
            try
            {
                // Delete cart items associated with the provided CartID
                string deleteCartItemsQuery = "DELETE FROM cart_item WHERE CartID = @cartId";
                MySqlCommand deleteCartItemsCommand = new MySqlCommand(deleteCartItemsQuery, connection);
                deleteCartItemsCommand.Parameters.AddWithValue("@cartId", cartId);
                deleteCartItemsCommand.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting cart items: " + ex.Message);
            }
        }

        private void btn_orderId_Click(object sender, EventArgs e)
        {
            int orderId;
            if (!int.TryParse(txt_orderID.Text, out orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            try
            {
                DataTable orderDetailsDt = new DataTable();
                DataTable productDt = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve order details based on the provided Order ID
                    string orderQuery = "SELECT CartID, OrderDate, TotalPrice, ShippingAddress, PaymentMethod, OrderStatus, DeliveryDate, PaymentStatus " +
                                        "FROM `order` " +
                                        "WHERE OrderID = @orderId";
                    MySqlCommand orderCommand = new MySqlCommand(orderQuery, connection);
                    orderCommand.Parameters.AddWithValue("@orderId", orderId);

                    // Execute the query and load results into DataTable
                    MySqlDataAdapter orderAdapter = new MySqlDataAdapter(orderCommand);
                    orderAdapter.Fill(orderDetailsDt);

                    // Retrieve product details based on the provided Order ID
                    string productQuery = "SELECT c.ProductID, p.ProductName, p.Price " +
                                  "FROM cart_item c " +
                                  "INNER JOIN product p ON c.ProductID = p.ProductID " +
                                  "WHERE c.CartID IN (SELECT CartID FROM `order` WHERE OrderID = @orderId)";
                    MySqlCommand productCommand = new MySqlCommand(productQuery, connection);  
                    productCommand.Parameters.AddWithValue("@orderId", orderId);

                    // Execute the query and load results into DataTable
                    MySqlDataAdapter productAdapter = new MySqlDataAdapter(productCommand);
                    productAdapter.Fill(productDt);
                }

                // Display the fetched order details in dataGridViewOrders
                dataGridViewOrders.DataSource = orderDetailsDt;

                // Display the fetched product details in dataGridView
                dataGridView.DataSource = productDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving order details: " + ex.Message);
            }
        }
    }
}