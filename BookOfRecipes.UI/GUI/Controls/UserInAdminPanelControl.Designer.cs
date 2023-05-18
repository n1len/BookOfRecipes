namespace BookOfRecipes.UI.GUI.Controls
{
    partial class UserInAdminPanelControl
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
            this.btnChangeBlockedState = new System.Windows.Forms.Button();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnToUserAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeBlockedState
            // 
            this.btnChangeBlockedState.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeBlockedState.Location = new System.Drawing.Point(4, 135);
            this.btnChangeBlockedState.Name = "btnChangeBlockedState";
            this.btnChangeBlockedState.Size = new System.Drawing.Size(75, 23);
            this.btnChangeBlockedState.TabIndex = 0;
            this.btnChangeBlockedState.Text = "Block";
            this.btnChangeBlockedState.UseVisualStyleBackColor = false;
            this.btnChangeBlockedState.Click += new System.EventHandler(this.btnChangeBlockedState_Click);
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeRole.Location = new System.Drawing.Point(4, 46);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(75, 38);
            this.btnChangeRole.TabIndex = 1;
            this.btnChangeRole.Text = "Change role";
            this.btnChangeRole.UseVisualStyleBackColor = false;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login: ";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(42, 4);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(34, 15);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role:";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(43, 28);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(52, 15);
            this.lbRole.TabIndex = 5;
            this.lbRole.Text = "user role";
            // 
            // btnToUserAccount
            // 
            this.btnToUserAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToUserAccount.Location = new System.Drawing.Point(4, 90);
            this.btnToUserAccount.Name = "btnToUserAccount";
            this.btnToUserAccount.Size = new System.Drawing.Size(75, 39);
            this.btnToUserAccount.TabIndex = 6;
            this.btnToUserAccount.Text = "To user account";
            this.btnToUserAccount.UseVisualStyleBackColor = false;
            this.btnToUserAccount.Click += new System.EventHandler(this.btnToUserAccount_Click);
            // 
            // UserInAdminPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnToUserAccount);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.btnChangeBlockedState);
            this.Name = "UserInAdminPanelControl";
            this.Size = new System.Drawing.Size(133, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChangeBlockedState;
        private Button btnChangeRole;
        private Label label1;
        private Label lbLogin;
        private Label label2;
        private Label lbRole;
        private Button btnToUserAccount;
    }
}
