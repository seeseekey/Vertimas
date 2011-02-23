using System;
using System.Collections.Generic;
using System.Text;

namespace Vertimas
{
    public static class Common
    {
        public static string GetDefaultValue(string key)
        {
            return string.Format(
                Properties.Settings.Default.NonTranslatedString,
                key, key.ToUpper(), key.ToLower());
        }

    }
}
