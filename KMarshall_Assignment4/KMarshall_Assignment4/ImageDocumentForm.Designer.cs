namespace KMarshall_Assignment4
{
    partial class ImageDocumentForm
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
            this.picUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picUserImage
            // 
            this.picUserImage.Location = new System.Drawing.Point(13, 13);
            this.picUserImage.Name = "picUserImage";
            this.picUserImage.Size = new System.Drawing.Size(296, 253);
            this.picUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserImage.TabIndex = 0;
            this.picUserImage.TabStop = false;
            // 
            // ImageDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 278);
            this.Controls.Add(this.picUserImage);
            this.Name = "ImageDocumentForm";
            this.Text = "Image Document";
            this.Load += new System.EventHandler(this.ImageDocumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUserImage;
    }
}