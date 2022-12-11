namespace BookOfRecipes.UI.GUI.Forms
{
    partial class RecipeForm
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
            this.recipeOperationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // recipeOperationPanel
            // 
            this.recipeOperationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeOperationPanel.Location = new System.Drawing.Point(0, 0);
            this.recipeOperationPanel.Name = "recipeOperationPanel";
            this.recipeOperationPanel.Size = new System.Drawing.Size(276, 318);
            this.recipeOperationPanel.TabIndex = 0;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 318);
            this.Controls.Add(this.recipeOperationPanel);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel recipeOperationPanel;
    }
}