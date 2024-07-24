using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisonNeufFashionApp
{
    public partial class AccessoryDetails : Form
    {
        public AccessoryDetails()
        {
            InitializeComponent();
        }

        public void LoadAccessoryDetails(string name, string description, decimal price, string imageUrl)
        {
            lblName.Text = $"Name: {name}";
            lblDescription.Text = $"Description: {description}";
            lblPrice.Text = $"Price: {price:C}";
            pictureBoxAccessory.ImageLocation = imageUrl;
        }

        private void AccessoryDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
