namespace KMarshall_Assignment4
{
    partial class AboutForm
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
            this.picAboutMe = new System.Windows.Forms.PictureBox();
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutMe)).BeginInit();
            this.SuspendLayout();
            // 
            // picAboutMe
            // 
            this.picAboutMe.Image = global::KMarshall_Assignment4.Properties.Resources.Kevblue;
            this.picAboutMe.Location = new System.Drawing.Point(24, 16);
            this.picAboutMe.Name = "picAboutMe";
            this.picAboutMe.Size = new System.Drawing.Size(69, 119);
            this.picAboutMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAboutMe.TabIndex = 0;
            this.picAboutMe.TabStop = false;
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.AutoSize = true;
            this.lblAboutMe.Location = new System.Drawing.Point(126, 46);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(228, 13);
            this.lblAboutMe.TabIndex = 1;
            this.lblAboutMe.Text = "This application was created by Kevin Marshall";
            this.lblAboutMe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 147);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAboutMe);
            this.Controls.Add(this.picAboutMe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)(this.picAboutMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAboutMe;
        private System.Windows.Forms.Label lblAboutMe;
        private System.Windows.Forms.Button btnOK;
    }
}