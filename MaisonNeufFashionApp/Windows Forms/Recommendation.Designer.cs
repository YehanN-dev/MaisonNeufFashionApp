namespace MaisonNeufFashionApp
{
    partial class Recommendation
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
            this.listViewRecommendations = new System.Windows.Forms.ListView();
            this.columnHeaderAccessoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRecommend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRecommendations
            // 
            this.listViewRecommendations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAccessoryId,
            this.columnHeaderName,
            this.columnHeaderCategory,
            this.columnHeaderPrice,
            this.columnHeaderTags});
            this.listViewRecommendations.HideSelection = false;
            this.listViewRecommendations.Location = new System.Drawing.Point(30, 30);
            this.listViewRecommendations.Name = "listViewRecommendations";
            this.listViewRecommendations.Size = new System.Drawing.Size(700, 200);
            this.listViewRecommendations.TabIndex = 0;
            this.listViewRecommendations.UseCompatibleStateImageBehavior = false;
            this.listViewRecommendations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAccessoryId
            // 
            this.columnHeaderAccessoryId.Text = "Accessory ID";
            this.columnHeaderAccessoryId.Width = 100;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 150;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 100;
            // 
            // columnHeaderTags
            // 
            this.columnHeaderTags.Text = "Tags";
            this.columnHeaderTags.Width = 200;
            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(30, 250);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(100, 30);
            this.btnRecommend.TabIndex = 1;
            this.btnRecommend.Text = "Recommend";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // Recommendation
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.listViewRecommendations);
            this.Name = "Recommendation";
            this.Text = "Recommendation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRecommendations;
        private System.Windows.Forms.ColumnHeader columnHeaderAccessoryId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderTags;
        private System.Windows.Forms.Button btnRecommend;
    }
}
