using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ReverseString
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            string input = "i.like.this.program.very.much";

            var reverseString = ReverseStringWords(input);

            Console.WriteLine($"reverseString:: {reverseString}.");
        }

        private string ReverseStringWords(string str)
        {
            var stck = new Stack<string>();
            var word = "";

            for (int i = 0; i < str.Length; i++)
            {
                word += str[i];
                if (str[i] == '.')
                { 
                    stck.Push(word.ToString());
                    word = "";
                }
                
                if (i == str.Length - 1)
                {
                    stck.Push(word + ".");
                }
            }

            var reversed = new StringBuilder();
            while (stck.Count > 0)
            {
                reversed.Append(stck.Pop());
            }
            return reversed.ToString().Trim('.');
        }

        private string ReverseStringMethod1(string str)
        {
            var stck = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stck.Push(str[i]);
            }
            
            StringBuilder reversed = new StringBuilder();
            while(stck.Count > 0)
            {
                reversed.Append(stck.Pop());
            }
            return reversed.ToString();
        }


        private string ReverseStringMethod(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }

    }
}
