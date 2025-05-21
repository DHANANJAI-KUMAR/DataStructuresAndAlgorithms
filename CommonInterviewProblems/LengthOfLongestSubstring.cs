using System.Linq;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class LengthOfLongestSubstring
    {
        [TestMethod]
        public void LengthOfLongestSubstringTest()
        {
            //Use Sliding Window
            //Efficient: It avoids reprocessing the same data multiple times.
            //Time complexity: Often brings brute - force O(n²) down to O(n).
            //Common uses: Substrings, subarrays, sums, averages, longest / shortest ranges.

            var str = "abcabcbb";
            var result = LengthOfLongestSubstringMethod(str);
            Assert.AreEqual(3, result);

            str = "pwwkew";
            result = LengthOfLongestSubstringMethod(str);
            Assert.AreEqual(3, result);

            str = " ";
            result = LengthOfLongestSubstringMethod(str);
            Assert.AreEqual(1, result);

            str = "";
            result = LengthOfLongestSubstringMethod(str);
            Assert.AreEqual(0, result);

        }

        public int LengthOfLongestSubstringMethod(string s)
        {
            var seen = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }

                seen.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }



        public int LengthOfLongestSubstringMy(string s)
        {
            List<char> list = new List<char>();
            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                {
                    if (maxLength < list.Count) 
                    { 
                        maxLength = list.Count;
                    }

                    list.Clear();
                }
                list.Add(s[i]);

            }
            return maxLength;
        }

    }
}
