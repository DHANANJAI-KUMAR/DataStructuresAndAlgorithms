namespace CommonInterviewProblems
{
    [TestClass]
    public class PangramString
    {
        [TestMethod]
        public void PangramStringTest()
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (checkPangramGood(s) == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.WriteLine("AAAA");
        }

        private bool checkPangramGood(string s)
        {
            const int MAX_CHAR = 26;
            bool[] vis = new bool[MAX_CHAR];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'A' && c <= 'Z')
                    vis[c - 'A'] = true;
                else if (c >= 'a' && c <= 'z')
                    vis[c - 'a'] = true;
            }
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (!vis[i])
                    return false;
            }
            return true;
        }


        private bool checkPangram(string s)
        {
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                bool found = false;

                for (int i = 0; i < s.Length; i++)
                {
                    if (ch == Char.ToLower(s[i]))
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    return false;
            }
            return true;
        }

    }

}