using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public class SumOfTwoLargeNumbersAsStrings
    {
        [TestMethod]
        public void SumOfTwoLargeNumbersAsStringsTest()
        {
            string s1 = "7777555511111111", s2 = "3332222221111";
            var sum = findSum(s1, s2);
            //7780887733332222
            Console.WriteLine();
        }

        private string findSum(string s1, string s2)
        {
            // If one string is empty, return the other
            if (s1.Length == 0) return s2;
            if (s2.Length == 0) return s1;

            // Result string to store the sum
            var sb = new StringBuilder();

            // Indices to traverse strings from end
            int i = s1.Length - 1;
            int j = s2.Length - 1;

            // Carry to handle digit sum > 9
            int carry = 0;

            // Traverse both strings from end
            while (i >= 0 || j >= 0 || carry > 0)
            {

                // Get current digits (0 if string exhausted)
                int digit1 = (i >= 0) ? int.Parse(s1[i].ToString()) : 0;
                int digit2 = (j >= 0) ? int.Parse(s2[j].ToString()) : 0;

                // Sum current digits and carry
                int sum = digit1 + digit2 + carry;

                // Update carry and current digit
                carry = sum / 10;
                var reminder = sum % 10;
                sb.Append(reminder);

                // Move indices
                i--;
                j--;
            }

            char[] charArray = sb.ToString().ToArray<char>();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        private string findSumMy(string s1, string s2)
        {
            var sb = "";
            int carry = 0;
            var maxLength = Math.Max(s1.Length, s2.Length);
            s2 = s2.PadLeft(maxLength, '0');
            s1 = s1.PadLeft(maxLength, '0');
            for (int i = maxLength - 1; i >= 0; i--)
            {
                var digit1 = (i <= s1.Length) ? int.Parse(s1[i].ToString()) : 0;
                var digit2 = (i <= s2.Length) ? int.Parse(s2[i].ToString()) : 0;
                
                var sum = digit1 + digit2 + carry;
                carry = sum / 10;
                var reminder = sum % 10;
                sb = reminder + sb;
                
            }
            
            if(carry > 0) sb = carry + sb;

            return sb.ToString();

        }
    }
}