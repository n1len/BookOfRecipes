namespace BookOfRecipes.UI.GUI.Forms
{
    partial class MainMenuForm
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
            this.btnToUserAccount = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbWelcomeMessage = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCollectionIsEmpty = new System.Windows.Forms.Label();
            this.btnRefreshForm = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lbPage = new System.Windows.Forms.Label();
            this.btnToAdminAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToUserAccount
            // 
            this.btnToUserAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToUserAccount.Location = new System.Drawing.Point(82, 0);
            this.btnToUserAccount.Name = "btnToUserAccount";
            this.btnToUserAccount.Size = new System.Drawing.Size(112, 24);
            this.btnToUserAccount.TabIndex = 0;
            this.btnToUserAccount.Text = "To user account";
            this.btnToUserAccount.UseVisualStyleBackColor = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistration.Location = new System.Drawing.Point(1, 1);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(85, 23);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignIn.Location = new System.Drawing.Point(92, 1);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(55, 23);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbWelcomeMessage.Location = new System.Drawing.Point(505, 0);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(57, 15);
            this.lbWelcomeMessage.TabIndex = 3;
            this.lbWelcomeMessage.Text = "Welcome";
            this.lbWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignOut.Location = new System.Drawing.Point(1, 1);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 231);
            this.panel1.TabIndex = 5;
            // 
            // lbCollectionIsEmpty
            // 
            this.lbCollectionIsEmpty.AutoSize = true;
            this.lbCollectionIsEmpty.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCollectionIsEmpty.Location = new System.Drawing.Point(298, 0);
            this.lbCollectionIsEmpty.Name = "lbCollectionIsEmpty";
            this.lbCollectionIsEmpty.Size = new System.Drawing.Size(135, 19);
            this.lbCollectionIsEmpty.TabIndex = 12;
            this.lbCollectionIsEmpty.Text = "Collection is empty.";
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshForm.Location = new System.Drawing.Point(454, 23);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(107, 23);
            this.btnRefreshForm.TabIndex = 6;
            this.btnRefreshForm.Text = "Refresh form";
            this.btnRefreshForm.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNextPage.Location = new System.Drawing.Point(486, 52);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.Text = "Next page";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPreviousPage.Location = new System.Drawing.Point(384, 52);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(96, 23);
            this.btnPreviousPage.TabIndex = 8;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(333, 56);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 9;
            this.lbPage.Text = "Page: 1";
            // 
            // btnToAdminAccount
            // 
            this.btnToAdminAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToAdminAccount.Location = new System.Drawing.Point(1, 23);
            this.btnToAdminAccount.Name = "btnToAdminAccount";
            this.btnToAdminAccount.Size = new System.Drawing.Size(115, 31);
            this.btnToAdminAccount.TabIndex = 10;
            this.btnToAdminAccount.Text = "To admin account";
            this.btnToAdminAccount.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Collection of users books with recipes";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 312);
            this.Controls.Add(this.lbCollectionIsEmpty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToAdminAccount);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnRefreshForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lbWelcomeMessage);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnToUserAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnToUserAccount;
        private Button btnRegistration;
        private Button btnSignIn;
        private Label lbWelcomeMessage;
        private Button btnSignOut;
        private FlowLayoutPanel panel1;
        private Button btnRefreshForm;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Label lbPage;
        private Button btnToAdminAccount;
        private Label label1;
        private Label lbCollectionIsEmpty;
    }
}