using System;
using System.Windows.Forms;

namespace MaisonNeufFashionApp
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            SalesAnalytics salesAnalytics = new SalesAnalytics();
            salesAnalytics.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
