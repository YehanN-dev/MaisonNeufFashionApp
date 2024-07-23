using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class DiscussionForum : Form
    {
        public DiscussionForum()
        {
            InitializeComponent();
            LoadPosts();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPostTitle.Text) || string.IsNullOrEmpty(txtPostContent.Text))
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
                    string query = "INSERT INTO ForumPosts (Title, Content, DatePosted) VALUES (@title, @content, @datePosted)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtPostTitle.Text);
                    cmd.Parameters.AddWithValue("@content", txtPostContent.Text);
                    cmd.Parameters.AddWithValue("@datePosted", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your post has been submitted successfully.");
                    ClearFields();
                    LoadPosts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while submitting your post: " + ex.Message);
                }
            }
        }

        private void LoadPosts()
        {
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM ForumPosts ORDER BY DatePosted DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    listViewPosts.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(reader["Content"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePosted"]).ToString("g"));
                        listViewPosts.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading posts: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtPostTitle.Text = "";
            txtPostContent.Text = "";
        }
    }
}
