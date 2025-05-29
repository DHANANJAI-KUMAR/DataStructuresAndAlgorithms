namespace CommonInterviewProblems
{
    [TestClass]
    public class MinimumCoins
    {
        [TestMethod]
        public void MinimumCoinsTest()
        {
            int[] coins = { 9, 6, 5, 1 };
            //int amount = 19;
            int amount = 11;

            int result = CoinChange(coins, amount);
            if (result != -1)
                Console.WriteLine($"Minimum coins needed: {result}");
            else
                Console.WriteLine("Cannot make the amount with given coins.");

        }

        private int CoinChange(int[] coins, int amount)
        {
            //https://www.youtube.com/watch?v=KnWorqyDSLA
            int[] dp = new int[amount + 1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    if (dp[i - coin] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }


    }

}