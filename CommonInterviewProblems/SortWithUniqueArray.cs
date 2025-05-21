using System.Xml;

namespace CommonInterviewProblems
{
    [TestClass]
    public sealed class SortWithUniqueArray
    {
        [TestMethod]
        public void SortWithUniqueArrayTest()
        {
            var lst = new List<int>() { 64, 34, 25, 12, 22, 11, 90, 12 };
            var newlst = new HashSet<int>();

            for (int i = 0; i < lst.Count; i++)
            {
                var min = lst.Min();
                newlst.Add(min);
                lst.RemoveAt(lst.IndexOf(min));
            }

            Console.WriteLine(string.Join(" ", newlst));

        }
    }
}
