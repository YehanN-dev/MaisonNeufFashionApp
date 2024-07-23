using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class Wishlist : Form
    {
        public Wishlist()
        {
            InitializeComponent();
            LoadWishlist();
        }

        private void LoadWishlist()
        {
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Wishlist WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", Properties.Settings.Default.UserId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewWishlist.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["WishlistId"].ToString());
                        item.SubItems.Add(reader["ProductId"].ToString());
                        item.SubItems.Add(reader["ProductName"].ToString());
                        item.SubItems.Add(reader["AddedAt"].ToString());
                        listViewWishlist.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the wishlist: " + ex.Message);
                }
            }
        }

        private void btnAddToWishlist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please enter a product ID.");
                return;
            }

            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Wishlist (UserId, ProductId, ProductName) VALUES (@userId, @productId, @productName)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", Properties.Settings.Default.UserId);
                    cmd.Parameters.AddWithValue("@productId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added to wishlist successfully.");
                    ClearFields();
                    LoadWishlist();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the product to the wishlist: " + ex.Message);
                }
            }
        }

        private void btnRemoveFromWishlist_Click(object sender, EventArgs e)
        {
            if (listViewWishlist.SelectedItems.Count > 0)
            {
                string wishlistId = listViewWishlist.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Wishlist WHERE WishlistId = @wishlistId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@wishlistId", wishlistId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product removed from wishlist successfully.");
                        LoadWishlist();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while removing the product from the wishlist: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove from the wishlist.");
            }
        }

        private void ClearFields()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
        }
    }
}
