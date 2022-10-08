using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12___Q3
{
    public class MyClass
    {
        private string myString = "Billy";

        public virtual string GetString()
        {
            return this.myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from the derived class)";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            string output = myDerivedClass.GetString();
            Console.WriteLine(output);  
        }
    }
}
