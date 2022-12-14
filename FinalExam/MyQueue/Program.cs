using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue
    {
        public List<int> myQueue = new List<int>();

        public void Enqueue(int n)
        {
            myQueue.Insert(0, n);
        }

        public int? Peek()
        {
            if (myQueue.Count > 0)
            {
                return myQueue[0];
            }
            else
            {
                return null;
            }
        }

        public int? Dequeue()
        {
            if (myQueue.Count > 0)
            {
                int? r = myQueue[0];
                myQueue.RemoveAt(0);
                return r;
            }
            else
            {
                return null;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
