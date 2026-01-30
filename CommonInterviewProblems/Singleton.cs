using DataStructures.BaseClass;

namespace CommonInterviewProblems
{
    public sealed class Singleton
    {
        private static Singleton? _instance = null;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private Singleton()
        {
            // Initialize resources if needed
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)  // Thread-safe access
                {
                    //if (_instance == null)
                    //{
                    //    _instance = new Singleton();
                    //}
                    _instance ??= new Singleton();
                    return _instance;
                }
            }
        }

        // Example method
        public void DoWork()
        {
            Console.WriteLine("Singleton instance is working...");
        }
    }


}