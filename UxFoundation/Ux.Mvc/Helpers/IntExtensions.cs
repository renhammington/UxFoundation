using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;


public static class IntExtensions
{

    /// <summary>
    /// Converts a number of bytes to a friendly formatted size string. i.e. kb, MB, GB.
    /// </summary>
    /// <param name="aBytes"></param>
    /// <returns></returns>
    public static string ToFriendlyFileSize(this int aBytes)
    {
        const int lScale = 1024;
        string[] lStrings = new string[] { "{0} MB", "{0} KB", "{0} bytes" };
        int lCap = (int)Math.Pow(lScale, lStrings.Length - 1);

        for (int i = 0, j = lStrings.Length; i < j; ++i)
        {
            if (aBytes <= lCap)
            {
                lCap /= lScale;
                continue;
            }

            string lStr = lStrings[i];
            decimal lValue = decimal.Divide(aBytes, lCap);

            if (i == j - 1)
                return string.Format(lStr, decimal.Divide(aBytes, lCap).ToString("N0"));
            else
                return string.Format(lStr, decimal.Divide(aBytes, lCap).ToString("N", Thread.CurrentThread.CurrentCulture.NumberFormat));
        }

        return string.Format("{0} bytes", aBytes);
    }

}
