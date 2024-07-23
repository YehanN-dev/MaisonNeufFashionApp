namespace MaisonNeufFashionApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnRecommendations = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnDiscussionForum = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(50, 30);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(150, 30);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnRecommendations
            // 
            this.btnRecommendations.Location = new System.Drawing.Point(50, 70);
            this.btnRecommendations.Name = "btnRecommendations";
            this.btnRecommendations.Size = new System.Drawing.Size(150, 30);
            this.btnRecommendations.TabIndex = 1;
            this.btnRecommendations.Text = "Recommendations";
            this.btnRecommendations.UseVisualStyleBackColor = true;
            this.btnRecommendations.Click += new System.EventHandler(this.btnRecommendations_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(50, 110);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(150, 30);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnDiscussionForum
            // 
            this.btnDiscussionForum.Location = new System.Drawing.Point(50, 150);
            this.btnDiscussionForum.Name = "btnDiscussionForum";
            this.btnDiscussionForum.Size = new System.Drawing.Size(150, 30);
            this.btnDiscussionForum.TabIndex = 3;
            this.btnDiscussionForum.Text = "Discussion Forum";
            this.btnDiscussionForum.UseVisualStyleBackColor = true;
            this.btnDiscussionForum.Click += new System.EventHandler(this.btnDiscussionForum_Click);
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.Location = new System.Drawing.Point(50, 190);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(150, 30);
            this.btnCustomerSupport.TabIndex = 4;
            this.btnCustomerSupport.Text = "Customer Support";
            this.btnCustomerSupport.UseVisualStyleBackColor = true;
            this.btnCustomerSupport.Click += new System.EventHandler(this.btnCustomerSupport_Click);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnCustomerSupport);
            this.Controls.Add(this.btnDiscussionForum);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnRecommendations);
            this.Controls.Add(this.btnProfile);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRecommendations;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnDiscussionForum;
        private System.Windows.Forms.Button btnCustomerSupport;
    }
}
