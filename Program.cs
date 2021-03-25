using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_data_algorithms_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            long res = repeatedString("a", 1000000000000);

            watch.Stop();
            Console.WriteLine(res);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.Read();
        }

        #region -- Simple-Superreduced
        // Complete the superReducedString function below.
        static string superReducedString(string s)
        {
            //input s="aaabccddd" = "abd"              
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Remove(i, 2);
                        i = -1;
                    }
                }
            }
            if (s.Length == 0)
            {
                return "Empty String";
            }
            return s;
        }
        #endregion

        #region --RepeatedString
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            // input aba n =10, a=7 abaabaabaa
            int result = 0;
            int j = 0;
            List<char> input = new List<char>();
            for (int i = 0; i < n; i++)
            {
                if (s.Length == j)
                {
                    j = 0;
                }
                input.Add(s[j]);                
                j++;
                if(input[i]== 'a')
                {
                    result++;
                }
            }
            return result;
        }
        #endregion
    }
}
