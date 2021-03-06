using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.WinForms.Advanced.Data
{
	public class RowCaption
	{
		public int Index { get; set; }
		public TimeSpan From { get; set; }
		public TimeSpan To { get; set; }
		public string Text { get; set; }
		public RowCaption()
		{
			Text = "";
		}
	}
}
