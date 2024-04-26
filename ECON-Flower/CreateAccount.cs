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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ECON_Flower
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            RPassword.PasswordChar = '*';
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string firstNameValue = FirstName.Text;
            string lastNameValue = LastName.Text;
            string emailValue = REmail.Text;
            string numberValue = Number.Text;
            string addressValue = Address.Text;
            string passwordValue = RPassword.Text; 
            
            // Create a connection string
            string mysqlCon = "server=127.0.0.1; user=root; database=flowerdb; password=password";

            // Create a MySqlConnection object
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                // Open the database connection
                mySqlConnection.Open();

                // Create a MySqlCommand object with the SQL query to insert data into the database
                string query = "INSERT INTO customer (FirstName, LastName, Email, Number, Address, Password) VALUES (@FirstName, @LastName, @Email, @Number, @Address, @Password)";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                // Add parameters to the MySqlCommand object
                command.Parameters.AddWithValue("@FirstName", firstNameValue);
                command.Parameters.AddWithValue("@LastName", lastNameValue);
                command.Parameters.AddWithValue("@Email", emailValue);
                command.Parameters.AddWithValue("@Number", numberValue);
                command.Parameters.AddWithValue("@Address", addressValue);
                command.Parameters.AddWithValue("@Password", passwordValue);

                // Execute the SQL query (inserting data into the database)
                command.ExecuteNonQuery();

                // Optionally, display a message to indicate that the account has been created
                MessageBox.Show("Account created successfully!");
                // Hide all labels, textboxes, and buttons, but not panels
                foreach (Control control in Controls)
                {
                    if (control is Label || control is TextBox || control is Button)
                    {
                        control.Visible = false;
                    }
                }

                LoginForm L = new LoginForm();
                L.TopLevel = false;
                this.Controls.Add(L);
                BringToFront();
                L.Show();


            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                mySqlConnection.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Hide all labels, textboxes, and buttons, but not panels
            foreach (Control control in Controls)
            {
                if (control is Label || control is TextBox || control is Button)
                {
                    control.Visible = false;
                }
            }

            LoginForm L = new LoginForm();
            L.TopLevel = false;
            this.Controls.Add(L);
            BringToFront();
            L.Show();

        }
    }
}

