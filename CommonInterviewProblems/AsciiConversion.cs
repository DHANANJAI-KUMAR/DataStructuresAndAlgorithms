using System.Text;

namespace CommonInterviewProblems
{
    [TestClass]
    public class AsciiConversion
    {
        [TestMethod]
        public void AsciiConversionTest()
        {
            Console.WriteLine("AAAA");
            var aa = solution(29);
            string s = "The quick brown fox jumps over the lazy dog";
            var upperCaseStr = ConvertToUpperCase(s);
            var lowerCaseStr = ConvertToLowerCase(s);
            //AzciiToIntPangram();

        }
        int solution(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            return sum;
        }


        private void AzciiToIntPangram()
        {
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine($"Character {ch} has ASCII {(int)ch}");  
            }

            for (int ascii = 'a'; ascii <= 'z'; ascii++)
            {
                Console.WriteLine($"ASCII {ascii} has Character {(char)ascii}");
            }

        }

        private void FindLowerAndUpperCase(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z') 
                { 
                    /* lowercase letter */ 
                }
                if (c >= 'A' && c <= 'Z') 
                { 
                    /* uppercase letter */ 
                }
            }
        }

        private string ConvertToUpperCase(string s)
        {
            var sb = new StringBuilder();
            //'A' = 65, 'a' = 97
            int diff = (int)'a' - (int)'A';
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    int lower = (int)c - diff;
                    sb.Append((char)lower);
                }
                else
                    sb.Append(c);
            }
            return sb.ToString();   
        }

        private string ConvertToLowerCase(string s)
        {
            var sb = new StringBuilder();
            //'A' = 65, 'a' = 97
            int diff = (int)'a' - (int)'A';
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'A' && c <= 'Z')
                {
                    int lower = (int)c + diff;
                    sb.Append((char)lower);
                }
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

    }

}