namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ParenthesesGenerator
    {
        [TestMethod]
        public void ParenthesesGeneratorTest()
        {
            //Here’s a C# solution that uses backtracking to generate all combinations of valid parentheses for a given number n:
            // How It Works:
            // Uses recursive backtracking
            // Adds '(' if we haven't reached the max open count
            // Adds ')' if there are unmatched '('
            // Stops when the current string reaches 2 * n characters

            var parentheses = GenerateParenthesis(3);

            foreach (var p in parentheses)
            {
                Console.WriteLine(p);
            }
        }


        [TestMethod]
        public void ValidateParenthesesTest()
        {
            string input = "{[()]}";
            Console.WriteLine($"Is '{input}' valid? {IsValid(input)}");
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }


        private IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            Backtrack(result, "", 0, 0, n);
            return result;
        }

        private void Backtrack(List<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max)
            {
                Backtrack(result, current + "(", open + 1, close, max);
            }

            if (close < open)
            {
                Backtrack(result, current + ")", open, close + 1, max);
            }
        }

    }
}
