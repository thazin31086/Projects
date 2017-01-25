using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACM.Library
{
    public static class StringExtensions
    {

        /// <summary>
        /// Extension Method
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string CovertToTitleCase(this string source)
        {
            CultureInfo culturInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = culturInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
