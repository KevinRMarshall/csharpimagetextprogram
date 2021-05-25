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
    public partial class TextDocumentForm : Form
    {
        public static string userText;
        public string TextFile { get; set; }

        public TextDocumentForm()
        {
            InitializeComponent();           

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            userText = txtUser.Text;
        }

        private void TextDocumentForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = TextFile;
        }
    }
}
