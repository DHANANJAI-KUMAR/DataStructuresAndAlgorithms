using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public class ReplaceAllOccurrencesOfSubstring
    {
        [TestMethod]
        public void ReplaceAllOccurrencesOfSubstringTest()
        {
            //https://www.geeksforgeeks.org/find-and-replace-all-occurrence-of-a-substring-in-the-given-string/
            string input = "My Cat dog Cat abc.", oldSub = "Cat", newSub = "lion";
            var newStr = ReplaceAllBetter(input, oldSub, newSub);
            Console.WriteLine(newStr);

        }
        
        private string ReplaceAllBetter(string input, string oldSub, string newSub)
        {
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i <= (input.Length - oldSub.Length) && input.Substring(i, oldSub.Length) == oldSub)
                {
                    result.Append(newSub);

                    // Skip the characters of s1
                    i += oldSub.Length-1;
                }
                else
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }


        private string ReplaceAll(string input, string oldSub, string newSub)
        {
            if (string.IsNullOrEmpty(oldSub))
                return input; // Avoid infinite loop

            var result = new StringBuilder();

            int i = 0;
            while (i < input.Length - oldSub.Length)
            {
                var part = input.Substring(i, oldSub.Length);
                // Match found
                if (part == oldSub)
                {
                    Console.WriteLine("FOUNT");
                    result.Append(newSub);
                    i = i + oldSub.Length;
                }
                else
                {
                    result.Append(input[i]);
                    i++;
                }
            }

            // Append remaining characters
            result.Append(input.Substring(i));
            return result.ToString();
        }


    }

}