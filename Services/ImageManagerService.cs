using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ImageMagick;

namespace ImageProcessor.Services
{
	public class ImageManagerService
	{
		public bool Rezise(string path, string imageName, string outPath, int percentage = 50) 
		{
			string pt = Path.Combine(path, imageName);
			using (MagickImage image = new MagickImage(Path.Combine(path, imageName))) 
			{
				image.Resize(new MagickGeometry($"{percentage}%"));
				image.Write(Path.Combine(outPath, $"{imageName}"));

				
				//System.Drawing.Imaging.Encoder qe = new System.Drawing.Imaging.Encoder();
			}
			//	ImageMagickNET.MagickNet.InitializeMagick();
			//var image = new ImageMagickNET.Image("test.jpg");
			//image.Resize(new ImageMagickNET.Geometry("50%"));
			//image.Write("result.jpg");
			return true;
		}
	}
}
