namespace BookOfRecipes.UI.GUI.Controls
{
    partial class RecipeOperationControl
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
            this.lbOperationWithRecipe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.btnOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOperationWithRecipe
            // 
            this.lbOperationWithRecipe.AutoSize = true;
            this.lbOperationWithRecipe.Location = new System.Drawing.Point(92, 0);
            this.lbOperationWithRecipe.Name = "lbOperationWithRecipe";
            this.lbOperationWithRecipe.Size = new System.Drawing.Size(95, 15);
            this.lbOperationWithRecipe.TabIndex = 0;
            this.lbOperationWithRecipe.Text = "Operation recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tags";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTitle.Location = new System.Drawing.Point(15, 43);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(244, 23);
            this.tbTitle.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescription.Location = new System.Drawing.Point(15, 159);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(244, 126);
            this.tbDescription.TabIndex = 5;
            // 
            // tbTags
            // 
            this.tbTags.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTags.Location = new System.Drawing.Point(15, 99);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTags.Size = new System.Drawing.Size(244, 23);
            this.tbTags.TabIndex = 6;
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOperation.Location = new System.Drawing.Point(102, 291);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(75, 23);
            this.btnOperation.TabIndex = 7;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // RecipeOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.tbTags);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOperationWithRecipe);
            this.Name = "RecipeOperationControl";
            this.Size = new System.Drawing.Size(272, 315);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOperationWithRecipe;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTitle;
        private TextBox tbDescription;
        private TextBox tbTags;
        private Button btnOperation;
    }
}
