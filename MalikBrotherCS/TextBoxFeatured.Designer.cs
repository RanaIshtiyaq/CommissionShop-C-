namespace MalikBrotherCS
{
    partial class TextBoxFeatured
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
            this.textBoxCus = new System.Windows.Forms.TextBox();
            this.pnCus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxCus
            // 
            this.textBoxCus.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCus.Location = new System.Drawing.Point(0, 0);
            this.textBoxCus.Name = "textBoxCus";
            this.textBoxCus.Size = new System.Drawing.Size(133, 26);
            this.textBoxCus.TabIndex = 0;
            this.textBoxCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCus.Leave += new System.EventHandler(this.textBoxCus_Leave);
            this.textBoxCus.MouseHover += new System.EventHandler(this.textBoxCus_MouseHover);
            // 
            // pnCus
            // 
            this.pnCus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnCus.Location = new System.Drawing.Point(0, 28);
            this.pnCus.Name = "pnCus";
            this.pnCus.Size = new System.Drawing.Size(170, 3);
            this.pnCus.TabIndex = 1;
            // 
            // TextBoxFeatured
            // 
            this.Controls.Add(this.pnCus);
            this.Controls.Add(this.textBoxCus);
            this.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TextBoxFeatured";
            this.Size = new System.Drawing.Size(133, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCus;
        private System.Windows.Forms.Panel pnCus;

        public System.Drawing.SizeF AutoScaleDimensions { get; set; }

        public System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }
    }
}
