namespace CommonInterviewProblems
{
    [TestClass]
    public class IsomorphicStringsCheck
    {
        [TestMethod]
        public void IsomorphicStringsCheckTest()
        {
            string s1 = "aab";
            string s2 = "xxy";
            //Input: s1 = "aab", s2 = "xyz"
            //Output: False

            if (AreIsomorphic(s1, s2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        private bool AreIsomorphic(string s1, string s2)
        {
            // If lengths are different, they can't be isomorphic
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var map1 = new Dictionary<char, char>();
            var map2 = new Dictionary<char, char>();

            for (int i = 0; i < s1.Length; i++)
            {
                char c1 = s1[i];
                char c2 = s2[i];

                // Check mapping for s1 to s2
                if (map1.ContainsKey(c1) && map1[c1] != c2)
                {
                    return false;
                }
                map1[c1] = c2;

                // Check mapping for s2 to s1
                if (map2.ContainsKey(c2) && map2[c2] != c1)
                {
                    return false;
                }
                map2[c2] = c1;
            }

            return true;
        }

        

    }

}