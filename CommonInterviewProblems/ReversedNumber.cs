namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ReversedNumber
    {
        [TestMethod]
        public void ReversedNumberTest()
        {
            int number = 123456;
            int reversed = 0;

            while (number != 0)
            {
                int reminder = number % 10;
                reversed = (reversed * 10) + reminder;
                number = number / 10;
            }

            Console.WriteLine(reversed);
        }
    }
}
