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
    public partial class ProductList : Form
    {
        private MySqlConnection mySqlConnection;
        private DataTable productDataTable;

        public ProductList()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=flowerdb; password=password");
            LoadProductData();
            LoadCategoryData();
        }

        private void LoadProductData()
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                    mySqlConnection.Open();

                string query = "SELECT * FROM product";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                productDataTable = new DataTable();
                adapter.Fill(productDataTable);
                dataGridView1.DataSource = productDataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void RemoveProduct(int productId)
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                    mySqlConnection.Open();

                string query = "DELETE FROM product WHERE ProductID = @productId";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@productId", productId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product removed successfully.");
                    LoadProductData();
                }
                else
                {
                    MessageBox.Show("No product found with the specified ID.");
                }
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


        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductID.Text, out int productIdToRemove))
            {
                MessageBox.Show("Please enter a valid PRODUCT ID.");
                return;
            }
            try
            {
                mySqlConnection.Open();
                RemoveProduct(productIdToRemove);
                LoadProductData();
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

        private void LoadCategoryData()
        {
            try
            {
                mySqlConnection.Open();
                string query = "SELECT CategoryID, CategoryName FROM category";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int categoryId = reader.GetInt32("CategoryID");
                    string categoryName = reader.GetString("CategoryName");

                }
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

        private void CloseConnection()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
                mySqlConnection.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string productName = txt_productname.Text;
            string description = txt_description.Text;
            decimal price;
            int categoryId;
            byte[] imageBytes = null;

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(description) || !decimal.TryParse(txt_price.Text, out price) || !int.TryParse(txt_categoryid.Text, out categoryId))
            {
                MessageBox.Show("Please fill all fields with valid data.");
                return;
            }

            if (pictureBox.Image != null)
            {
                ImageConverter imageConverter = new ImageConverter();
                imageBytes = (byte[])imageConverter.ConvertTo(pictureBox.Image, typeof(byte[]));
            }

            try
            {
                mySqlConnection.Open();
                string query = "INSERT INTO product (ProductName, Description, Price, CategoryID, ProductImage) VALUES (@productName, @description, @price, @categoryId, @image)";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.Parameters.AddWithValue("@image", imageBytes);
                command.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
                LoadProductData();
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

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open database connection
                mySqlConnection.Open();

                // Update changes to the database
                MySqlCommandBuilder builder = new MySqlCommandBuilder();
                builder.DataAdapter = new MySqlDataAdapter("SELECT * FROM product", mySqlConnection);
                builder.GetUpdateCommand();

                int rowsAffected = builder.DataAdapter.Update(productDataTable); // Change dt to productDataTable

                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
            finally
            {
                // Close database connection
                mySqlConnection.Close();
            }
        }
    }
}