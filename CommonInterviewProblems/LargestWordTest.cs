using DataStructures.BaseClass;
using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public class LargestWordTest
    {
        [TestMethod]
        public void LargestWordByDeletingSomeCharactersOfGivenStringTest()
        {
            Console.WriteLine("AAAA");

            var dict = new List<string> { "ale", "apple", "monkey", "plea" };
            dict = new List<string> { "pintu", "geeksfor", "geeksgeeks", " forgeek" };
            string str = "sabpcplea";
            str = "geeksforgeeks";

            var longestWord = LongestWord(dict, str);
            Console.WriteLine();


        }

        private string LongestWord(List<string> dict, string str)
        {
            string longestWord = "";
            foreach (string word in dict)
            {
                if (longestWord.Length < word.Length && IsSubSequence(word, str))
                {
                    longestWord = word;
                }

                //var sb = new StringBuilder();
                //int j= 0;
                //for (int i = 0; i < word.Length; i++)
                //{
                //    while(j < str.Length)
                //    {
                //        if (word[i] == str[j])
                //        {
                //            sb.Append(word[i]);
                //            j++;
                //            break;
                //        }
                //        j++;
                //    }
                //}

                //if (word == sb.ToString() && word.Length > longestWord.Length) 
                //{
                //    longestWord = word;
                //}

            }

            return longestWord;
        }

        private bool IsSubSequence(string s1, string s2)
        {
            int j = 0;
            for (int i = 0; i < s2.Length && j < s1.Length; i++)
            {
                if (s1[j] == s2[i])
                {
                    j++;
                }
            }
            return j == s1.Length;
        }

    }

}