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
            this.btnRefreshForm = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lbPage = new System.Windows.Forms.Label();
            this.btnToAdminAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToUserAccount
            // 
            this.btnToUserAccount.Location = new System.Drawing.Point(1, 1);
            this.btnToUserAccount.Name = "btnToUserAccount";
            this.btnToUserAccount.Size = new System.Drawing.Size(75, 40);
            this.btnToUserAccount.TabIndex = 0;
            this.btnToUserAccount.Text = "To user account";
            this.btnToUserAccount.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(82, 1);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(85, 23);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(173, 1);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(55, 23);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeMessage
            // 
            this.lbWelcomeMessage.AutoSize = true;
            this.lbWelcomeMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbWelcomeMessage.Location = new System.Drawing.Point(637, 0);
            this.lbWelcomeMessage.Name = "lbWelcomeMessage";
            this.lbWelcomeMessage.Size = new System.Drawing.Size(57, 15);
            this.lbWelcomeMessage.TabIndex = 3;
            this.lbWelcomeMessage.Text = "Welcome";
            this.lbWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(82, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(114, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 233);
            this.panel1.TabIndex = 5;
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.Location = new System.Drawing.Point(1, 281);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(107, 23);
            this.btnRefreshForm.TabIndex = 6;
            this.btnRefreshForm.Text = "Refresh form";
            this.btnRefreshForm.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(615, 52);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.Text = "Next page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(513, 52);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(96, 23);
            this.btnPreviousPage.TabIndex = 8;
            this.btnPreviousPage.Text = "Previous page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(462, 56);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 9;
            this.lbPage.Text = "Page: 1";
            // 
            // btnToAdminAccount
            // 
            this.btnToAdminAccount.Location = new System.Drawing.Point(1, 47);
            this.btnToAdminAccount.Name = "btnToAdminAccount";
            this.btnToAdminAccount.Size = new System.Drawing.Size(75, 41);
            this.btnToAdminAccount.TabIndex = 10;
            this.btnToAdminAccount.Text = "To admin account";
            this.btnToAdminAccount.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 311);
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
    }
}