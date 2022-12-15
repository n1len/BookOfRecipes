namespace BookOfRecipes.UI.GUI.Forms
{
    partial class RecipesInBookForm
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
            this.btnRefreshForm = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.recipesInBookPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.Location = new System.Drawing.Point(455, 12);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshForm.TabIndex = 0;
            this.btnRefreshForm.Text = "Refresh form";
            this.btnRefreshForm.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(463, 91);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(365, 91);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(92, 23);
            this.btnPreviousPage.TabIndex = 2;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.Location = new System.Drawing.Point(12, 92);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(123, 23);
            this.btnCreateRecipe.TabIndex = 3;
            this.btnCreateRecipe.Text = "Create recipe";
            this.btnCreateRecipe.UseVisualStyleBackColor = true;
            // 
            // recipesInBookPanel
            // 
            this.recipesInBookPanel.Location = new System.Drawing.Point(12, 120);
            this.recipesInBookPanel.Name = "recipesInBookPanel";
            this.recipesInBookPanel.Size = new System.Drawing.Size(526, 152);
            this.recipesInBookPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 23);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTitle.Size = new System.Drawing.Size(136, 63);
            this.tbTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(165, 23);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescription.Size = new System.Drawing.Size(284, 63);
            this.tbDescription.TabIndex = 8;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(314, 95);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 9;
            this.lbPage.Text = "Page: 1";
            // 
            // RecipesInBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 284);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipesInBookPanel);
            this.Controls.Add(this.btnCreateRecipe);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnRefreshForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecipesInBookForm";
            this.Text = "RecipesInBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRefreshForm;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Button btnCreateRecipe;
        private FlowLayoutPanel recipesInBookPanel;
        private Label label1;
        private TextBox tbTitle;
        private Label label2;
        private TextBox tbDescription;
        private Label lbPage;
    }
}