namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class GetVowelPositions
    {
        [TestMethod]
        public void GetVowelPositionsTest()
        {
            var str = "RankHacker";
            var arr = GetVowelPositionsMethod(str);
        }

        private List<int> GetVowelPositionsMethod(string s)
        {
            List<int> result = new List<int>();
            // TODO: implement solution
            List<char> vowels = new List<char>() { 'A', 'E', 'I', 'O', 'U' };


            for (int j = 0; j < s.Length; j++)
            {
                Console.WriteLine($"AAA:::{s[j].ToString()}");
                for (int i = 0; i < vowels.Count; i++)
                {
                    if (Char.ToLower(s[j]) == Char.ToLower(vowels[i]))
                    {
                        result.Add(j);
                    }

                }

            }

            return result;
        }

    }
}
