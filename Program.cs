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
    }
}
