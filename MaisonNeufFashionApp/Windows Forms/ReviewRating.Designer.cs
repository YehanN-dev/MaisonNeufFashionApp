namespace MaisonNeufFashionApp
{
    partial class ReviewRating
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
            this.listViewReviews = new System.Windows.Forms.ListView();
            this.columnHeaderReviewId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReviewText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtReviewText = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReviewText = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewReviews
            // 
            this.listViewReviews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderReviewId,
            this.columnHeaderUserId,
            this.columnHeaderProductId,
            this.columnHeaderRating,
            this.columnHeaderReviewText});
            this.listViewReviews.HideSelection = false;
            this.listViewReviews.Location = new System.Drawing.Point(30, 30);
            this.listViewReviews.Name = "listViewReviews";
            this.listViewReviews.Size = new System.Drawing.Size(700, 200);
            this.listViewReviews.TabIndex = 0;
            this.listViewReviews.UseCompatibleStateImageBehavior = false;
            this.listViewReviews.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderReviewId
            // 
            this.columnHeaderReviewId.Text = "Review ID";
            this.columnHeaderReviewId.Width = 100;
            // 
            // columnHeaderUserId
            // 
            this.columnHeaderUserId.Text = "User ID";
            this.columnHeaderUserId.Width = 100;
            // 
            // columnHeaderProductId
            // 
            this.columnHeaderProductId.Text = "Product ID";
            this.columnHeaderProductId.Width = 100;
            // 
            // columnHeaderRating
            // 
            this.columnHeaderRating.Text = "Rating";
            this.columnHeaderRating.Width = 100;
            // 
            // columnHeaderReviewText
            // 
            this.columnHeaderReviewText.Text = "Review Text";
            this.columnHeaderReviewText.Width = 300;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(150, 250);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 22);
            this.txtUserId.TabIndex = 1;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(150, 290);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 22);
            this.txtProductId.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(150, 330);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(200, 22);
            this.txtRating.TabIndex = 3;
            // 
            // txtReviewText
            // 
            this.txtReviewText.Location = new System.Drawing.Point(150, 370);
            this.txtReviewText.Multiline = true;
            this.txtReviewText.Name = "txtReviewText";
            this.txtReviewText.Size = new System.Drawing.Size(200, 100);
            this.txtReviewText.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(30, 250);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(58, 17);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User ID:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(30, 290);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(78, 17);
            this.lblProductId.TabIndex = 6;
            this.lblProductId.Text = "Product ID:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(30, 330);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(56, 17);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Rating:";
            // 
            // lblReviewText
            // 
            this.lblReviewText.AutoSize = true;
            this.lblReviewText.Location = new System.Drawing.Point(30, 370);
            this.lblReviewText.Name = "lblReviewText";
            this.lblReviewText.Size = new System.Drawing.Size(88, 17);
            this.lblReviewText.TabIndex = 8;
            this.lblReviewText.Text = "Review Text:";
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(150, 490);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(100, 30);
            this.btnAddReview.TabIndex = 9;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(300, 490);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteReview.TabIndex = 10;
            this.btnDeleteReview.Text = "Delete Review";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // ReviewRating
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.lblReviewText);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtReviewText);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.listViewReviews);
            this.Name = "ReviewRating";
            this.Text = "Review Rating";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listViewReviews;
        private System.Windows.Forms.ColumnHeader columnHeaderReviewId;
        private System.Windows.Forms.ColumnHeader columnHeaderUserId;
        private System.Windows.Forms.ColumnHeader columnHeaderProductId;
        private System.Windows.Forms.ColumnHeader columnHeaderRating;
        private System.Windows.Forms.ColumnHeader columnHeaderReviewText;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtReviewText;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblReviewText;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnDeleteReview;
    }
}
