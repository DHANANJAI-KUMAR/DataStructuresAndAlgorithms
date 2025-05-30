using Newtonsoft.Json.Linq;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CommonInterviewProblems
{
    //https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#standard-format-specifiers
    /*
     * "B" or "b"	Binary	Result: A binary string.
     * "C" or "c"	Currency	Result: A currency value
     * "D" or "d"	Decimal	Result: Integer digits with optional negative sign.
     * "E" or "e"	Exponential (scientific)	Result: Exponential notation.
     * "F" or "f"	Fixed-point	Result: Integral and decimal digits with optional negative sign.
     * "G" or "g"	General	Result: The more compact of either fixed-point or scientific notation.
     * "N" or "n"	Number	Result: Integral and decimal digits, group separators, and a decimal separator with optional negative sign.
     * "P" or "p"	Percent	Result: Number multiplied by 100 and displayed with a percent symbol.
     * "R" or "r"	Round-trip	Result: A string that can round-trip to an identical number.
     * "X" or "x"	Hexadecimal	Result: A hexadecimal string.
     * 
     */

    [TestClass]
    public class StandardNumericFormatStringTests
    {

        [TestMethod]
        public void CurrencyFormatSpecifierTest()
        {
            decimal value = 123.456m;
            Console.WriteLine(value.ToString("C2"));
            // Displays $123.46

            value = 123.456m;
            Console.WriteLine($"Your account balance is {value:C2}.");
            // Displays "Your account balance is $123.46."

            decimal[] amounts = { 16305.32m, 18794.16m };
            Console.WriteLine("   Beginning Balance           Ending Balance");
            Console.WriteLine("   {0,-28:C2}{1,14:C2}", amounts[0], amounts[1]);
            // Displays:
            // Beginning Balance           Ending Balance
            // $16,305.32                      $18,794.16

            // current culture is English (United States):
            double value1 = 12345.6789;
            Console.WriteLine(value1.ToString("C", CultureInfo.CurrentCulture));
            //$12,345.68

            Console.WriteLine(value1.ToString("C3", CultureInfo.CurrentCulture));
            //$12,345.679

            Console.WriteLine(value1.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));
            //12.345,679 kr

            Console.WriteLine(value1.ToString("C3", CultureInfo.CreateSpecificCulture("en-US")));
            //$12,345.679 

            Console.WriteLine(value1.ToString("C3", CultureInfo.CreateSpecificCulture("fr-FR")));
            //12 345,679 € 

        }


        [TestMethod]
        public void DecimalFormatSpecifierTest()
        {
            /*
             * The "D" (or decimal) format specifier converts a number to a string of decimal digits (0-9), 
             * prefixed by a minus sign if the number is negative. This format is supported only for integral types.
             * 
             * 
             * The precision specifier indicates the minimum number of digits desired in the resulting string. 
             * If required, the number is padded with zeros to its left to produce the number of digits given by the precision specifier. 
             * If no precision specifier is specified, the default is the minimum value required to represent the integer without leading zeros.
            */
            int value;
            value = 12345;
            Console.WriteLine(value.ToString("D"));
            // Displays 12345
            Console.WriteLine(value.ToString("D8"));
            // Displays 00012345

            value = -12345;
            Console.WriteLine(value.ToString("D"));
            // Displays -12345
            Console.WriteLine(value.ToString("D8"));
            // Displays -00012345
        }

        [TestMethod]
        public void FixedPointFormatSpecifierTest()
        {
            /* The fixed-point ("F") format specifier converts a number to a string of the form "-ddd.ddd…" 
             * where each "d" indicates a digit (0-9). 
             * The string starts with a minus sign if the number is negative.
             * 
             */
            int integerNumber;
            integerNumber = 17843;
            Console.WriteLine(integerNumber.ToString("F", CultureInfo.InvariantCulture));
            // Displays 17843.00

            integerNumber = -29541;
            Console.WriteLine(integerNumber.ToString("F3", CultureInfo.InvariantCulture));
            // Displays -29541.000

            double doubleNumber;
            doubleNumber = 18934.1879;
            Console.WriteLine(doubleNumber.ToString("F", CultureInfo.InvariantCulture));
            // Displays 18934.19

            Console.WriteLine(doubleNumber.ToString("F0", CultureInfo.InvariantCulture));
            // Displays 18934

            doubleNumber = -1898300.1987;
            Console.WriteLine(doubleNumber.ToString("F1", CultureInfo.InvariantCulture));
            // Displays -1898300.2

            Console.WriteLine(doubleNumber.ToString("F3", CultureInfo.CreateSpecificCulture("es-ES")));
            // Displays -1898300,199
        }
        
        
        [TestMethod]
        public void NumericFormatSpecifierTest()
        {
            /*The numeric ("N") format specifier converts a number to a string of the form "-d,ddd,ddd.ddd…", 
             * where "-" indicates a negative number symbol if required, "d" indicates a digit (0-9), "," 
             * indicates a group separator, and "." indicates a decimal point symbol. The precision 
             * specifier indicates the desired number of digits after the decimal point. 
             * If the precision specifier is omitted, the number of decimal places is defined 
             * by the current NumberFormatInfo.NumberDecimalDigits property.
             */
            double dblValue = -12445.6789;
            Console.WriteLine(dblValue.ToString("N", CultureInfo.InvariantCulture));
            // Displays -12,445.68
            Console.WriteLine(dblValue.ToString("N1", CultureInfo.CreateSpecificCulture("sv-SE")));
            // Displays -12 445,7

            int intValue = 123456789;
            Console.WriteLine(intValue.ToString("N1", CultureInfo.InvariantCulture));
            // Displays 123,456,789.0

        }

        [TestMethod]
        public void NumbersFormatTest()
        {
            // Display string representations of numbers for en-us culture
            CultureInfo ci = new CultureInfo("en-us");

            // Output floating point values
            double floating = 10761.937554;
            Console.WriteLine($"C: {floating.ToString("C", ci)}");           // Displays "C: $10,761.94"
            Console.WriteLine($"E: {floating.ToString("E03", ci)}");         // Displays "E: 1.076E+004"
            Console.WriteLine($"F: {floating.ToString("F04", ci)}");         // Displays "F: 10761.9376"
            Console.WriteLine($"G: {floating.ToString("G", ci)}");           // Displays "G: 10761.937554"
            Console.WriteLine($"N: {floating.ToString("N03", ci)}");         // Displays "N: 10,761.938"
            Console.WriteLine($"P: {(floating / 10000).ToString("P02", ci)}"); // Displays "P: 107.62 %"
            Console.WriteLine($"R: {floating.ToString("R", ci)}");           // Displays "R: 10761.937554"
            Console.WriteLine();

            // Output integral values
            int integral = 8395;
            Console.WriteLine($"C: {integral.ToString("C", ci)}");           // Displays "C: $8,395.00"
            Console.WriteLine($"D: {integral.ToString("D6", ci)}");          // Displays "D: 008395"
            Console.WriteLine($"E: {integral.ToString("E03", ci)}");         // Displays "E: 8.395E+003"
            Console.WriteLine($"F: {integral.ToString("F01", ci)}");         // Displays "F: 8395.0"
            Console.WriteLine($"G: {integral.ToString("G", ci)}");           // Displays "G: 8395"
            Console.WriteLine($"N: {integral.ToString("N01", ci)}");         // Displays "N: 8,395.0"
            Console.WriteLine($"P: {(integral / 10000.0).ToString("P02", ci)}"); // Displays "P: 83.95 %"
            Console.WriteLine($"X: 0x{integral.ToString("X", ci)}");           // Displays "X: 0x20CB"
            Console.WriteLine();


        }


        [TestMethod]
        public void FormatStringTest2()
        {
            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = "Time of Travel: " + duration.ToString("c");
            Console.WriteLine(output);

            Console.WriteLine($"Time of Travel: {duration:c}");


        }

    }

}