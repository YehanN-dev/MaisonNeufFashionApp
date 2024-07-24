using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Orders";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewOrders.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["OrderId"].ToString());
                        item.SubItems.Add(reader["UserId"].ToString());
                        item.SubItems.Add(reader["OrderDate"].ToString());
                        item.SubItems.Add(reader["TotalAmount"].ToString());
                        listViewOrders.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading orders: " + ex.Message);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtTotalAmount.Text))
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
                    string query = "INSERT INTO Orders (UserId, OrderDate, TotalAmount) VALUES (@userId, @orderDate, @totalAmount)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", txtUserId.Text);
                    cmd.Parameters.AddWithValue("@orderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@totalAmount", txtTotalAmount.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully.");
                    ClearFields();
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the order: " + ex.Message);
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                string orderId = listViewOrders.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Orders WHERE OrderId = @orderId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order deleted successfully.");
                        LoadOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the order: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        private void ClearFields()
        {
            txtUserId.Text = "";
            txtTotalAmount.Text = "";
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
