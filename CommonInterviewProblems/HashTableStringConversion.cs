namespace CommonInterviewProblems
{
    [TestClass]
    public class HashTableStringConversion
    {
        [TestMethod]
        public void HashTableStringConversionTest()
        {
            string hashtableString = "{key1=value1, key2=value2, key3=value3}";

            // Remove surrounding braces and split by comma
            hashtableString = hashtableString.Trim('{', '}');
            string[] pairs = hashtableString.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            List<string> tupleList = new List<string>();

            foreach (string pair in pairs)
            {
                string[] keyValue = pair.Split('=');
                if (keyValue.Length == 2)
                {
                    tupleList.Add($"({keyValue[0]}, {keyValue[1]})");
                }
            }

            string result = string.Join(", ", tupleList);

            Console.WriteLine(result);

            //[(key1, value1), (key2, value2), (key3, value3)]
            Console.WriteLine("AAAA");
        }

    }

}