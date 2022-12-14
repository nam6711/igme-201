using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyQueue
    {
        public List<int> myStack = new List<int>();

        public void Push(int n)
        {
            myStack.Add(n);
        }

        public int? Peek()
        {
            if (myStack.Count > 0)
            {
                return myStack[myStack.Count - 1];
            }
            else
            {
                return null;
            }
        }

        public int? Pop()
        {
            if (myStack.Count > 0)
            {
                int? n = myStack[myStack.Count - 1];
                myStack.RemoveAt(myStack.Count - 1);
                return n;
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
