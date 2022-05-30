using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class CountDuplicates
    {
        /* static void Main(string[] args)
         {
              var obj = GenerateDictionary("aadd");
              foreach (var kvp in obj)
              {
                  Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
              }

              string test = "aabb";
              int pocet = test.Count(char.IsLetterOrDigit);

        Console.WriteLine(Result("aad"));


        }*/
        public static Dictionary<char, int> GenerateDictionary(string text)
        {
            var charCounts = new Dictionary<char, int>();
            foreach (char letter in text)
            {
                var lowerLetter = Char.ToLower(letter);
                if (charCounts.ContainsKey(lowerLetter))
                {
                    charCounts[lowerLetter]++;
                }
                else

                {
                    charCounts.Add(lowerLetter, 1);
                }



            }
            return charCounts;
        }

        public static int Decode(Dictionary<char, int> charCounts)
        {
           
            int count = 0;
            foreach (var kvp in charCounts)
            {
                if (kvp.Value > 1)
                {
                    count += 1;
                }


            }

            return count;
        }
        public static int Result(string text)
        {
            var obj = GenerateDictionary(text);

            return Decode(obj);
        }
    }
}
