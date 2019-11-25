namespace ImageProcessor
{
	partial class ImageProcessorForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.sourcePath = new System.Windows.Forms.TextBox();
			this.targetPath = new System.Windows.Forms.TextBox();
			this.source = new System.Windows.Forms.Button();
			this.target = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.useSamePath = new System.Windows.Forms.CheckBox();
			this.sizePercentage = new System.Windows.Forms.ComboBox();
			this.sizeCriteria = new System.Windows.Forms.ComboBox();
			this.progressBarProcess = new System.Windows.Forms.ProgressBar();
			this.lblProgressPending = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProgressTotal = new System.Windows.Forms.Label();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compression percentage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(207, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Files greater than (bytes)";
			// 
			// sourcePath
			// 
			this.sourcePath.Location = new System.Drawing.Point(18, 35);
			this.sourcePath.Name = "sourcePath";
			this.sourcePath.Size = new System.Drawing.Size(649, 27);
			this.sourcePath.TabIndex = 2;
			// 
			// targetPath
			// 
			this.targetPath.Location = new System.Drawing.Point(18, 77);
			this.targetPath.Name = "targetPath";
			this.targetPath.Size = new System.Drawing.Size(649, 27);
			this.targetPath.TabIndex = 3;
			// 
			// source
			// 
			this.source.Location = new System.Drawing.Point(685, 33);
			this.source.Name = "source";
			this.source.Size = new System.Drawing.Size(124, 31);
			this.source.TabIndex = 5;
			this.source.Text = "select source";
			this.source.UseVisualStyleBackColor = true;
			this.source.Click += new System.EventHandler(this.Source_Click);
			// 
			// target
			// 
			this.target.Location = new System.Drawing.Point(685, 76);
			this.target.Name = "target";
			this.target.Size = new System.Drawing.Size(124, 28);
			this.target.TabIndex = 6;
			this.target.Text = "Select target";
			this.target.UseVisualStyleBackColor = true;
			this.target.Click += new System.EventHandler(this.Target_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(685, 159);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(124, 36);
			this.button4.TabIndex = 7;
			this.button4.Text = "Good luck";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.processImage);
			// 
			// useSamePath
			// 
			this.useSamePath.AutoSize = true;
			this.useSamePath.Checked = true;
			this.useSamePath.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useSamePath.Enabled = false;
			this.useSamePath.Location = new System.Drawing.Point(824, 40);
			this.useSamePath.Name = "useSamePath";
			this.useSamePath.Size = new System.Drawing.Size(181, 24);
			this.useSamePath.TabIndex = 8;
			this.useSamePath.Text = "Write in the same path";
			this.useSamePath.UseVisualStyleBackColor = true;
			this.useSamePath.CheckedChanged += new System.EventHandler(this.useSamePath_CheckedChanged);
			// 
			// sizePercentage
			// 
			this.sizePercentage.FormattingEnabled = true;
			this.sizePercentage.Location = new System.Drawing.Point(18, 167);
			this.sizePercentage.Name = "sizePercentage";
			this.sizePercentage.Size = new System.Drawing.Size(157, 28);
			this.sizePercentage.TabIndex = 9;
			// 
			// sizeCriteria
			// 
			this.sizeCriteria.FormattingEnabled = true;
			this.sizeCriteria.Location = new System.Drawing.Point(207, 167);
			this.sizeCriteria.Name = "sizeCriteria";
			this.sizeCriteria.Size = new System.Drawing.Size(162, 28);
			this.sizeCriteria.TabIndex = 10;
			this.sizeCriteria.SelectedIndexChanged += new System.EventHandler(this.sizeCriteria_SelectedIndexChanged);
			// 
			// progressBarProcess
			// 
			this.progressBarProcess.Location = new System.Drawing.Point(18, 259);
			this.progressBarProcess.Name = "progressBarProcess";
			this.progressBarProcess.Size = new System.Drawing.Size(791, 38);
			this.progressBarProcess.TabIndex = 11;
			// 
			// lblProgressPending
			// 
			this.lblProgressPending.AutoSize = true;
			this.lblProgressPending.Location = new System.Drawing.Point(824, 268);
			this.lblProgressPending.Name = "lblProgressPending";
			this.lblProgressPending.Size = new System.Drawing.Size(17, 20);
			this.lblProgressPending.TabIndex = 12;
			this.lblProgressPending.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(880, 268);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "/";
			// 
			// lblProgressTotal
			// 
			this.lblProgressTotal.AutoSize = true;
			this.lblProgressTotal.Location = new System.Drawing.Point(936, 268);
			this.lblProgressTotal.Name = "lblProgressTotal";
			this.lblProgressTotal.Size = new System.Drawing.Size(17, 20);
			this.lblProgressTotal.TabIndex = 14;
			this.lblProgressTotal.Text = "0";
			// 
			// ImageProcessorForm
			// 
			this.ClientSize = new System.Drawing.Size(1020, 332);
			this.Controls.Add(this.lblProgressTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblProgressPending);
			this.Controls.Add(this.progressBarProcess);
			this.Controls.Add(this.sizeCriteria);
			this.Controls.Add(this.sizePercentage);
			this.Controls.Add(this.useSamePath);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.target);
			this.Controls.Add(this.source);
			this.Controls.Add(this.targetPath);
			this.Controls.Add(this.sourcePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ImageProcessorForm";

		}

		#endregion

		private System.Windows.Forms.Button Source;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox sourcePath;
		private System.Windows.Forms.Button processImages;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox useSamePath;
		private System.Windows.Forms.Button target;
		private System.Windows.Forms.TextBox targetPath;
		private System.Windows.Forms.ComboBox sizePercentage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button source;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox sizeCriteria;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ProgressBar progressBarProcess;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblProgressPending;
		private System.Windows.Forms.Label lblProgressTotal;
	}
}