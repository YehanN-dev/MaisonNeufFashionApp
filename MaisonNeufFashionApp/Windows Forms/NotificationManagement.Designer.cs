namespace MaisonNeufFashionApp
{
    partial class NotificationManagement
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
            this.listViewNotifications = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddNotification = new System.Windows.Forms.Button();
            this.btnDeleteNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewNotifications
            // 
            this.listViewNotifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderMessage,
            this.columnHeaderDateCreated});
            this.listViewNotifications.HideSelection = false;
            this.listViewNotifications.Location = new System.Drawing.Point(30, 30);
            this.listViewNotifications.Name = "listViewNotifications";
            this.listViewNotifications.Size = new System.Drawing.Size(600, 200);
            this.listViewNotifications.TabIndex = 0;
            this.listViewNotifications.UseCompatibleStateImageBehavior = false;
            this.listViewNotifications.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 150;
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Text = "Message";
            this.columnHeaderMessage.Width = 300;
            // 
            // columnHeaderDateCreated
            // 
            this.columnHeaderDateCreated.Text = "Date Created";
            this.columnHeaderDateCreated.Width = 150;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 250);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(150, 290);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(200, 100);
            this.txtMessage.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 250);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 290);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 16);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Message:";
            // 
            // btnAddNotification
            // 
            this.btnAddNotification.Location = new System.Drawing.Point(150, 410);
            this.btnAddNotification.Name = "btnAddNotification";
            this.btnAddNotification.Size = new System.Drawing.Size(100, 30);
            this.btnAddNotification.TabIndex = 5;
            this.btnAddNotification.Text = "Add";
            this.btnAddNotification.UseVisualStyleBackColor = true;
            this.btnAddNotification.Click += new System.EventHandler(this.btnAddNotification_Click);
            // 
            // btnDeleteNotification
            // 
            this.btnDeleteNotification.Location = new System.Drawing.Point(300, 410);
            this.btnDeleteNotification.Name = "btnDeleteNotification";
            this.btnDeleteNotification.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteNotification.TabIndex = 6;
            this.btnDeleteNotification.Text = "Delete";
            this.btnDeleteNotification.UseVisualStyleBackColor = true;
            this.btnDeleteNotification.Click += new System.EventHandler(this.btnDeleteNotification_Click);
            // 
            // NotificationManagement
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnDeleteNotification);
            this.Controls.Add(this.btnAddNotification);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.listViewNotifications);
            this.Name = "NotificationManagement";
            this.Text = "Notification Management";
            this.Load += new System.EventHandler(this.NotificationManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNotifications;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        private System.Windows.Forms.ColumnHeader columnHeaderDateCreated;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddNotification;
        private System.Windows.Forms.Button btnDeleteNotification;
    }
}
