namespace KMarshall_Assignment4
{
    partial class MainForm
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
            this.mnsTopBar = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textDocumentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssrBottom = new System.Windows.Forms.StatusStrip();
            this.tsrStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsrMenu = new System.Windows.Forms.ToolStrip();
            this.tsrNewText = new System.Windows.Forms.ToolStripButton();
            this.tsrOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsrSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsTopBar.SuspendLayout();
            this.ssrBottom.SuspendLayout();
            this.tsrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsTopBar
            // 
            this.mnsTopBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnsTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsTopBar.Location = new System.Drawing.Point(0, 0);
            this.mnsTopBar.Name = "mnsTopBar";
            this.mnsTopBar.Size = new System.Drawing.Size(800, 24);
            this.mnsTopBar.TabIndex = 0;
            this.mnsTopBar.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textDocumentToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_new_copy_16;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // textDocumentToolStripMenuItem
            // 
            this.textDocumentToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_document_16;
            this.textDocumentToolStripMenuItem.Name = "textDocumentToolStripMenuItem";
            this.textDocumentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.textDocumentToolStripMenuItem.Text = "Text Document";
            this.textDocumentToolStripMenuItem.Click += new System.EventHandler(this.textDocumentToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textDocumentToolStripMenuItem1,
            this.imageDocumentToolStripMenuItem});
            this.openToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_opened_folder_16;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // textDocumentToolStripMenuItem1
            // 
            this.textDocumentToolStripMenuItem1.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_document_16;
            this.textDocumentToolStripMenuItem1.Name = "textDocumentToolStripMenuItem1";
            this.textDocumentToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.textDocumentToolStripMenuItem1.Text = "Text Document";
            this.textDocumentToolStripMenuItem1.Click += new System.EventHandler(this.textDocumentToolStripMenuItem1_Click);
            // 
            // imageDocumentToolStripMenuItem
            // 
            this.imageDocumentToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_camera_16;
            this.imageDocumentToolStripMenuItem.Name = "imageDocumentToolStripMenuItem";
            this.imageDocumentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.imageDocumentToolStripMenuItem.Text = "Image Document";
            this.imageDocumentToolStripMenuItem.Click += new System.EventHandler(this.imageDocumentToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_save_16;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_exit_16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeWindowsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeWindowsToolStripMenuItem
            // 
            this.cascadeWindowsToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_restore_window_16;
            this.cascadeWindowsToolStripMenuItem.Name = "cascadeWindowsToolStripMenuItem";
            this.cascadeWindowsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cascadeWindowsToolStripMenuItem.Text = "Cascade Windows";
            this.cascadeWindowsToolStripMenuItem.Click += new System.EventHandler(this.cascadeWindowsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_help_16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ssrBottom
            // 
            this.ssrBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrStatus});
            this.ssrBottom.Location = new System.Drawing.Point(0, 428);
            this.ssrBottom.Name = "ssrBottom";
            this.ssrBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssrBottom.Size = new System.Drawing.Size(800, 22);
            this.ssrBottom.TabIndex = 1;
            this.ssrBottom.Text = "statusStrip1";
            // 
            // tsrStatus
            // 
            this.tsrStatus.Name = "tsrStatus";
            this.tsrStatus.Size = new System.Drawing.Size(157, 17);
            this.tsrStatus.Text = "Ready - No Document Open";
            // 
            // tsrMenu
            // 
            this.tsrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrNewText,
            this.tsrOpenFile,
            this.tsrSave,
            this.toolStripSeparator1,
            this.tsrHelpAbout,
            this.toolStripSeparator2});
            this.tsrMenu.Location = new System.Drawing.Point(0, 24);
            this.tsrMenu.Name = "tsrMenu";
            this.tsrMenu.Size = new System.Drawing.Size(800, 25);
            this.tsrMenu.TabIndex = 2;
            this.tsrMenu.Text = "toolStrip1";
            // 
            // tsrNewText
            // 
            this.tsrNewText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrNewText.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_new_copy_16;
            this.tsrNewText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrNewText.Name = "tsrNewText";
            this.tsrNewText.Size = new System.Drawing.Size(23, 22);
            this.tsrNewText.Text = "New Text";
            this.tsrNewText.Click += new System.EventHandler(this.tsrNewText_Click);
            // 
            // tsrOpenFile
            // 
            this.tsrOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrOpenFile.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_opened_folder_16;
            this.tsrOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrOpenFile.Name = "tsrOpenFile";
            this.tsrOpenFile.Size = new System.Drawing.Size(23, 22);
            this.tsrOpenFile.Text = "Open";
            this.tsrOpenFile.Click += new System.EventHandler(this.tsrOpenFile_Click);
            // 
            // tsrSave
            // 
            this.tsrSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrSave.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_save_16;
            this.tsrSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrSave.Name = "tsrSave";
            this.tsrSave.Size = new System.Drawing.Size(23, 22);
            this.tsrSave.Text = "Save";
            this.tsrSave.Click += new System.EventHandler(this.tsrSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsrHelpAbout
            // 
            this.tsrHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrHelpAbout.Image = global::KMarshall_Assignment4.Properties.Resources.icons8_help_16;
            this.tsrHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrHelpAbout.Name = "tsrHelpAbout";
            this.tsrHelpAbout.Size = new System.Drawing.Size(23, 22);
            this.tsrHelpAbout.Text = "About";
            this.tsrHelpAbout.Click += new System.EventHandler(this.tsrHelpAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsrMenu);
            this.Controls.Add(this.ssrBottom);
            this.Controls.Add(this.mnsTopBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsTopBar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Project - Kevin Marshall - PROG1815 Spring 2019";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.MDIProjectMainForm_MdiChildActivate);
            this.mnsTopBar.ResumeLayout(false);
            this.mnsTopBar.PerformLayout();
            this.ssrBottom.ResumeLayout(false);
            this.ssrBottom.PerformLayout();
            this.tsrMenu.ResumeLayout(false);
            this.tsrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsTopBar;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssrBottom;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textDocumentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsrMenu;
        private System.Windows.Forms.ToolStripButton tsrNewText;
        private System.Windows.Forms.ToolStripStatusLabel tsrStatus;
        private System.Windows.Forms.ToolStripButton tsrOpenFile;
        private System.Windows.Forms.ToolStripButton tsrSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsrHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

