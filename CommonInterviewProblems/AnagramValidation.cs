namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class AnagramValidation
    {
        [TestMethod]
        public void ValidAnagramTest()
        {
            string s1 = "listen";
            string s2 = "silent";
            //string s1 = "racecar";
            //string s2 = "carrace";

            if (IsAnagram(s1, s2))
                Console.WriteLine($"\"{s1}\" and \"{s2}\" are anagrams.");
            else
                Console.WriteLine($"\"{s1}\" and \"{s2}\" are not anagrams.");

        }


        bool IsAnagram(string s, string t)
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
