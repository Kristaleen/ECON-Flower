using ECON_Flower;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;

namespace ECON_Flower
{
    public partial class LoginForm : Form
    {
        public event EventHandler<CustomerLoggedInEventArgs> CustomerLoggedIn;

        public LoginForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=flowerdb; password=password";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string Email = email.Text.Trim(); // Trim whitespace
            string Password = password.Text;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                try
                {
                    mySqlConnection.Open();

                    MySqlCommand customerCommand = new MySqlCommand("SELECT * FROM customer WHERE Email = @Email AND Password = @Password", mySqlConnection);
                    customerCommand.Parameters.AddWithValue("@Email", Email);
                    customerCommand.Parameters.AddWithValue("@Password", Password);
                    MySqlDataReader customerReader = customerCommand.ExecuteReader();

                    if (customerReader.Read())
                    {
                        int customerId = Convert.ToInt32(customerReader["CustomerID"]);
                        string firstName = customerReader["FirstName"].ToString();
                        customerReader.Close();

                        MySqlCommand checkCartCommand = new MySqlCommand("SELECT COUNT(*) FROM cart WHERE CustomerID = @CustomerID", mySqlConnection);
                        checkCartCommand.Parameters.AddWithValue("@CustomerID", customerId);
                        int cartCount = Convert.ToInt32(checkCartCommand.ExecuteScalar());

                        if (cartCount == 0)
                        {
                            MySqlCommand INSERTtoCartCommand = new MySqlCommand("INSERT INTO cart (CustomerID) VALUES (@CustomerID)", mySqlConnection);
                            INSERTtoCartCommand.Parameters.AddWithValue("@CustomerID", customerId);
                            INSERTtoCartCommand.ExecuteNonQuery();
                        }
                        // Trigger the CustomerLoggedIn event
                        CustomerLoggedIn?.Invoke(this, new CustomerLoggedInEventArgs(firstName, customerId));
                        this.Close();
                    }
                    else
                    {
                        customerReader.Close();
                        MySqlCommand staffCommand = new MySqlCommand("SELECT * FROM staff WHERE Email = @Email AND Password = @Password", mySqlConnection);
                        staffCommand.Parameters.AddWithValue("@Email", Email);
                        staffCommand.Parameters.AddWithValue("@Password", Password);
                        MySqlDataReader staffReader = staffCommand.ExecuteReader();

                        if (staffReader.Read())
                        {
                            staffReader.Close();
                            this.Close();
                            Admin staffForm = new Admin();
                            staffForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Email or Password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            HideLoginFormControls();
            CreateAccount createAccountForm = new CreateAccount();
            createAccountForm.TopLevel = false;
            this.Controls.Add(createAccountForm);
            createAccountForm.BringToFront();
            createAccountForm.Show();
        }

        private void HideLoginFormControls()
        {
            label2.Visible = false;
            label3.Visible = false;
            email.Visible = false;
            password.Visible = false;
            login.Visible = false;
            create.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class CustomerLoggedInEventArgs : EventArgs
    {
        public string FirstName { get; }
        public int CustomerId { get; }

        public CustomerLoggedInEventArgs(string firstName, int customerId)
        {
            FirstName = firstName;
            CustomerId = customerId;
        }
    }
}
