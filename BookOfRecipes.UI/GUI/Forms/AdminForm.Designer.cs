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
            this.SuspendLayout();
            // 
            // panelWithUserAccounts
            // 
            this.panelWithUserAccounts.Location = new System.Drawing.Point(3, 32);
            this.panelWithUserAccounts.Name = "panelWithUserAccounts";
            this.panelWithUserAccounts.Size = new System.Drawing.Size(442, 117);
            this.panelWithUserAccounts.TabIndex = 0;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(370, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(275, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(89, 23);
            this.btnPreviousPage.TabIndex = 2;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.Location = new System.Drawing.Point(3, 3);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshForm.TabIndex = 3;
            this.btnRefreshForm.Text = "Refresh form";
            this.btnRefreshForm.UseVisualStyleBackColor = true;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(224, 7);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 4;
            this.lbPage.Text = "Page: 1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 153);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.btnRefreshForm);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.panelWithUserAccounts);
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
    }
}