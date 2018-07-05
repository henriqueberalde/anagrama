using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    public static class AnagramaResolver
    {

        public static List<string> Resolve(string word)
        {
            return Calc(word);
        }

        public static List<string> Calc(string word)
        {
            Console.WriteLine("Received: " + word);

            var result = new List<string>();

            if (word.Length == 1)
                return new List<string> { word };

            var hold = word.Substring(0, 1);
            var aux = Calc(word.Substring(1, word.Length - 1));

            foreach (var item in aux)
            {
                for (int i = 0; i <= item.Length; i++)
                {
                    var str = "";
                    for (int j = 0; j <= item.Length; j++)
                    {
                        if (j == i)
                            str += hold;

                        if (j == item.Length)
                            continue;

                        str += item[j];
                    }
                    result.Add(str);
                }
            }
            Console.WriteLine("Returned: [" + string.Join(", ", result.ToList()) + "]");
            return result;
        }

        public static int Factorial(int n)
        {
            var r = n;
            for (int i = n - 1; i > 0; i--)
                r *= i;

            return r;
        }
    }
}
