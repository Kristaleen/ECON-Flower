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
using ECON_Flower;

namespace ECON_Flower
{
    public partial class CustomerList : Form
    {
        private MySqlConnection mySqlConnection;
        public CustomerList()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");
            LoadCustomerData();
        }
        private DataTable ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;
        }
        private void LoadCustomerData()
        {
            try
            {
                // Check if the connection is already open
                if (mySqlConnection.State != ConnectionState.Open)
                    mySqlConnection.Open();

                string query = "SELECT * FROM customer";
                DataTable dt = ExecuteQuery(query);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after loading data
                CloseConnection();
            }
        }

        private void RemoveCustomer(int customerId)
        {
            try
            {
                //Geting the CartID using the CustomerID 
                string queryGetCartId = "SELECT CartID FROM cart WHERE CustomerID = @customerId";
                MySqlCommand commandGetCartId = new MySqlCommand(queryGetCartId, mySqlConnection);
                commandGetCartId.Parameters.AddWithValue("@customerId", customerId);

                object cartIdObj = commandGetCartId.ExecuteScalar();

                if (cartIdObj != null) // Checking if Cart Exist
                {
                    int cartId = Convert.ToInt32(cartIdObj);

                    //1. Delete the cart
                    string queryDeleteCart = "DELETE FROM cart WHERE CartID = @cartId";
                    MySqlCommand commandDeleteCart = new MySqlCommand(queryDeleteCart, mySqlConnection);
                    commandDeleteCart.Parameters.AddWithValue("@cartId", cartId);
                    commandDeleteCart.ExecuteNonQuery();
                }

                //2. Now delete the customer
                string queryDeleteCustomer = "DELETE FROM customer WHERE CustomerID = @customerId";
                MySqlCommand commandDeleteCustomer = new MySqlCommand(queryDeleteCustomer, mySqlConnection);
                commandDeleteCustomer.Parameters.AddWithValue("@customerId", customerId);

                int rowsAffected = commandDeleteCustomer.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer removed successfully.");
                    txtcustomerID.Clear();
                    // Reload the customer data after removing a customer
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("No customer found with the specified ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void CloseConnection()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
                mySqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcustomerID.Text, out int customerIdToRemove))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            try
            {
                mySqlConnection.Open();
                RemoveCustomer(customerIdToRemove);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CID.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            try
            {
                // Open the connection
                mySqlConnection.Open();

                //1: Retrieve CartID from the 'order' table using CustomerID
                string cartIdQuery = "SELECT CartID FROM `order` WHERE CustomerID = @customerId";
                MySqlCommand cartIdCommand = new MySqlCommand(cartIdQuery, mySqlConnection);
                cartIdCommand.Parameters.AddWithValue("@customerId", customerId);
                int cartId = Convert.ToInt32(cartIdCommand.ExecuteScalar());

                //2: Retrieve ProductID from the 'cart_item' table using CartID
                string productIdQuery = "SELECT ProductID FROM cart_item WHERE CartID = @cartId";
                MySqlCommand productIdCommand = new MySqlCommand(productIdQuery, mySqlConnection);
                productIdCommand.Parameters.AddWithValue("@cartId", cartId);
                int productId = Convert.ToInt32(productIdCommand.ExecuteScalar());

                //3: Retrieve ProductName and Price from the 'product' table using ProductID
                string productQuery = "SELECT ProductName, Price FROM product WHERE ProductID = @productId";
                MySqlCommand productCommand = new MySqlCommand(productQuery, mySqlConnection);
                productCommand.Parameters.AddWithValue("@productId", productId);
                MySqlDataReader reader = productCommand.ExecuteReader();

                // Create a DataTable to hold the product details
                DataTable productDt = new DataTable();
                productDt.Load(reader);

                // Close the reader
                reader.Close();

                //4: Display ProductID, ProductName, and Price in the dataGridViewProduct
                dataGridViewProduct.DataSource = productDt;

                //5: Retrieve and display order details in dataGridViewOrder
                string orderQuery = "SELECT * FROM `order` WHERE CustomerID = @customerId";
                MySqlCommand orderCommand = new MySqlCommand(orderQuery, mySqlConnection);
                orderCommand.Parameters.AddWithValue("@customerId", customerId);
                DataTable orderDt = new DataTable();
                orderDt.Load(orderCommand.ExecuteReader());

                dataGridViewOrder.DataSource = orderDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                CloseConnection();
            }
        }
    }
}