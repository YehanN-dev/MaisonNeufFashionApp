namespace MaisonNeufFashionApp
{
    partial class PromotionManagement
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
            this.listViewPromotions = new System.Windows.Forms.ListView();
            this.columnHeaderPromotionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnAddPromotion = new System.Windows.Forms.Button();
            this.btnDeletePromotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPromotions
            // 
            this.listViewPromotions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPromotionId,
            this.columnHeaderTitle,
            this.columnHeaderDescription,
            this.columnHeaderStartDate,
            this.columnHeaderEndDate});
            this.listViewPromotions.HideSelection = false;
            this.listViewPromotions.Location = new System.Drawing.Point(30, 30);
            this.listViewPromotions.Name = "listViewPromotions";
            this.listViewPromotions.Size = new System.Drawing.Size(700, 200);
            this.listViewPromotions.TabIndex = 0;
            this.listViewPromotions.UseCompatibleStateImageBehavior = false;
            this.listViewPromotions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPromotionId
            // 
            this.columnHeaderPromotionId.Text = "Promotion ID";
            this.columnHeaderPromotionId.Width = 100;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 150;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 250;
            // 
            // columnHeaderStartDate
            // 
            this.columnHeaderStartDate.Text = "Start Date";
            this.columnHeaderStartDate.Width = 100;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "End Date";
            this.columnHeaderEndDate.Width = 100;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 250);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 290);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 100);
            this.txtDescription.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 250);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 290);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(150, 410);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(150, 450);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 6;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(30, 410);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(30, 450);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 17);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnAddPromotion
            // 
            this.btnAddPromotion.Location = new System.Drawing.Point(150, 490);
            this.btnAddPromotion.Name = "btnAddPromotion";
            this.btnAddPromotion.Size = new System.Drawing.Size(100, 30);
            this.btnAddPromotion.TabIndex = 9;
            this.btnAddPromotion.Text = "Add";
            this.btnAddPromotion.UseVisualStyleBackColor = true;
            this.btnAddPromotion.Click += new System.EventHandler(this.btnAddPromotion_Click);
            // 
            // btnDeletePromotion
            // 
            this.btnDeletePromotion.Location = new System.Drawing.Point(300, 490);
            this.btnDeletePromotion.Name = "btnDeletePromotion";
            this.btnDeletePromotion.Size = new System.Drawing.Size(100, 30);
            this.btnDeletePromotion.TabIndex = 10;
            this.btnDeletePromotion.Text = "Delete";
            this.btnDeletePromotion.UseVisualStyleBackColor = true;
            this.btnDeletePromotion.Click += new System.EventHandler(this.btnDeletePromotion_Click);
            // 
            // PromotionManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnDeletePromotion);
            this.Controls.Add(this.btnAddPromotion);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.listViewPromotions);
            this.Name = "PromotionManagement";
            this.Text = "Promotion Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listViewPromotions;
        private System.Windows.Forms.ColumnHeader columnHeaderPromotionId;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnAddPromotion;
        private System.Windows.Forms.Button btnDeletePromotion;
    }
}