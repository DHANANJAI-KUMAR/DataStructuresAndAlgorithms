namespace CommonInterviewProblems
{
    [TestClass]
    public class DecimalToRoman
    {
        [TestMethod]
        public void DecimalToRomanTest()
        {
            int number = 4579;
            
            string res = ToRoman(number);

            Console.WriteLine("AAAA");
        }

        static int romanToDecimal(string s) {
      
        // Create a map to store the Roman numeral values
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int res = 0;
        for (int i = 0; i < s.Length; i++) {
          
            // If the current value is less than the next value, 
            // subtract current from next and add to res
            if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]]) {
                res += romanMap[s[i + 1]] - romanMap[s[i]];

                // Skip the next symbol
                i++;
            }
            else {
                
                // Otherwise, add the current value to res
                res += romanMap[s[i]];
            }
        }

        return res;
    }

        public string ToRoman(int x)
        {
            // array of values and symbols
            int[] baseValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] symbols = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

            string res = "";
            int i = baseValues.Length - 1;

            while (x > 0)
            {
                var div = x / baseValues[i];
                
                while (div > 0)
                {
                    res = res + symbols[i];
                    div--;
                }
                x = x % baseValues[i];
                i--;
            }

            return res;

        }

    }

}