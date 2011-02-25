using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CSCL.Helpers;

namespace Vertimas
{
	public partial class FormLanguageSelector : Form
	{
		public string SelectedLanguage { get; private set; }

		Dictionary<string, string> CodeToLanguage;

		public FormLanguageSelector()
		{
			InitializeComponent();

			//Init CodeToLanguage Dictonary
			InitCodeToLanguage();
		}

		/// <summary>
		/// http://msdn.microsoft.com/en-us/library/ms533052.aspx
		/// </summary>
		private void InitCodeToLanguage()
		{
			CodeToLanguage=new Dictionary<string, string>();

			CodeToLanguage.Add("af", "Afrikaans");
			CodeToLanguage.Add("sq", "Albanian");
			CodeToLanguage.Add("ar-sa", "Arabic (Saudi Arabia)");
			CodeToLanguage.Add("ar-iq", "Arabic (Iraq)");
			CodeToLanguage.Add("ar-eg", "Arabic (Egypt)");
			CodeToLanguage.Add("ar-ly", "Arabic (Libya)");
			CodeToLanguage.Add("ar-dz", "Arabic (Algeria)");
			CodeToLanguage.Add("ar-ma", "Arabic (Morocco)");
			CodeToLanguage.Add("ar-tn", "Arabic (Tunisia)");
			CodeToLanguage.Add("ar-om", "Arabic (Oman)");
			CodeToLanguage.Add("ar-ye", "Arabic (Yemen)");
			CodeToLanguage.Add("ar-sy", "Arabic (Syria)");
			CodeToLanguage.Add("ar-jo", "Arabic (Jordan)");
			CodeToLanguage.Add("ar-lb", "Arabic (Lebanon)");
			CodeToLanguage.Add("ar-kw", "Arabic (Kuwait)");
			CodeToLanguage.Add("ar-ae", "Arabic (U.A.E.)");
			CodeToLanguage.Add("ar-bh", "Arabic (Bahrain)");
			CodeToLanguage.Add("ar-qa", "Arabic (Qatar)");
			CodeToLanguage.Add("eu", "Basque");
			CodeToLanguage.Add("bg", "Bulgarian");
			CodeToLanguage.Add("be", "Belarusian");
			CodeToLanguage.Add("ca", "Catalan");
			CodeToLanguage.Add("zh-tw", "Chinese (Taiwan)");
			CodeToLanguage.Add("zh-cn", "Chinese (PRC)");
			CodeToLanguage.Add("zh-hk", "Chinese (Hong Kong SAR)");
			CodeToLanguage.Add("zh-sg", "Chinese (Singapore)");
			CodeToLanguage.Add("hr", "Croatian");
			CodeToLanguage.Add("cs", "Czech");
			CodeToLanguage.Add("da", "Danish");
			CodeToLanguage.Add("nl", "Dutch (Standard)");
			CodeToLanguage.Add("nl-be", "Dutch (Belgium)");
			CodeToLanguage.Add("en", "English");
			CodeToLanguage.Add("en-us", "English (United States)");
			CodeToLanguage.Add("en-gb", "English (United Kingdom)");
			CodeToLanguage.Add("en-au", "English (Australia)");
			CodeToLanguage.Add("en-ca", "English (Canada)");
			CodeToLanguage.Add("en-nz", "English (New Zealand)");
			CodeToLanguage.Add("en-ie", "English (Ireland)");
			CodeToLanguage.Add("en-za", "English (South Africa)");
			CodeToLanguage.Add("en-jm", "English (Jamaica)");
			//CodeToLanguage.Add("en", "English (Caribbean)");
			CodeToLanguage.Add("en-bz", "English (Belize)");
			CodeToLanguage.Add("en-tt", "English (Trinidad)");
			CodeToLanguage.Add("et", "Estonian");
			CodeToLanguage.Add("fo", "Faeroese");
			CodeToLanguage.Add("fa", "Farsi");
			CodeToLanguage.Add("fi", "Finnish");
			CodeToLanguage.Add("fr", "French (Standard)");
			CodeToLanguage.Add("fr-be", "French (Belgium)");
			CodeToLanguage.Add("fr-ca", "French (Canada)");
			CodeToLanguage.Add("fr-ch", "French (Switzerland)");
			CodeToLanguage.Add("fr-lu", "French (Luxembourg)");
			CodeToLanguage.Add("gd", "Gaelic (Scotland)");
			CodeToLanguage.Add("ga", "Irish");
			CodeToLanguage.Add("de", "German (Standard)");
			CodeToLanguage.Add("de-ch", "German (Switzerland)");
			CodeToLanguage.Add("de-at", "German (Austria)");
			CodeToLanguage.Add("de-lu", "German (Luxembourg)");
			CodeToLanguage.Add("de-li", "German (Liechtenstein)");
			CodeToLanguage.Add("el", "Greek");
			CodeToLanguage.Add("he", "Hebrew");
			CodeToLanguage.Add("hi", "Hindi");
			CodeToLanguage.Add("hu", "Hungarian");
			CodeToLanguage.Add("is", "Icelandic");
			CodeToLanguage.Add("id", "Indonesian");
			CodeToLanguage.Add("it", "Italian (Standard)");
			CodeToLanguage.Add("it-ch", "Italian (Switzerland)");
			CodeToLanguage.Add("ja", "Japanese");
			CodeToLanguage.Add("ko", "Korean");
			//CodeToLanguage.Add("ko", "Korean (Johab)");
			CodeToLanguage.Add("lv", "Latvian");
			CodeToLanguage.Add("lt", "Lithuanian");
			CodeToLanguage.Add("mk", "Macedonian (FYROM)");
			CodeToLanguage.Add("ms", "Malaysian");
			CodeToLanguage.Add("mt", "Maltese");
			CodeToLanguage.Add("no", "Norwegian (Bokmal)");
			//CodeToLanguage.Add("no", "Norwegian (Nynorsk)");
			CodeToLanguage.Add("pl", "Polish");
			CodeToLanguage.Add("pt-br", "Portuguese (Brazil)");
			CodeToLanguage.Add("pt", "Portuguese (Portugal)");
			CodeToLanguage.Add("rm", "Rhaeto-Romanic");
			CodeToLanguage.Add("ro", "Romanian");
			CodeToLanguage.Add("ro-mo", "Romanian (Republic of Moldova)");
			CodeToLanguage.Add("ru", "Russian");
			CodeToLanguage.Add("ru-mo", "Russian (Republic of Moldova)");
			CodeToLanguage.Add("sz", "Sami (Lappish)");
			CodeToLanguage.Add("sr", "Serbian (Cyrillic)");
			//CodeToLanguage.Add("sr", "Serbian (Latin)");
			CodeToLanguage.Add("sk", "Slovak");
			CodeToLanguage.Add("sl", "Slovenian");
			CodeToLanguage.Add("sb", "Sorbian");
			CodeToLanguage.Add("es", "Spanish (Spain)");
			CodeToLanguage.Add("es-mx", "Spanish (Mexico)");
			CodeToLanguage.Add("es-gt", "Spanish (Guatemala)");
			CodeToLanguage.Add("es-cr", "Spanish (Costa Rica)");
			CodeToLanguage.Add("es-pa", "Spanish (Panama)");
			CodeToLanguage.Add("es-do", "Spanish (Dominican Republic)");
			CodeToLanguage.Add("es-ve", "Spanish (Venezuela)");
			CodeToLanguage.Add("es-co", "Spanish (Colombia)");
			CodeToLanguage.Add("es-pe", "Spanish (Peru)");
			CodeToLanguage.Add("es-ar", "Spanish (Argentina)");
			CodeToLanguage.Add("es-ec", "Spanish (Ecuador)");
			CodeToLanguage.Add("es-cl", "Spanish (Chile)");
			CodeToLanguage.Add("es-uy", "Spanish (Uruguay)");
			CodeToLanguage.Add("es-py", "Spanish (Paraguay)");
			CodeToLanguage.Add("es-bo", "Spanish (Bolivia)");
			CodeToLanguage.Add("es-sv", "Spanish (El Salvador)");
			CodeToLanguage.Add("es-hn", "Spanish (Honduras)");
			CodeToLanguage.Add("es-ni", "Spanish (Nicaragua)");
			CodeToLanguage.Add("es-pr", "Spanish (Puerto Rico)");
			CodeToLanguage.Add("sx", "Sutu");
			CodeToLanguage.Add("sv", "Swedish");
			CodeToLanguage.Add("sv-fi", "Swedish (Finland)");
			CodeToLanguage.Add("th", "Thai");
			CodeToLanguage.Add("ts", "Tsonga");
			CodeToLanguage.Add("tn", "Tswana");
			CodeToLanguage.Add("tr", "Turkish");
			CodeToLanguage.Add("uk", "Ukrainian");
			CodeToLanguage.Add("ur", "Urdu");
			CodeToLanguage.Add("ve", "Venda");
			CodeToLanguage.Add("vi", "Vietnamese");
			CodeToLanguage.Add("xh", "Xhosa");
			CodeToLanguage.Add("ji", "Yiddish");
			CodeToLanguage.Add("zu", "Zulu");
		}

		private List<string> GetLanguagesCodes()
		{
			List<string> ret=new List<string>();

			foreach(string i in CodeToLanguage.Keys)
			{
				ret.Add(i);
			}

			ret.Sort();

			return ret;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if(lvLanguages.SelectedItems.Count==0)
			{
				MessageBox.Show(Translation.Translate.NoItemSelected, Translation.Translate.Notice, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			SelectedLanguage=lvLanguages.SelectedItems[0].Text.ToString();
			DialogResult=System.Windows.Forms.DialogResult.OK;
		}

		private void FormLanguageSelector_Load(object sender, EventArgs e)
		{
			lvLanguages.Columns.Add("Code");
			lvLanguages.Columns.Add("Name");

			List<string> codes=GetLanguagesCodes();

			foreach(string i in codes)
			{
				ListViewItem item=new ListViewItem(i);
				item.SubItems.Add(CodeToLanguage[i]);
				lvLanguages.Items.Add(item);
			}

			ListViewHelpers.SetUniformColumnWidth(lvLanguages, 10);
		}
	}
}
