using System;
using System.Collections.Generic;
using System.Text;
using CSCL;

namespace Vertimas.Classes
{
	public static class Common
	{
		readonly static string NonTranslatedString="[{0}]";
		public const string Neutral="Neutral (en)";

		public static string GetDefaultValue(string key)
		{
			return string.Format(NonTranslatedString, key, key.ToUpper(), key.ToLower());
		}

		public static XmlData Options;
		public static string OptionsDirectory=FileSystem.ApplicationDataDirectory+".vertimas\\Vertimas\\";
		public static string OptionsXmlFilename=OptionsDirectory+"vertimas.xml";
	}
}
