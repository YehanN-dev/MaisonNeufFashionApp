using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM CartItems WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", GetCurrentUserId());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ItemName"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(reader["Price"].ToString());
                        cartListView.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading cart items: " + ex.Message);
                }
            }
        }

        private int GetCurrentUserId()
        {
            // Placeholder method to get the current user's ID
            return 1; // Replace with actual user ID retrieval logic
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Handle checkout process
            MessageBox.Show("Checkout process initiated.");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (cartListView.SelectedItems.Count > 0)
            {
                string itemName = cartListView.SelectedItems[0].Text;
                RemoveCartItem(itemName);
                cartListView.Items.Remove(cartListView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void RemoveCartItem(string itemName)
        {
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM CartItems WHERE UserId = @userId AND ItemName = @itemName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", GetCurrentUserId());
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing the item: " + ex.Message);
                }
            }
        }

        private void cartListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
