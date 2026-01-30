using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ReverseString
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            string input = "i like this program very much.";

            var reverseString = ReverseStringMethod(input);
            
            var reverseString1 = ReverseStringMethodUsingStack(input);

            Console.WriteLine($"reverseString:: {reverseString}.");
        }

        private string ReverseStringMethod(string str)
        {
            var reversed = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }

        private string ReverseStringMethodUsingStack(string str)
        {
            var stck = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stck.Push(str[i]);
            }

            //return new string(stck.ToArray());

            var reversed = new StringBuilder();
            while (stck.Count > 0)
            {
                reversed.Append(stck.Pop());
            }
            return reversed.ToString();
        }

    }
}
