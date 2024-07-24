namespace MaisonNeufFashionApp
{
    partial class Wishlist
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
            this.listViewWishlist = new System.Windows.Forms.ListView();
            this.columnHeaderWishlistId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddToWishlist = new System.Windows.Forms.Button();
            this.btnRemoveFromWishlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewWishlist
            // 
            this.listViewWishlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderWishlistId,
            this.columnHeaderProductId,
            this.columnHeaderProductName,
            this.columnHeaderAddedAt});
            this.listViewWishlist.HideSelection = false;
            this.listViewWishlist.Location = new System.Drawing.Point(30, 30);
            this.listViewWishlist.Name = "listViewWishlist";
            this.listViewWishlist.Size = new System.Drawing.Size(700, 200);
            this.listViewWishlist.TabIndex = 0;
            this.listViewWishlist.UseCompatibleStateImageBehavior = false;
            this.listViewWishlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderWishlistId
            // 
            this.columnHeaderWishlistId.Text = "Wishlist ID";
            this.columnHeaderWishlistId.Width = 100;
            // 
            // columnHeaderProductId
            // 
            this.columnHeaderProductId.Text = "Product ID";
            this.columnHeaderProductId.Width = 100;
            // 
            // columnHeaderProductName
            // 
            this.columnHeaderProductName.Text = "Product Name";
            this.columnHeaderProductName.Width = 200;
            // 
            // columnHeaderAddedAt
            // 
            this.columnHeaderAddedAt.Text = "Added At";
            this.columnHeaderAddedAt.Width = 200;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(150, 250);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 22);
            this.txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(150, 290);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(30, 250);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(72, 16);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "Product ID:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(30, 290);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name:";
            // 
            // btnAddToWishlist
            // 
            this.btnAddToWishlist.Location = new System.Drawing.Point(150, 330);
            this.btnAddToWishlist.Name = "btnAddToWishlist";
            this.btnAddToWishlist.Size = new System.Drawing.Size(100, 30);
            this.btnAddToWishlist.TabIndex = 5;
            this.btnAddToWishlist.Text = "Add to Wishlist";
            this.btnAddToWishlist.UseVisualStyleBackColor = true;
            this.btnAddToWishlist.Click += new System.EventHandler(this.btnAddToWishlist_Click);
            // 
            // btnRemoveFromWishlist
            // 
            this.btnRemoveFromWishlist.Location = new System.Drawing.Point(300, 330);
            this.btnRemoveFromWishlist.Name = "btnRemoveFromWishlist";
            this.btnRemoveFromWishlist.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveFromWishlist.TabIndex = 6;
            this.btnRemoveFromWishlist.Text = "Remove";
            this.btnRemoveFromWishlist.UseVisualStyleBackColor = true;
            this.btnRemoveFromWishlist.Click += new System.EventHandler(this.btnRemoveFromWishlist_Click);
            // 
            // Wishlist
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnRemoveFromWishlist);
            this.Controls.Add(this.btnAddToWishlist);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.listViewWishlist);
            this.Name = "Wishlist";
            this.Text = "Wishlist";
            this.Load += new System.EventHandler(this.Wishlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewWishlist;
        private System.Windows.Forms.ColumnHeader columnHeaderWishlistId;
        private System.Windows.Forms.ColumnHeader columnHeaderProductId;
        private System.Windows.Forms.ColumnHeader columnHeaderProductName;
        private System.Windows.Forms.ColumnHeader columnHeaderAddedAt;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddToWishlist;
        private System.Windows.Forms.Button btnRemoveFromWishlist;
    }
}
