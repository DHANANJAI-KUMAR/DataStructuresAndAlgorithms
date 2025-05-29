namespace CommonInterviewProblems
{
    [TestClass]
    public class RomanToDecimal
    {
        [TestMethod]
        public void RomanNumberToIntegerTest()
        {
            var romanNumber = "IX";     //10 - 1
            //var romanNumber = "XI";   //10 + 1
            romanNumber = "MXVII"; //For example MXVII is 1000 + 10 + 5 + 1 + 1 = 1017.
            romanNumber = "XLVII";  //And XLVII is (50 - 10) + 5 + 1 + 1 = 47.
            var number = RomanToDecimalGood(romanNumber);
            var number1 = RomanToDecimalMethod(romanNumber);
            Console.WriteLine("AAAA");
        }

        private int RomanToDecimalGood(string s)
        {

            // Create a map to store the Roman numeral values
            Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {

                // If the current value is less than the next value, 
                // subtract current from next and add to res
                if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    res += romanMap[s[i + 1]] - romanMap[s[i]];

                    // Skip the next symbol
                    i++;
                }
                else
                {

                    // Otherwise, add the current value to res
                    res += romanMap[s[i]];
                }
            }

            return res;
        }


        private int RomanToDecimalMethod(string s)
        {
             
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Get value of current symbol
                int s1 = value(s[i]);

                // Compare with the next symbol if it exists
                if (i + 1 < s.Length)
                {
                    int s2 = value(s[i + 1]);

                    // If current value is greater or equal, add it to result
                    if (s1 >= s2)
                    {
                        res += s1;
                    }
                    else
                    {
                        // Else, add the difference and skip next symbol
                        res += (s2 - s1);
                        i++;
                    }
                }
                else
                {
                    res += s1;
                }
            }

            return res;
        }


        int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }

    }

}