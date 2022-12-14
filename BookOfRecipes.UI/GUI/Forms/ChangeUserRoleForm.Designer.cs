namespace BookOfRecipes.UI.GUI.Forms
{
    partial class ChangeUserRoleForm
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
            this.components = new System.ComponentModel.Container();
            this.userRoleRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesComboBox = new System.Windows.Forms.ComboBox();
            this.btnChangeUserRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userRoleRepositoryBindingSource
            // 
            this.userRoleRepositoryBindingSource.DataSource = typeof(BookOfRecipes.Engine.Repositories.UserRoleRepository);
            // 
            // userRolesComboBox
            // 
            this.userRolesComboBox.FormattingEnabled = true;
            this.userRolesComboBox.Location = new System.Drawing.Point(12, 12);
            this.userRolesComboBox.Name = "userRolesComboBox";
            this.userRolesComboBox.Size = new System.Drawing.Size(121, 23);
            this.userRolesComboBox.TabIndex = 0;
            // 
            // btnChangeUserRole
            // 
            this.btnChangeUserRole.Location = new System.Drawing.Point(33, 41);
            this.btnChangeUserRole.Name = "btnChangeUserRole";
            this.btnChangeUserRole.Size = new System.Drawing.Size(75, 40);
            this.btnChangeUserRole.TabIndex = 1;
            this.btnChangeUserRole.Text = "Change user\'s role";
            this.btnChangeUserRole.UseVisualStyleBackColor = true;
            // 
            // ChangeUserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 88);
            this.Controls.Add(this.btnChangeUserRole);
            this.Controls.Add(this.userRolesComboBox);
            this.Name = "ChangeUserRoleForm";
            this.Text = "ChangeUserRoleForm";
            ((System.ComponentModel.ISupportInitialize)(this.userRoleRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource userRoleRepositoryBindingSource;
        private ComboBox userRolesComboBox;
        private Button btnChangeUserRole;
    }
}