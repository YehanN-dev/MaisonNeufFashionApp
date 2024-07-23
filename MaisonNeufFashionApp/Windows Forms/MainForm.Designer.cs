namespace MaisonNeufFashionApp
{
    partial class MainForm
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(50, 30);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 30);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(50, 70);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(150, 30);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.Location = new System.Drawing.Point(50, 110);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(150, 30);
            this.btnCustomerSupport.TabIndex = 2;
            this.btnCustomerSupport.Text = "Customer Support";
            this.btnCustomerSupport.UseVisualStyleBackColor = true;
            this.btnCustomerSupport.Click += new System.EventHandler(this.btnCustomerSupport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 150);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCustomerSupport);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnDashboard);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCustomerSupport;
        private System.Windows.Forms.Button btnLogout;
    }
}
