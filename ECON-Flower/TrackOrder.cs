using MySql.Data.MySqlClient;
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
    public partial class TrackOrder : Form
    {
        private MySqlConnection mySqlConnection;
        public TrackOrder()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");
            pnl_order.Visible = false;
            pnl_cancel.Visible = false;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            pnl_order.Visible = true;
            pnl_cancel.Visible = true;

            int orderId;
            if (int.TryParse(txtID.Text, out orderId))
            {
                PopulateOrderDetails(orderId);
            }
            else
            {
                MessageBox.Show("Please Enter a valid order ID.");
                pnl_order.Visible = false;
                pnl_cancel.Visible = false;
            }
        }

        private void PopulateOrderDetails(int orderId)
        {
            {
                // Create a SQL query to fetch order details from the database based on the order ID
                string query = "SELECT OrderID, OrderDate, TotalPrice, OrderStatus, DeliveryDate FROM `order` WHERE OrderID = @OrderId";

                try
                {
                    // Open the connection
                    mySqlConnection.Open();

                    // Prepare the command
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        // Execute the command and read the data
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if data is available
                            if (reader.Read())
                            {
                                // Retrieve data from the reader
                                string orderNumber = reader["OrderID"].ToString();
                                DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                                DateTime deliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                                decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                                string orderStatus = reader["OrderStatus"].ToString();

                                // Update labels with retrieved order information
                                OrderID.Text = orderNumber;
                                OrderDate.Text = orderDate.ToString("D");
                                Date.Text = deliveryDate.ToString("D");
                                TotalPrice.Text = totalPrice.ToString("0.00");
                                Status.Text = orderStatus;
                            }
                            else
                            {
                                // Order not found
                                MessageBox.Show("Order not found.");
                                pnl_order.Visible = false;
                                pnl_cancel.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    mySqlConnection.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Retrieve the order ID from the txtCancel textbox
            int orderId;
            if (int.TryParse(txtCancel.Text, out orderId))
            {
                // SQL query to delete the order from the database based on the order ID
                string deleteQuery = "DELETE FROM `order` WHERE OrderID = @OrderId";

                try
                {
                    mySqlConnection.Open();

                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, mySqlConnection))
                    {

                        deleteCommand.Parameters.AddWithValue("@OrderId", orderId);

                        // Execute the command
                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Order canceled successfully.");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    mySqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid order ID to cancel.");
            }
        }

    }
}