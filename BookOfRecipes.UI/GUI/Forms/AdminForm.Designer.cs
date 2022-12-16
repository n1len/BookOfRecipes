namespace BookOfRecipes.UI.GUI.Forms
{
    partial class AdminForm
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
            this.panelWithUserAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnRefreshForm = new System.Windows.Forms.Button();
            this.lbPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCollectionIsEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelWithUserAccounts
            // 
            this.panelWithUserAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWithUserAccounts.Location = new System.Drawing.Point(3, 32);
            this.panelWithUserAccounts.Name = "panelWithUserAccounts";
            this.panelWithUserAccounts.Size = new System.Drawing.Size(417, 167);
            this.panelWithUserAccounts.TabIndex = 0;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextPage.Location = new System.Drawing.Point(345, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreviousPage.Location = new System.Drawing.Point(250, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(89, 23);
            this.btnPreviousPage.TabIndex = 2;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshForm.Location = new System.Drawing.Point(3, 3);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshForm.TabIndex = 3;
            this.btnRefreshForm.Text = "Refresh form";
            this.btnRefreshForm.UseVisualStyleBackColor = false;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(199, 7);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 4;
            this.lbPage.Text = "Page: 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Users";
            // 
            // lbCollectionIsEmpty
            // 
            this.lbCollectionIsEmpty.AutoSize = true;
            this.lbCollectionIsEmpty.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCollectionIsEmpty.Location = new System.Drawing.Point(99, 9);
            this.lbCollectionIsEmpty.Name = "lbCollectionIsEmpty";
            this.lbCollectionIsEmpty.Size = new System.Drawing.Size(135, 19);
            this.lbCollectionIsEmpty.TabIndex = 6;
            this.lbCollectionIsEmpty.Text = "Collection is empty.";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 203);
            this.Controls.Add(this.lbCollectionIsEmpty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.btnRefreshForm);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.panelWithUserAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel panelWithUserAccounts;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Button btnRefreshForm;
        private Label lbPage;
        private Label label1;
        private Label lbCollectionIsEmpty;
    }
}