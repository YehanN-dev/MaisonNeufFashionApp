using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewUsers.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["UserId"].ToString());
                        item.SubItems.Add(reader["Username"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Role"].ToString());
                        listViewUsers.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading users: " + ex.Message);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(cmbRole.Text))
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
                    string query = "INSERT INTO Users (Username, Email, Password, Role) VALUES (@username, @Email, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                    ClearFields();
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the user: " + ex.Message);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                string userId = listViewUsers.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE UserId = @userId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully.");
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ClearFields()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
