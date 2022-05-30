using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ToCamelCase
    {
        public static string ConvertToCamel(string str)
        {

            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }

        public static string ConvertToCamel2(string str)
        {

            return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        }
        public static string ConverToCamel3(string str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '-' && str[i] != '_') sb.Append(str[i]);
                else sb.Append(char.ToUpper(str[++i]));
            }
            return sb.ToString();
        }
        public static string ConvertToCamel4(string str)
        {
            return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
        }
        public static string ConvertToCamel5(string str)
        {
            var words = str.Split('-', '_');
            for (int i = 1; i < words.Length; i++)
            {
                words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
            }
            return String.Join("", words);
        }

    }

}

