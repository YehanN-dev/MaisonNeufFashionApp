namespace MaisonNeufFashionApp
{
    partial class Cart
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
            this.cartListView = new System.Windows.Forms.ListView();
            this.columnHeaderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartListView
            // 
            this.cartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItemName,
            this.columnHeaderQuantity,
            this.columnHeaderPrice});
            this.cartListView.HideSelection = false;
            this.cartListView.Location = new System.Drawing.Point(12, 12);
            this.cartListView.Name = "cartListView";
            this.cartListView.Size = new System.Drawing.Size(400, 200);
            this.cartListView.TabIndex = 0;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.SelectedIndexChanged += new System.EventHandler(this.cartListView_SelectedIndexChanged);
            // 
            // columnHeaderItemName
            // 
            this.columnHeaderItemName.Text = "Item Name";
            this.columnHeaderItemName.Width = 150;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.Width = 100;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 100;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(430, 20);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 30);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(430, 70);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Cart
            // 
            this.ClientSize = new System.Drawing.Size(550, 230);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.cartListView);
            this.Name = "Cart";
            this.Text = "Shopping Cart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView cartListView;
        private System.Windows.Forms.ColumnHeader columnHeaderItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}
