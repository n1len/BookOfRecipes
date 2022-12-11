namespace BookOfRecipes.UI.GUI.Controls
{
    partial class BookOfRecipeInfoControl
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(17, 86);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(3, 30);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(100, 56);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Text = _bookOfRecipeDto.Description;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(3, 3);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTitle.Size = new System.Drawing.Size(100, 23);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.Text = _bookOfRecipeDto.Title;
            // 
            // BookOfRecipeInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnDetails);
            this.Name = "BookOfRecipeInfoControl";
            this.Size = new System.Drawing.Size(108, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDetails;
        private TextBox tbDescription;
        private TextBox tbTitle;
    }
}
