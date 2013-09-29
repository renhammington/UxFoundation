using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Ux.Mvc.Helpers
{
    public static class GlobalizeCulture
    {

        public static KeyValuePair<string, string> GetCurrentCulture()
        {
            // Determine culture - GUI culture for preference, user selected culture as fallback
            const string filePattern = "~/scripts/jquery.globalize/cultures/globalize.culture.{0}.js";
            var currentCulture = CultureInfo.CurrentCulture;
            var cultureToUse = "en-GB"; //Default regionalisation to use

            //Try to pick a more appropriate regionalisation
            if (File.Exists(HostingEnvironment.MapPath(string.Format(filePattern, currentCulture.Name)))) //First try for a globalize.culture.en-GB.js style file
                cultureToUse = currentCulture.Name;
            else if (File.Exists(HostingEnvironment.MapPath(string.Format(filePattern, currentCulture.TwoLetterISOLanguageName)))) //That failed; now try for a globalize.culture.en.js style file
                cultureToUse = currentCulture.TwoLetterISOLanguageName;

            return new KeyValuePair<string, string>(cultureToUse, string.Format(filePattern, cultureToUse));
        }   


    }
}