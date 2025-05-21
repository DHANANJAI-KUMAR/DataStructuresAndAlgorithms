namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ReverseString
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            var reverseString = ReverseStringMethod(input);
            Console.WriteLine($"reverseString:: {reverseString}.");
        }
        private string ReverseStringMethod(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

    }
}
