using System;
using System.Windows.Forms;

namespace MaisonNeufFashionApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }

        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            Recommendation recommendation = new Recommendation();
            recommendation.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }

        private void btnDiscussionForum_Click(object sender, EventArgs e)
        {
            DiscussionForum discussionForum = new DiscussionForum();
            discussionForum.Show();
        }

        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            CustomerSupport customerSupport = new CustomerSupport();
            customerSupport.Show();
        }
    }
}
