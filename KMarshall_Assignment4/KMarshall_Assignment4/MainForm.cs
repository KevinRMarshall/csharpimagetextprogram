/*
 * Made by: Kevin Marshall
 * Date last edited: August 9th, 2019
 * Purpose: Using MDI to create text and image forms, open text and image forms, and to save text forms
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMarshall_Assignment4
{
    public partial class MainForm : Form
    {     

        public MainForm()
        {
            InitializeComponent();
            saveAsToolStripMenuItem.Enabled = false;
        }

        private void tsrHelpAbout_Click(object sender, EventArgs e)
        {
            //open the About me form
            AboutForm aboutMe = new AboutForm();
            aboutMe.ShowDialog(this);
            aboutMe.MdiParent = this;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the About Me form
            AboutForm aboutMe = new AboutForm();
            aboutMe.ShowDialog(this);
            aboutMe.MdiParent = this;            
        }

        private void MDIProjectMainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is AboutForm)
            {
                tsrStatus.Text = "About Me Form Active";
                
            }
            else if (this.ActiveMdiChild is TextDocumentForm)
            {
                tsrStatus.Text = "Text Form Is Active";
                saveAsToolStripMenuItem.Enabled = true;
            }
            else if (this.ActiveMdiChild is ImageDocumentForm)
            {
                tsrStatus.Text = "Image Form Is Active";
                saveAsToolStripMenuItem.Enabled = false;
            }
            else 
            {
                tsrStatus.Text = "Ready - No Document Open";
                saveAsToolStripMenuItem.Enabled = false;
            }
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void textDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextDocumentForm textForm = new TextDocumentForm();
            textForm.Show();
            textForm.MdiParent = this;            

        }

        private void tsrNewText_Click(object sender, EventArgs e)
        {
            TextDocumentForm textForm = new TextDocumentForm();
            textForm.Show();
            textForm.MdiParent = this;
        }

        private void tsrOpenFile_Click(object sender, EventArgs e)
        {
            //Open with filter for Text and Image Files           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Path.GetExtension(openFileDialog.FileName);               
                string path = Path.GetExtension(openFileDialog.FileName);              

                if (path == ".txt")
                {                    
                    TextDocumentForm textForm = new TextDocumentForm();
                    string text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                    textForm.TextFile = text;
                    textForm.Show();                    
                    textForm.MdiParent = this;                                                      

                }
                else
                {
                    ImageDocumentForm imageForm = new ImageDocumentForm();
                    imageForm.ImageLocation = openFileDialog.FileName;
                    imageForm.Show();
                    imageForm.MdiParent = this;
                    

                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check to see if any text forms are open, and if they, ask if user wants to save
            foreach (Form childForm in this.MdiChildren)
            {
                if (ActiveMdiChild is TextDocumentForm)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Text File", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveTextFile();
                        childForm.Dispose();
                        return;
                    }
                    else if (result == DialogResult.No)
                    {
                        //close current form and check next 
                        childForm.Dispose();                        
                    }
                    else
                    {
                        //do nothing and go back to current form.                        
                    }                  
                }
                if (ActiveMdiChild is ImageDocumentForm)
                {
                    childForm.Dispose();
                }
            }
             if (ActiveMdiChild is null)
            {
                this.Close();
            }
        }

        private void tsrSave_Click(object sender, EventArgs e)
        {
            //Make sure user can save text documents, but NOT images
            if (this.ActiveMdiChild is TextDocumentForm)
            {
                SaveTextFile();
            }
            else
            {
                MessageBox.Show("Sorry, only text documents can be saved!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imageDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageDocumentForm imageForm = new ImageDocumentForm();
                imageForm.ImageLocation = openFileDialog.FileName;
                imageForm.Show();
                imageForm.MdiParent = this;
            }

        }

        private void textDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files(*.txt)| *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextDocumentForm textForm = new TextDocumentForm();
                string text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                textForm.TextFile = text;
                textForm.Show();
                textForm.MdiParent = this;                
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (ActiveMdiChild is TextDocumentForm)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Text File", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        //save form
                        SaveTextFile();
                        childForm.Dispose();
                        return;
                    }
                    else if (result == DialogResult.No)
                    {
                        //close current form and check next 
                        childForm.Dispose();
                    }
                    else
                    {
                        //do nothing and go back to current form.                        

                    }

                }
                if (ActiveMdiChild is ImageDocumentForm)
                {
                    childForm.Dispose();
                }

            }

        }
        /// <summary>
        /// This method saves the text file if the user so chooses
        /// </summary>
        /// <returns></returns>
        public string SaveTextFile()
        {
            //save form
            SaveFileDialog saveText = new SaveFileDialog();
            saveText.Filter = "Text files (*.txt)|*.txt";
            saveText.Title = "Save a text file";
            if (saveText.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveText.FileName))
                    sw.WriteLine(TextDocumentForm.userText); //save what has been written
            }
            return "Saved";
        }
    }
}
