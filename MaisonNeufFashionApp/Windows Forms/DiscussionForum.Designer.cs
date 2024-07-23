namespace MaisonNeufFashionApp
{
    partial class DiscussionForum
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
            this.txtPostTitle = new System.Windows.Forms.TextBox();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.lblPostTitle = new System.Windows.Forms.Label();
            this.lblPostContent = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDatePosted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtPostTitle
            // 
            this.txtPostTitle.Location = new System.Drawing.Point(150, 30);
            this.txtPostTitle.Name = "txtPostTitle";
            this.txtPostTitle.Size = new System.Drawing.Size(200, 22);
            this.txtPostTitle.TabIndex = 0;
            // 
            // txtPostContent
            // 
            this.txtPostContent.Location = new System.Drawing.Point(150, 70);
            this.txtPostContent.Multiline = true;
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.Size = new System.Drawing.Size(200, 100);
            this.txtPostContent.TabIndex = 1;
            // 
            // lblPostTitle
            // 
            this.lblPostTitle.AutoSize = true;
            this.lblPostTitle.Location = new System.Drawing.Point(30, 30);
            this.lblPostTitle.Name = "lblPostTitle";
            this.lblPostTitle.Size = new System.Drawing.Size(70, 17);
            this.lblPostTitle.TabIndex = 2;
            this.lblPostTitle.Text = "Post Title:";
            // 
            // lblPostContent
            // 
            this.lblPostContent.AutoSize = true;
            this.lblPostContent.Location = new System.Drawing.Point(30, 70);
            this.lblPostContent.Name = "lblPostContent";
            this.lblPostContent.Size = new System.Drawing.Size(92, 17);
            this.lblPostContent.TabIndex = 3;
            this.lblPostContent.Text = "Post Content:";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(150, 190);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(100, 30);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // listViewPosts
            // 
            this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderContent,
            this.columnHeaderDatePosted});
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.Location = new System.Drawing.Point(30, 230);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(600, 200);
            this.listViewPosts.TabIndex = 5;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 150;
            // 
            // columnHeaderContent
            // 
            this.columnHeaderContent.Text = "Content";
            this.columnHeaderContent.Width = 300;
            // 
            // columnHeaderDatePosted
            // 
            this.columnHeaderDatePosted.Text = "Date Posted";
            this.columnHeaderDatePosted.Width = 150;
            // 
            // DiscussionForum
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.listViewPosts);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblPostContent);
            this.Controls.Add(this.lblPostTitle);
            this.Controls.Add(this.txtPostContent);
            this.Controls.Add(this.txtPostTitle);
            this.Name = "DiscussionForum";
            this.Text = "Discussion Forum";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPostTitle;
        private System.Windows.Forms.TextBox txtPostContent;
        private System.Windows.Forms.Label lblPostTitle;
        private System.Windows.Forms.Label lblPostContent;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderContent;
        private System.Windows.Forms.ColumnHeader columnHeaderDatePosted;
    }
}
