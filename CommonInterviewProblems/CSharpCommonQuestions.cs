namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class CSharpCommonQuestions
    {
        [TestMethod]
        public void CSharpCommonQuestionsTest()
        {
            // Usage
            Console.WriteLine(IsPalindrome("madam")); // Output: True


            // Usage
            int x = 5, y = 10;
            SwapNumbers(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 10, y: 5


            // Usage
            FindDuplicates(new int[] { 1, 2, 3, 2, 4, 5, 5 }); // Output: 2, 5


            // Usage
            CountCharacterOccurrences("hello");
            // Output: h: 1, e: 1, l: 2, o: 1

            // Usage
            Console.WriteLine(ReverseWords("Hello World")); // Output: "World Hello"

            //How do you filter even numbers from a list using LINQ?
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumbers)); // Output: 2, 4

            //How do you sort a list using LINQ?
            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(", ", sortedNumbers)); // Output: 1, 2, 3, 4, 5

            //How do you implement FizzBuzz in C#?

            for (int i = 1; i <= 100; i++)
            {
                string result = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
                Console.WriteLine(string.IsNullOrEmpty(result) ? i.ToString() : result);
            }

        }


        bool IsPalindrome(string input)
        {
            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }


        void SwapNumbers(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        void FindDuplicates(int[] arr)
        {
            var duplicates = arr.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

            Console.WriteLine(string.Join(", ", duplicates));

        }

        void CountCharacterOccurrences(string input)
        {
            var characterCount = input.GroupBy(c => c)
                                      .ToDictionary(g => g.Key, g => g.Count());
            foreach (var kvp in characterCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        string ReverseWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Reverse());
        }



    }
}
