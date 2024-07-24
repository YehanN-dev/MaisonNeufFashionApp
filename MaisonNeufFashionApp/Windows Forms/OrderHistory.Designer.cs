namespace MaisonNeufFashionApp
{
    partial class OrderHistory
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
            this.listViewOrderHistory = new System.Windows.Forms.ListView();
            this.columnHeaderOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOrderHistory
            // 
            this.listViewOrderHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderId,
            this.columnHeaderOrderDate,
            this.columnHeaderTotalAmount});
            this.listViewOrderHistory.HideSelection = false;
            this.listViewOrderHistory.Location = new System.Drawing.Point(30, 30);
            this.listViewOrderHistory.Name = "listViewOrderHistory";
            this.listViewOrderHistory.Size = new System.Drawing.Size(600, 400);
            this.listViewOrderHistory.TabIndex = 0;
            this.listViewOrderHistory.UseCompatibleStateImageBehavior = false;
            this.listViewOrderHistory.View = System.Windows.Forms.View.Details;
            this.listViewOrderHistory.SelectedIndexChanged += new System.EventHandler(this.listViewOrderHistory_SelectedIndexChanged);
            // 
            // columnHeaderOrderId
            // 
            this.columnHeaderOrderId.Text = "Order ID";
            this.columnHeaderOrderId.Width = 150;
            // 
            // columnHeaderOrderDate
            // 
            this.columnHeaderOrderDate.Text = "Order Date";
            this.columnHeaderOrderDate.Width = 150;
            // 
            // columnHeaderTotalAmount
            // 
            this.columnHeaderTotalAmount.Text = "Total Amount";
            this.columnHeaderTotalAmount.Width = 150;
            // 
            // OrderHistory
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.listViewOrderHistory);
            this.Name = "OrderHistory";
            this.Text = "Order History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderId;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalAmount;
    }
}
