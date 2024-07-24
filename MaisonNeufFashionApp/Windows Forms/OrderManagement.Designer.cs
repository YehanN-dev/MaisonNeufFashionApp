namespace MaisonNeufFashionApp
{
    partial class OrderManagement
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
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeaderOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderId,
            this.columnHeaderUserId,
            this.columnHeaderOrderDate,
            this.columnHeaderTotalAmount});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(30, 30);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(600, 200);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderId
            // 
            this.columnHeaderOrderId.Text = "Order ID";
            this.columnHeaderOrderId.Width = 150;
            // 
            // columnHeaderUserId
            // 
            this.columnHeaderUserId.Text = "User ID";
            this.columnHeaderUserId.Width = 150;
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
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(150, 250);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 22);
            this.txtUserId.TabIndex = 1;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(150, 290);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 22);
            this.txtTotalAmount.TabIndex = 2;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(30, 250);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(55, 16);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User ID:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(30, 290);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(89, 16);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(150, 330);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(300, 330);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // OrderManagement
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.listViewOrders);
            this.Name = "OrderManagement";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderId;
        private System.Windows.Forms.ColumnHeader columnHeaderUserId;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalAmount;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}
