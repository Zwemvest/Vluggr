using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vluggr.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string targetString)
        {
            return string.IsNullOrWhiteSpace(targetString);
        }

        public static bool IsNullOrEmpty(this string targetString)
        {
            return string.IsNullOrEmpty(targetString);
        }
    }
}
