namespace BookOfRecipes.UI.GUI.Forms
{
    partial class BookOfRecipeForm
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
            this.operationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // operationPanel
            // 
            this.operationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel.Location = new System.Drawing.Point(0, 0);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(322, 365);
            this.operationPanel.TabIndex = 0;
            // 
            // BookOfRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(322, 365);
            this.Controls.Add(this.operationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookOfRecipeForm";
            this.Text = "BookOfRecipeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel operationPanel;
    }
}