using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class Recommendation : Form
    {
        public Recommendation()
        {
            InitializeComponent();
            LoadRecommendations();
        }

        private void LoadRecommendations()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Accessories WHERE Tags LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tags", "%" + GetTags() + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewRecommendations.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["AccessoryId"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(reader["Price"].ToString());
                        item.SubItems.Add(reader["Tags"].ToString());
                        listViewRecommendations.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading recommendations: " + ex.Message);
                }
            }
        }

        private string GetTags()
        {
            // Dummy method to get tags based on user preferences, mood, etc.
            // You should replace this with your actual logic to get relevant tags
            return "elegant,classy";
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            LoadRecommendations();
        }

        private void listViewRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
