namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class FirstNonRepeatingCharacter
    {
        [TestMethod]
        public void FirstNonRepeatingCharacterTest()
        {
            var str = "geeksforgeeks";
            var uniqueChar = FirstNonRepeatingCharacterMethod(str);
            Console.WriteLine(uniqueChar);

        }

        private char FirstNonRepeatingCharacterMethod(string str)
        {
            var uniqueChar = '$';
            for (int i = 0; i < str.Length; i++)
            {
                var found = false;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    uniqueChar = str[i];
                    break;
                }
            }

            return uniqueChar;
        }

    }
}
