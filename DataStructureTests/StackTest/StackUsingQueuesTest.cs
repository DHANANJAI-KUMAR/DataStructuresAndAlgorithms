namespace DataStructureTests.StackTest
{
    [TestClass]
    public sealed class StackUsingQueuesTest
    {
        [TestMethod]
        public void ImplementStackUsingQueuesTest()
        {
            //https://www.geeksforgeeks.org/implement-stack-using-queue/

            var stack = new StackUsingQueue<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("current size: " + stack.Size());
            Console.WriteLine(stack.Top());   // 30
            Console.WriteLine(stack.Pop());   // 30
            Console.WriteLine(stack.Top());   // 20

            Console.WriteLine("current size: " + stack.Size());


        }
    }
}
