using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vertimas.Classes
{
	public class LanguageHolder
	{
		public string Id { get; set; }
		public string Filename { get; set; }

		public override string ToString()
		{
			return Id;
		}
	}
}
