using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class AddEditAccessory : Form
    {
        private int accessoryId;

        public AddEditAccessory(int id = 0)
        {
            InitializeComponent();
            accessoryId = id;
            if (accessoryId > 0)
            {
                LoadAccessoryDetails();
            }
        }

        private void LoadAccessoryDetails()
        {
            // Retrieve the accessory details from the database using the accessoryId
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Accessories WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", accessoryId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        txtImageUrl.Text = reader["ImageUrl"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading accessory details: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save or update the accessory details in the database
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (accessoryId > 0)
                    {
                        query = "UPDATE Accessories SET Name = @name, Description = @description, Price = @price, ImageUrl = @imageUrl WHERE Id = @id";
                    }
                    else
                    {
                        query = "INSERT INTO Accessories (Name, Description, Price, ImageUrl) VALUES (@name, @description, @price, @imageUrl)";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@imageUrl", txtImageUrl.Text);
                    if (accessoryId > 0)
                    {
                        cmd.Parameters.AddWithValue("@id", accessoryId);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessory details saved successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving accessory details: " + ex.Message);
                }
            }
        }

        private void AddEditAccessory_Load(object sender, EventArgs e)
        {

        }
    }
}
