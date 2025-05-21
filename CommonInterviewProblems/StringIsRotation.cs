namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class StringIsRotation
    {
        [TestMethod]
        public void StringIsRotationTest()
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";

            Console.WriteLine($"Is '{s2}' a rotation of '{s1}'? {IsRotation(s1, s2)}");
        }

        private bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length || s1.Length == 0)
                return false;

            string combined = s1 + s1;
            return combined.Contains(s2);
        }

    }
}
