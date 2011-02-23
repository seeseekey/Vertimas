using System;
using System.Collections.Generic;
using System.Text;

namespace Vertimas
{
	public static class Common
	{
		readonly static string NonTranslatedString="[{0}]";

		public static string GetDefaultValue(string key)
		{
			return string.Format(NonTranslatedString, key, key.ToUpper(), key.ToLower());
		}
	}
}
