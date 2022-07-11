using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace New.Features
{
    [TestClass]
    //C# 8.0 is supported on .NET Core 3.x and .NET Standard 2.1.
    //https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8
    public class WhatsNewCsharp8Tests 
    {

        [TestInitialize]
        public void InitialSetup()
        {

        }


        [TestMethod]
        public async Task SwitchExpressionsTest()
        {
            var exp1 = Switch_Expressions(Rainbow.Indigo);
            var exp2 = Switch_PropertyPatterns(new Address { State = "MI"}, (decimal)10);
            var exp3 = Switch_TuplePatterns("paper", "scissors");
            var exp4 = Switch_PositionalPatterns(new Point1(-100, -20));

        }

        [TestMethod]
        public async Task UsingDeclarationsTest()
        {
            IEnumerable<string> lines = new List<string> { "Hello", "World" };
            WriteLinesToFile(lines);
        }

        [TestMethod]
        public async Task AsynchronousStreams()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }


        [TestMethod]
        public async Task IndicesandRangesTest()
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            Console.WriteLine($"The last word is {words[^1]}");
            // writes "dog"

            var quickBrownFox = words[1..4];

            var lazyDog = words[^2..^0];

            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            Range phrase = 1..4;

            var text = words[phrase];
        }



        [TestMethod]
        public async Task NullCoalescingAssignment()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }


        private RGBColor Switch_Expressions(Rainbow colorBand) =>
           colorBand switch
           {
               Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
               Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
               Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
               Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
               Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
               Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
               Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
               _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
           };


        private decimal Switch_PropertyPatterns(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                _ => 0M
            };

        private string Switch_TuplePatterns(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };


        private Quadrant Switch_PositionalPatterns(Point1 point) 
            => point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                var (_, _) => Quadrant.OnBorder,
                _ => Quadrant.Unknown
            };


        private int WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }


        private async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }


    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";


        //public readonly void Translate(int xOffset, int yOffset)
        //{
        //    X += xOffset;
        //    Y += yOffset;
        //}
    }


    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    public class Point1
    {
        public int X { get; }
        public int Y { get; }

        public Point1(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }

    public class RGBColor
    {
        private int Red;
        private int Green;
        private int Blue;

        public RGBColor(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }

    public class Address
    {
        public string State { get; set; }

    }

}