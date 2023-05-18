﻿namespace BookOfRecipes.UI.GUI.Controls
{
    partial class BookOfRecipeInUserAccountControl
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnToRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(15, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(15, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTitle.Location = new System.Drawing.Point(5, 3);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTitle.Size = new System.Drawing.Size(100, 73);
            this.tbTitle.TabIndex = 2;
            // 
            // btnToRecipes
            // 
            this.btnToRecipes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToRecipes.Location = new System.Drawing.Point(15, 140);
            this.btnToRecipes.Name = "btnToRecipes";
            this.btnToRecipes.Size = new System.Drawing.Size(75, 23);
            this.btnToRecipes.TabIndex = 3;
            this.btnToRecipes.Text = "To recipes";
            this.btnToRecipes.UseVisualStyleBackColor = false;
            this.btnToRecipes.Click += new System.EventHandler(this.btnToRecipes_Click);
            // 
            // BookOfRecipeInUserAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnToRecipes);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "BookOfRecipeInUserAccountControl";
            this.Size = new System.Drawing.Size(106, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private TextBox tbTitle;
        private Button btnToRecipes;
    }
}
