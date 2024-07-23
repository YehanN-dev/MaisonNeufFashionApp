using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class PromotionManagement : Form
    {
        public PromotionManagement()
        {
            InitializeComponent();
            LoadPromotions();
        }

        private void LoadPromotions()
        {
            string connectionString = "your_connection_string_here";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Promotions";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewPromotions.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["PromotionId"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(reader["Description"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["StartDate"]).ToString("d"));
                        item.SubItems.Add(Convert.ToDateTime(reader["EndDate"]).ToString("d"));
                        listViewPromotions.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading promotions: " + ex.Message);
                }
            }
        }

        private void btnAddPromotion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(dtpStartDate.Text) || string.IsNullOrEmpty(dtpEndDate.Text))
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
                    string query = "INSERT INTO Promotions (Title, Description, StartDate, EndDate) VALUES (@title, @description, @startDate, @endDate)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Promotion added successfully.");
                    ClearFields();
                    LoadPromotions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the promotion: " + ex.Message);
                }
            }
        }

        private void btnDeletePromotion_Click(object sender, EventArgs e)
        {
            if (listViewPromotions.SelectedItems.Count > 0)
            {
                string promotionId = listViewPromotions.SelectedItems[0].Text;

                string connectionString = "your_connection_string_here";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Promotions WHERE PromotionId = @promotionId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@promotionId", promotionId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Promotion deleted successfully.");
                        LoadPromotions();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the promotion: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a promotion to delete.");
            }
        }

        private void ClearFields()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
    }
}
