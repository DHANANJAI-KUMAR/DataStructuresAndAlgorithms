using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ReverseStringWord
    {
        [TestMethod]
        public void ReverseStringWordTest()
        {
            string input = "i.like.this.program.very.much";

            var reverseString = ReverseStringWords(input);
            var reverseString1 = ReverseStringWords1(input);

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
                
                if (i == str.Length-1)
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

        private string ReverseStringWords1(string str)
        {
            var strArr = str.Split('.');
            var reverseStringWord = String.Join(".", strArr.Reverse());
            
            return reverseStringWord + ".";
        }

    }
}
