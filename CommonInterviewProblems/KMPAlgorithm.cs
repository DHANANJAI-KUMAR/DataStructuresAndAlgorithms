using System.Security.Cryptography;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class KMPAlgorithm
    {
        [TestMethod]
        public void KMPAlgorithmTest()
        {
            //string text = "ABABDABACDABABCABABPDHANANJAIABABCABABKUMARABABCABABABCABAB";
            //string pattern = "ABABCABAB";
            string text = "AABAACAADAABAABA";
            string pattern = "AABA";

            List<int> indices = NaivePatternSearch(text, pattern);
            Console.WriteLine("Pattern found at indices:");
            foreach (int index in indices)
            {
                Console.WriteLine("Pattern found at index: " + index);
            }

            List<int> occurrences = KMPSearch(pattern, text);
            Console.WriteLine("Pattern found at indices:");
            foreach (int index in occurrences)
            {
                Console.WriteLine("Pattern found at index: " + index);
            }

        }

        
        public static List<int> NaivePatternSearch(string text, string pattern)
        {
            List<int> indices = new List<int>();
            Console.WriteLine($"text Len: {text.Length}");
            Console.WriteLine($"pattern Len: {pattern.Length.ToString()}");

            // Iterate through the text
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                Console.WriteLine($"indices i: {i.ToString()}");
                int j;

                // Check if pattern matches at the current index
                for (j = 0; j < pattern.Length; j++)
                {
                    Console.WriteLine($"j: { j.ToString()}");
                    if (text[i + j] != pattern[j])
                        break;
                }

                // If the inner loop completed without breaking, the pattern was found
                if (j == pattern.Length)
                    indices.Add(i);
            }

            return indices;
        }

        public List<int> KMPSearch(string pattern, string text)
        {
            //youtube => KMP Algorithm | Searching for Patterns | GeeksforGeeks
            List<int> occurrences = new List<int>();

            int[] lps = ComputeLPSArray(pattern);

            int i = 0;  // index for text
            int j = 0;  // index for pattern

            while (i < text.Length)
            {/*w  w   w .   d  e  m o   2  s   .c  o  m  */
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == pattern.Length)
                {
                    occurrences.Add(i - j);
                    j = lps[j - 1];
                }
                else if (i < text.Length && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }

            return occurrences;
        }

        private int[] ComputeLPSArray(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int len = 0;
            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }


        


    }

}
