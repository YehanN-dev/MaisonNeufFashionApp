using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MaisonNeufFashionApp
{
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            string currentUser = SessionManager.CurrentUser;
            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("No user logged in.");
                return;
            }

            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Orders WHERE UserId = @userId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", currentUser);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewOrderHistory.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["OrderId"].ToString());
                        item.SubItems.Add(reader["ProductName"].ToString());
                        item.SubItems.Add(reader["OrderDate"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(reader["TotalPrice"].ToString());
                        listViewOrderHistory.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading order history: " + ex.Message);
                }
            }
        }
    }
}
