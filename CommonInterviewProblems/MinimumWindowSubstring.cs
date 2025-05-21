namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class MinimumWindowSubstring
    {
        [TestMethod]
        public void MinimumWindowSubstringTest()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";
            string result4 = MinWindow(s, t);
            Console.WriteLine(result4); // Output: BANC

        }

        string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";

            var targetCount = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!targetCount.ContainsKey(c))
                    targetCount[c] = 0;
                targetCount[c]++;
            }

            var windowCount = new Dictionary<char, int>();
            int have = 0, need = targetCount.Count;
            int left = 0, minLen = int.MaxValue, minStart = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];
                if (!windowCount.ContainsKey(c)) windowCount[c] = 0;
                windowCount[c]++;

                if (targetCount.ContainsKey(c) && windowCount[c] == targetCount[c])
                {
                    have++;
                }

                while (have == need)
                {
                    // Update min window
                    if (right - left + 1 < minLen)
                    {
                        minLen = right - left + 1;
                        minStart = left;
                    }

                    // Shrink window
                    char leftChar = s[left];
                    windowCount[leftChar]--;
                    if (targetCount.ContainsKey(leftChar) && windowCount[leftChar] < targetCount[leftChar])
                    {
                        have--;
                    }
                    left++;
                }
            }

            return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
        }
    }
}
