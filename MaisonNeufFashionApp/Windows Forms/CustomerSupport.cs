using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class CustomerSupport : Form
    {
        public CustomerSupport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMessage.Text))
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
                    string query = "INSERT INTO CustomerSupport (Name, Email, Message) VALUES (@name, @Email, @Message)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Message", txtMessage.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your message has been sent successfully. We will get back to you soon.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while sending your message: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMessage.Text = "";
        }

        private void CustomerSupport_Load(object sender, EventArgs e)
        {

        }
    }
}
