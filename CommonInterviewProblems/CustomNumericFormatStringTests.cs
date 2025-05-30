using System.Globalization;

namespace CommonInterviewProblems
{
    /* 
     * //https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
     *  The "0" custom specifier
        The "#" custom specifier
        The "." custom specifier
        The "," custom specifier
        The "%" custom specifier
        The "‰" custom specifier
        The "E" and "e" custom specifiers
        The "\" escape character
        The ";" section separator
     * 
     */
    [TestClass]
    public class CustomNumericFormatStringTests
    {
        
        [TestMethod]
        public void ZeroCustomSpecifierTest()
        {
            /* 
             * The "0" custom format specifier serves as a zero-placeholder symbol. 
             * If the value that is being formatted has a digit in the position where the zero appears in the format string, 
             * that digit is copied to the result string; otherwise, a zero appears in the result string. The position of the 
             * leftmost zero before the decimal point and 
             * the rightmost zero after the decimal point determines the range of digits that are always present in the result string.
             */
            double value;

            value = 123;
            Console.WriteLine(value.ToString("00000"));
            Console.WriteLine(String.Format("{0:00000}", value));
            // Displays 00123

            value = 1.2;
            Console.WriteLine(value.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", value));
            // Displays 1.20

            Console.WriteLine(value.ToString("00.00", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:00.00}", value));
            // Displays 01.20

            CultureInfo daDK = CultureInfo.CreateSpecificCulture("da-DK");
            Console.WriteLine(value.ToString("00.00", daDK));
            Console.WriteLine(String.Format(daDK, "{0:00.00}", value));
            // Displays 01,20

            value = .56;
            Console.WriteLine(value.ToString("0.0", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.0}", value));
            // Displays 0.6

            value = 1234567890;
            Console.WriteLine(value.ToString("0,0", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0}", value));
            // Displays 1,234,567,890

            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            Console.WriteLine(value.ToString("0,0", elGR));
            Console.WriteLine(String.Format(elGR, "{0:0,0}", value));
            // Displays 1.234.567.890

            value = 1234567890.123456;
            Console.WriteLine(value.ToString("0,0.0", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0.0}", value));
            // Displays 1,234,567,890.1

            value = 1234.567890;
            Console.WriteLine(value.ToString("0,0.00", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", value));
            // Displays 1,234.57
        }


        [TestMethod]
        public void HashCustomSpecifierTest()
        {
            /* The "#" custom format specifier serves as a digit-placeholder symbol. If the value that is being formatted has a digit in the position where the "#" symbol appears in the format string, that digit is copied to the result string. Otherwise, nothing is stored in that position in the result string.

                Note that this specifier never displays a zero that is not a significant digit, even if zero is the only digit in the string. It will display zero only if it is a significant digit in the number that is being displayed.

                The "##" format string causes the value to be rounded to the nearest digit preceding the decimal, where rounding away from zero is always used. For example, formatting 34.5 with "##" would result in the value 35.
            */
            double value;

            value = 1.2;
            Console.WriteLine(value.ToString("#.##", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#.##}", value));
            // Displays 1.2

            value = 123;
            Console.WriteLine(value.ToString("#####"));
            Console.WriteLine(String.Format("{0:#####}", value));
            // Displays 123

            value = 123456;
            Console.WriteLine(value.ToString("[##-##-##]"));
            Console.WriteLine(String.Format("{0:[##-##-##]}", value));
            // Displays [12-34-56]

            value = 1234567890;
            Console.WriteLine(value.ToString("#"));
            Console.WriteLine(String.Format("{0:#}", value));
            // Displays 1234567890

            Console.WriteLine(value.ToString("(###) ###-####"));
            Console.WriteLine(String.Format("{0:(###) ###-####}", value));
            // Displays (123) 456-7890

            Double value1 = .324;
            Console.WriteLine("The value is: '{0,5:#.###}'", value1);

        }


        [TestMethod]
        public void DecimalCustomSpecifierTest()
        {
            /* 
             * The "." custom format specifier inserts a localized decimal separator into the result string. 
             * The first period in the format string determines the location of the decimal separator in the 
             * formatted value; any additional periods are ignored. If the format specifier ends with a "." 
             * only the significant digits are formatted into the result string.
             */
            double value;

            value = 1.2;
            Console.WriteLine(value.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", value));
            // Displays 1.20

            Console.WriteLine(value.ToString("00.00", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:00.00}", value));
            // Displays 01.20

            Console.WriteLine(value.ToString("00.00", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine(String.Format(CultureInfo.CreateSpecificCulture("da-DK"), "{0:00.00}", value));
            // Displays 01,20

            value = .086;
            Console.WriteLine(value.ToString("#0.##%", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", value));
            // Displays 8.6%

            value = 86000;
            Console.WriteLine(value.ToString("0.###E+0", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.###E+0}", value));
            // Displays 8.6E+4
            //
        }


        [TestMethod]
        public void CommaCustomSpecifierAsGroupSeparatorTest()
        {
            /* The "," character serves as both a group separator and a number scaling specifier.

                Group separator: If one or more commas are specified between two digit placeholders (0 or #) that format the integral digits of a number, a group separator character is inserted between each number group in the integral part of the output.

                The NumberGroupSeparator and NumberGroupSizes properties of the current NumberFormatInfo object determine the character used as the number group separator and the size of each number group. For example, if the string "#,#" and the invariant culture are used to format the number 1000, the output is "1,000".

                Number scaling specifier: If one or more commas are specified immediately to the left of the explicit or implicit decimal point, the number to be formatted is divided by 1000 for each comma. For example, if the string "0,," is used to format the number 100 million, the output is "100".

                You can use group separator and number scaling specifiers in the same format string. For example, if the string "#,0,," and the invariant culture are used to format the number one billion, the output is "1,000".
            */

            double value = 1234567890;
            Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,#}", value));
            // Displays 1,234,567,890

            Console.WriteLine(value.ToString("#,##0,,", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,##0,,}", value));
            // Displays 1,235

        }

        [TestMethod]
        public void CommaCustomSpecifierWithNumberScalingTest()
        {
            /* The "," character serves as both a group separator and a number scaling specifier.

                Group separator: If one or more commas are specified between two digit placeholders (0 or #) that format the integral digits of a number, a group separator character is inserted between each number group in the integral part of the output.

                The NumberGroupSeparator and NumberGroupSizes properties of the current NumberFormatInfo object determine the character used as the number group separator and the size of each number group. For example, if the string "#,#" and the invariant culture are used to format the number 1000, the output is "1,000".

                Number scaling specifier: If one or more commas are specified immediately to the left of the explicit or implicit decimal point, the number to be formatted is divided by 1000 for each comma. For example, if the string "0,," is used to format the number 100 million, the output is "100".

                You can use group separator and number scaling specifiers in the same format string. For example, if the string "#,0,," and the invariant culture are used to format the number one billion, the output is "1,000".
            */

            double value = 1234567890;
            Console.WriteLine(value.ToString("#,,", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,,}", value));
            // Displays 1235

            Console.WriteLine(value.ToString("#,,,", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,,,}", value)); 
            // Displays 1

            Console.WriteLine(value.ToString("#,##0,,", CultureInfo.InvariantCulture));
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,##0,,}", value));
            // Displays 1,235

        }


    }

}