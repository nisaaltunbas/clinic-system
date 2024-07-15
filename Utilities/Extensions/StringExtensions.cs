using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string ToUrl(this string value)
        {
            value = value.ToLower();
            value = value.Replace("ş", "s")
                         .Replace("ç", "c")
                         .Replace("ğ", "g")
                         .Replace("ü", "u")
                         .Replace("ö", "o")
                         .Replace("ı", "i");
            value = Regex.Replace(value, @"[^\w\d\s]", "");
            value = value.Trim();
            value = Regex.Replace(value, @"\s+", "-");
            return value;
        }
    }
}
