namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class PolydromeString
    {
        [TestMethod]
        public void PolydromeStringTest()
        {
            string input = "racecar";

            int palindromeCount = CountPalindromicSubstrings(input);
            Console.WriteLine($"Found {palindromeCount} palindromic substrings.");

            if (palindromeCount > 1)
                Console.WriteLine("This is a polydrome!");
            else
                Console.WriteLine("This is not a polydrome.");
            
        }

        private int CountPalindromicSubstrings(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    string sub = input.Substring(i, j - i);
                    if (sub.Length > 1 && IsPalindrome(sub))
                        count++;
                }
            }
            return count;
        }

        private bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left++] != s[right--])
                    return false;
            }
            return true;
        }


    }
}
