namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class AnagramValidation
    {
        /*They contain the same characters, Each character appears the same number of times, Order does not matter
        */
        [TestMethod]
        public void ValidAnagramTest()
        {
            string s1 = "anagram"; //listen";
            string s2 = "nagaram"; //"silent";
            //string s1 = "racecar";
            //string s2 = "carrace";

            if (IsAnagrambest(s1, s2))
                Console.WriteLine($"\"{s1}\" and \"{s2}\" are anagrams.");
            else
                Console.WriteLine($"\"{s1}\" and \"{s2}\" are not anagrams.");

            //if (IsAnagramUsingLinq(s1, s2))
            //    Console.WriteLine($"\"{s1}\" and \"{s2}\" are anagrams.");
            //else
            //    Console.WriteLine($"\"{s1}\" and \"{s2}\" are not anagrams.");

        }

        private bool IsAnagrambest(string s, string t)
        {
            if (s?.Length != t?.Length)
                return false;

            int[] count = new int[26];

            foreach (var ch in s)   
            {
                count[(int)(ch - 'a')] = count[(int)(ch - 'a')] + 1;
            }

            foreach (var ch in t)
            {
                if (count[(int)(ch - 'a')] > 0)
                {
                    count[(int)(ch - 'a')] = count[(int)(ch - 'a')] - 1;
                }
                else {
                    return false;
                }
            }
            return true;
        }

        private bool IsAnagramUsingLinq(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            // Convert to character arrays, sort, and compare
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            return sArray.SequenceEqual(tArray);
        }

    }
}
