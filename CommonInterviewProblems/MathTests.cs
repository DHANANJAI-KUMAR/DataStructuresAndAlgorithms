namespace CommonInterviewProblems
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void MathTest()
        {
            //Difference between Decimal, Float and Double in .Net
            /*
            Float (Single): 
            It is a floating binary point type variable. Which means it represents a number in it's binary form. 
            Float is a single precision 32 bits(6-9 significant figures) data type. 
            It is used mostly in graphic libraries because of very high demand for processing power, 
            and also in conditions where rounding errors are not very important.

            Double : 
            It is also a floating binary point type variable with double precision and 64 bits size(15-17 significant figures). 
            Double are probably the most generally used data type for real values, except for financial applications and 
            places where high accuracy is desired.

            Decimal : 
            It is a floating decimal point type variable. Which means it represents a number using decimal 
            numbers (0-9). It uses 128 bits(28-29 significant figures) for storing and representing data. 
            Therefore, it has more precision than float and double. They are mostly used in financial applications 
            because of their high precision and easy to avoid rounding errors.
            
             */
            float distance = 123.45f;
            double distance1 = 123.45d;
            decimal balance = 1500.05m;

            

            Console.WriteLine("AAAA");
        }

        [TestMethod]
        public void Math_Round_FunctionTest()
        {
            decimal val = 123.456789m;
            var roundVal = Math.Round(val, 2);  //123.46

            decimal[] values = { 1.15m, 1.25m, 1.35m, 1.45m, 1.55m, 1.65m };
            decimal sum = 0;

            // Calculate true mean.
            foreach (var value in values)
                sum += value;

            Console.WriteLine("True mean:     {0:N2}", sum / values.Length);

            // Calculate mean with rounding away from zero.
            sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.AwayFromZero);

            Console.WriteLine("AwayFromZero:  {0:N2}", sum / values.Length);

            // Calculate mean with rounding to nearest.
            sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.ToEven);

            Console.WriteLine("ToEven:        {0:N2}", sum / values.Length);

            // The example displays the following output:
            //       True mean:     1.40
            //       AwayFromZero:  1.45
            //       ToEven:        1.40

           

        }

        [TestMethod]
        public void RoundValueAndAddTest()
        {
            Console.WriteLine("{0,5} {1,20:R}  {2,12} {3,15}\n",
                    "Value", "Full Precision", "ToEven",
                    "AwayFromZero");
            double value = 11.1;
            for (int ctr = 0; ctr <= 5; ctr++)
                value = RoundValueAndAdd(value);

            Console.WriteLine();

            value = 11.5;
            RoundValueAndAdd(value);
        }

        private static double RoundValueAndAdd(double value)
        {
            Console.WriteLine("{0,5:N1} {0,20:R}  {1,12} {2,15}",
                              value, Math.Round(value, MidpointRounding.ToEven),
                              Math.Round(value, MidpointRounding.AwayFromZero));
            return value + .1;
        }




        [TestMethod]
        public void FloorVsCeilFunctionTest()
        {
            /*Example 1: Find ceil value of 5.534.
            Solution: Ceil value of 5.534 is an just greater than 5.534 i.e. 6.
            So, the ceil value of 5.534 is 6.
            
            Example 2: What is ceil(0.34).
            Solution: Ceil value of 0.34 is integer just greater than 0.34 i.e. 1.
            So, ceil(0.34) is 1.
            */
            double dbValue = Math.Ceiling(2.36);        //parameter double
            decimal dcValue = Math.Ceiling(2.36m);      //parameter decimal

            /*
            Example 1: What is value of floor(86.43)?
            Solution: floor value of 86.43 is integer value just lesser than 86.43 that is 86.
            So, the value of floor(86.43) is 86.
            
            Example 2: What is floor of 67.212?
            Solution: floor of 67.212 is integer just lesser than 67.212 that is 67.
            So, floor of 67.212 is 67.
            */
            double dbValue2 = Math.Floor(2.36); //parameter double
            decimal dcValue2 = Math.Floor(2.36m); //parameter decimal


        }


    }
}