using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.Common.Lib
{
    public class QueueUtil
    {

        public static void Print(Queue<int> q)
        {
            while (q.Count > 0)
            {
                Console.Write(q.Dequeue() + " ");
            }
        }

    }
}
