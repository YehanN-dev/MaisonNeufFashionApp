using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class ReviewRating : Form
    {
        public ReviewRating()
        {
            InitializeComponent();
            LoadReviews();
        }

        private void LoadReviews()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reviews";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewReviews.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ReviewId"].ToString());
                        item.SubItems.Add(reader["UserId"].ToString());
                        item.SubItems.Add(reader["ProductId"].ToString());
                        item.SubItems.Add(reader["Rating"].ToString());
                        item.SubItems.Add(reader["ReviewText"].ToString());
                        listViewReviews.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading reviews: " + ex.Message);
                }
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtProductId.Text) || string.IsNullOrEmpty(txtRating.Text) || string.IsNullOrEmpty(txtReviewText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Reviews (UserId, ProductId, Rating, ReviewText) VALUES (@userId, @productId, @rating, @reviewText)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", txtUserId.Text);
                    cmd.Parameters.AddWithValue("@productId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@rating", txtRating.Text);
                    cmd.Parameters.AddWithValue("@reviewText", txtReviewText.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Review added successfully.");
                    ClearFields();
                    LoadReviews();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the review: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtUserId.Text = "";
            txtProductId.Text = "";
            txtRating.Text = "";
            txtReviewText.Text = "";
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (listViewReviews.SelectedItems.Count > 0)
            {
                string reviewId = listViewReviews.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Reviews WHERE ReviewId = @reviewId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@reviewId", reviewId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Review deleted successfully.");
                        LoadReviews();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the review: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review to delete.");
            }
        }

        private void ReviewRating_Load(object sender, EventArgs e)
        {

        }
    }
}
