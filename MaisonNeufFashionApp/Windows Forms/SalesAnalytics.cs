using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaisonNeufFashionApp
{
    public partial class SalesAnalytics : Form
    {
        public SalesAnalytics()
        {
            InitializeComponent();
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            string connectionString = "Server=localhost;Database=fashion_accessories_db;User ID=root;Password=;SslMode=none";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProductId, SUM(Quantity) as TotalQuantity, SUM(TotalPrice) as TotalSales FROM Sales GROUP BY ProductId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartSales.Series["Sales"].XValueMember = "ProductId";
                    chartSales.Series["Sales"].YValueMembers = "TotalSales";
                    chartSales.DataSource = dataTable;
                    chartSales.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading sales data: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void SalesAnalytics_Load(object sender, EventArgs e)
        {

        }
    }
}
