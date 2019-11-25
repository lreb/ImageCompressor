using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessor.DataTransferObjects
{
	public class ItemDTO
	{
		public string Text { get; set; }
		public object Value { get; set; }

		public override string ToString()
		{
			return Text;
		}
	}
}
