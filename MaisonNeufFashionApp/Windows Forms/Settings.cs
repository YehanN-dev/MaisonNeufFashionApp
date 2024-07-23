using System;
using System.Windows.Forms;

namespace MaisonNeufFashionApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabaseConnectionString = txtConnectionString.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved successfully.");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtConnectionString.Text = Properties.Settings.Default.DatabaseConnectionString;
        }
    }
}
