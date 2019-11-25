using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ImageProcessor.DataTransferObjects;
using ImageProcessor.Services;

namespace ImageProcessor
{
	public partial class ImageProcessorForm : Form
	{
		private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
		public ImageProcessorForm()
		{
			InitializeComponent();
			// size
			initializeSizeComboBox();

			initializeSizeCriteriaComboBox();
			validateSamePath();
		}

		private void initializeSizeComboBox() 
		{
			ItemDTO item10 = new ItemDTO();
			item10.Text = "10";
			item10.Value = 10;
			this.sizePercentage.Items.Add(item10);
			ItemDTO item20 = new ItemDTO();
			item20.Text = "20";
			item20.Value = 20;
			this.sizePercentage.Items.Add(item20);
			ItemDTO item30 = new ItemDTO();
			item30.Text = "30";
			item30.Value = 30;
			this.sizePercentage.Items.Add(item30);
			ItemDTO item40 = new ItemDTO();
			item40.Text = "40";
			item40.Value = 40;
			this.sizePercentage.Items.Add(item40);
			ItemDTO item50 = new ItemDTO();
			item50.Text = "50";
			item50.Value = 50;
			this.sizePercentage.Items.Add(item50);
			ItemDTO item60 = new ItemDTO();
			item60.Text = "60";
			item60.Value = 60;
			this.sizePercentage.Items.Add(item60);
			ItemDTO item70 = new ItemDTO();
			item70.Text = "70";
			item70.Value = 70;
			this.sizePercentage.Items.Add(item70);
			ItemDTO item80 = new ItemDTO();
			item80.Text = "80";
			item80.Value = 80;
			this.sizePercentage.Items.Add(item80);
			this.sizePercentage.Items.Add(item70);
			ItemDTO item90 = new ItemDTO();
			item90.Text = "90";
			item90.Value = 90;
			this.sizePercentage.Items.Add(item90);
			this.sizePercentage.SelectedIndex = 6;
		}

		private void initializeSizeCriteriaComboBox()
		{
			ItemDTO bm1 = new ItemDTO();
			bm1.Text = "1000000";
			bm1.Value = 1000000;
			this.sizeCriteria.Items.Add(bm1);
			ItemDTO mb2 = new ItemDTO();
			mb2.Text = "2000000";
			mb2.Value = 2000000;
			this.sizeCriteria.Items.Add(mb2);
			ItemDTO mb3 = new ItemDTO();
			mb3.Text = "3000000";
			mb3.Value = 3000000;
			this.sizeCriteria.Items.Add(mb3);
			this.sizeCriteria.SelectedIndex = 0;
		}

		private void Source_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					string[] files = Directory.GetFiles(fbd.SelectedPath);
					this.sourcePath.Text = fbd.SelectedPath;
				}
			}
		}

		private void processImage(object sender, EventArgs e)
		{
			
			try
			{
				this.button4.Enabled = false;

				string path = sourcePath.Text; // @"C:\GitProjects\ProofOfConcept\Images\Processed";
				string outPath = targetPath.Text; // @"C:\GitProjects\ProofOfConcept\Images\Processed";

				int sizePercentage = Convert.ToInt32(this.sizePercentage.Items[this.sizePercentage.SelectedIndex].ToString());
				long sizeCriteria = Convert.ToInt32(this.sizeCriteria.Items[this.sizeCriteria.SelectedIndex].ToString());

				bool useSourcePathAsOutPath = useSamePath.Checked;

				string extensions = "*.jpg|*.png|*.bmp";
				string[] multipleExtensions = extensions.Split('|');

				List<string> files = new List<string>();
				foreach (var extension in multipleExtensions)
				{
					string[] filesTemp = Directory.GetFiles(path, extension, SearchOption.AllDirectories);
					files.AddRange(filesTemp);
				}

				List<FileInfo> filesList = new List<FileInfo>();
				foreach (var fileItem in files)
				{
					FileInfo file = new FileInfo(Path.Combine(path, fileItem));
					if (file.Length > sizeCriteria)
					{
						filesList.Add(file);
					}
				}

				if (!Directory.Exists(outPath) && !useSourcePathAsOutPath)
				{
					Directory.CreateDirectory(outPath);
				}

				int allProgress = filesList.Count;
				int startProgress = 0;
				this.lblProgressTotal.Text = Convert.ToString(allProgress);
				var result = new ImageManagerService();
				foreach (var file in filesList)
				{
					result.Rezise(file.DirectoryName, file.Name, useSourcePathAsOutPath ? file.DirectoryName : outPath, sizePercentage);
					startProgress++;
					this.lblProgressPending.Text = Convert.ToString(startProgress);
					this.progressBarProcess.Value = (startProgress * 100) / allProgress;
					Logger.Trace($"{file.DirectoryName} -> {(useSourcePathAsOutPath ? file.DirectoryName : outPath)} -> {file.Name}: {file.Length} bytes");
				}
				this.button4.Enabled = true;
			}
			catch (Exception ex)
			{
				Logger.Error(ex.Message);
				this.button4.Enabled = true;
			}
		}

		private void Target_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					string[] files = Directory.GetFiles(fbd.SelectedPath);
					this.targetPath.Text = fbd.SelectedPath;
				}
			}
		}

		private void validateSamePath()
		{
			target.Enabled = !useSamePath.Checked;
			targetPath.Enabled = !useSamePath.Checked;
		}

		private void useSamePath_CheckedChanged(object sender, EventArgs e)
		{
			validateSamePath();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void target_Click_1(object sender, EventArgs e)
		{

		}

		private void useSamePath_CheckedChanged_1(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void sizeCriteria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
