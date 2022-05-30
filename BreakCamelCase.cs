/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BreakCamelCase 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decode("camelCasingTest"));
        }

        static public string decode(string data)
        {
            bool jeUpper = false;
            var builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {

                if (Char.IsUpper(data[i]))
                {
                  
                    builder.Append(' ').Append(data[i]);


                }
                else
                {
                    builder.Append(data[i]);
                }

            }
            return builder.ToString();
        }
    }
}
*/