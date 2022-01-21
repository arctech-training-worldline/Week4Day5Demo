using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day5Demo
{
    public partial class FormFileLoader : Form
    {
        public FormFileLoader()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sr = File.OpenText(openFileDialog.FileName))
                {
                    TextBoxFileData.Text = "";
                    while (!sr.EndOfStream)
                    {
                        TextBoxFileData.Text += sr.ReadLine() + "\n";
                    }
                }
            }
        }
    }
}
