namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class ArmstrongNumber
    {
        [TestMethod]
        public void ArmstrongNumberTest()
        {

            //1³ + 5³ + 3³ = 153
            //9^4 + 4^4 + 7^4 + 4^4 =6561+256+2401+256=9474
            var status = IsArmstrongNumber(153);
            status = IsArmstrongNumber(9474);
            
        }

        public bool IsArmstrongNumber(int number)
        {
            int originalNumber = number;
            int digits = 0;
            int sum = 0;

            // Step 1: Count digits
            int temp = number;
            while (temp > 0)
            {
                digits++;
                temp = temp / 10;
            }

            // Step 2: Calculate Armstrong sum
            temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum = sum + (int)Math.Pow(digit, digits);
                temp = temp / 10;
            }

            // Step 3: Check result
            return sum == originalNumber;
        }


    }
}
