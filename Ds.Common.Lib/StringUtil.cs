using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public class StringUtil
    {
        // Utility function to find the common prefix between strings s1 and s2
        public static string CommonPrefix1(string s1, string s2)
        {
            var res = new StringBuilder();
            for (int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                if (s1[i] != s2[i])
                    break;
                res.Append(s1[i]);
            }

            return res.ToString();
        }

        //public static string CommonPrefix2(string s1, string s2)
        //{
        //    //Return the common prefix
        //    var res = new StringBuilder();
        //    int minLength = Math.Min(s1.Length, s2.Length);
        //    int i = 0;
        //    // Find the common prefix between the first and last strings
        //    while (i < minLength && s1[i] == s2[i])
        //    {
        //        res.Append(s1[i]);
        //        i++;
        //    }

        //    return res.ToString();
        //}


    }
}
