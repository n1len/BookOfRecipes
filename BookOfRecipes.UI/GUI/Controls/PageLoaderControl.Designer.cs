namespace BookOfRecipes.UI.GUI.Controls
{
    partial class PageLoaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.btnRefreshPage = new System.Windows.Forms.Button();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLoaderItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(408, 0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = "Next page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(312, 0);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(90, 23);
            this.btnPreviousPage.TabIndex = 1;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Location = new System.Drawing.Point(261, 4);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(45, 15);
            this.lbPageNumber.TabIndex = 2;
            this.lbPageNumber.Text = "Page: 1";
            // 
            // btnRefreshPage
            // 
            this.btnRefreshPage.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshPage.Name = "btnRefreshPage";
            this.btnRefreshPage.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPage.TabIndex = 3;
            this.btnRefreshPage.Text = "Refresh";
            this.btnRefreshPage.UseVisualStyleBackColor = true;
            // 
            // itemsPanel
            // 
            this.itemsPanel.Location = new System.Drawing.Point(3, 47);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(477, 140);
            this.itemsPanel.TabIndex = 4;
            // 
            // lbLoaderItemName
            // 
            this.lbLoaderItemName.AutoSize = true;
            this.lbLoaderItemName.Location = new System.Drawing.Point(208, 29);
            this.lbLoaderItemName.Name = "lbLoaderItemName";
            this.lbLoaderItemName.Size = new System.Drawing.Size(74, 15);
            this.lbLoaderItemName.TabIndex = 5;
            this.lbLoaderItemName.Text = "Item on load";
            // 
            // PageLoaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLoaderItemName);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.btnRefreshPage);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Name = "PageLoaderControl";
            this.Size = new System.Drawing.Size(483, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNextPage;
        private Button btnPreviousPage;
        private Label lbPageNumber;
        private Button btnRefreshPage;
        private FlowLayoutPanel itemsPanel;
        private Label lbLoaderItemName;
    }
}
