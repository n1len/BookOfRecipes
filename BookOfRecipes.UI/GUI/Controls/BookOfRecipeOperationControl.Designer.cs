namespace BookOfRecipes.UI.GUI.Controls
{
    partial class BookOfRecipeOperationControl
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
            this.btnOperation = new System.Windows.Forms.Button();
            this.lbControlName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(127, 338);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(75, 23);
            this.btnOperation.TabIndex = 0;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // lbControlName
            // 
            this.lbControlName.AutoSize = true;
            this.lbControlName.Location = new System.Drawing.Point(81, 0);
            this.lbControlName.Name = "lbControlName";
            this.lbControlName.Size = new System.Drawing.Size(165, 15);
            this.lbControlName.TabIndex = 1;
            this.lbControlName.Text = "Operation with book of recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image (In development)";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(24, 112);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(273, 167);
            this.tbDescription.TabIndex = 5;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(24, 56);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(273, 23);
            this.tbTitle.TabIndex = 6;
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(24, 309);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(273, 23);
            this.tbImage.TabIndex = 7;
            // 
            // BookOfRecipeOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbControlName);
            this.Controls.Add(this.btnOperation);
            this.Name = "BookOfRecipeOperationControl";
            this.Size = new System.Drawing.Size(321, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOperation;
        private Label lbControlName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private TextBox tbImage;
    }
}
