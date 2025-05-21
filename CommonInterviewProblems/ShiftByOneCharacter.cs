using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ShiftByOneCharacter
    {
        [TestMethod]
        public void ShiftByOneCharacterTest()
        {
            var str = "RanckerHack";
            var result = ShiftByOneCharacterMethod(str);
        }


        private string ShiftByOneCharacterMethod(string s)
        {
            StringBuilder sb = new StringBuilder();
            // TODO: Implement the solution here
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"AAA:::{(int)s[i]}");
                Char A = 'A';
                Console.WriteLine($"AAA:::{(int)A}");
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    char shiftedChar;
                    if (c == 'z')
                    {
                        shiftedChar = 'a';
                    }
                    else if (c == 'Z')
                    {
                        shiftedChar = 'A';
                    }
                    else
                    {
                        shiftedChar = (char)(c + 1);
                    }
                    sb.Append(shiftedChar);
                }
                else
                {
                    sb.Append(c);
                }

            }

            return sb.ToString();
        }


    }
}
