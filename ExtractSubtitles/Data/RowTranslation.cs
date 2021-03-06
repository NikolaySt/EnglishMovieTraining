using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.WinForms.Advanced.Data
{
	public class RowTranslation
	{
		public RowCaption ForeignLang { get; set; }
		public RowCaption MotherLang { get; set; }

		public override string ToString()
		{
			return MotherLang.Text;
		}
	}
}
