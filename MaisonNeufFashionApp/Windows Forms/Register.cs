using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password, Email) VALUES (@username, @password, @Email)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User registered successfully.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while registering the user: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
