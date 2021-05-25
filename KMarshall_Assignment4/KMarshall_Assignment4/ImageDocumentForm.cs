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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMarshall_Assignment4
{
    public partial class ImageDocumentForm : Form
    {
        public string ImageLocation { get; set; }

        public ImageDocumentForm()
        {
            InitializeComponent();            
        }

        private void ImageDocumentForm_Load(object sender, EventArgs e)
        {
            picUserImage.ImageLocation = ImageLocation;
        }
    }
}
