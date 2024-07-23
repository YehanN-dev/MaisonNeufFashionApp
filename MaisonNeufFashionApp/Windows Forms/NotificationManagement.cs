using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class NotificationManagement : Form
    {
        public NotificationManagement()
        {
            InitializeComponent();
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Notifications";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewNotifications.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(reader["Message"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["DateCreated"]).ToString("g"));
                        listViewNotifications.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading notifications: " + ex.Message);
                }
            }
        }

        private void btnAddNotification_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtMessage.Text))
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
                    string query = "INSERT INTO Notifications (Title, Message, DateCreated) VALUES (@title, @message, @dateCreated)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@message", txtMessage.Text);
                    cmd.Parameters.AddWithValue("@dateCreated", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Notification added successfully.");
                    ClearFields();
                    LoadNotifications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the notification: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtMessage.Text = "";
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            if (listViewNotifications.SelectedItems.Count > 0)
            {
                string title = listViewNotifications.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Notifications WHERE Title = @title";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Notification deleted successfully.");
                        LoadNotifications();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the notification: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a notification to delete.");
            }
        }
    }
}
