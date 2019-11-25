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
using ImageProcessor.Services;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
		

		public Form1()
        {
            InitializeComponent();
        }

		private void startProcessing_Click(object sender, EventArgs e)
		{
			 
			
		}

		private void path_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void sourcePathName_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					string[] files = Directory.GetFiles(fbd.SelectedPath);
					//path = fbd.SelectedPath;
					//System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
