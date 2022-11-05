
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructToClass
{
    // Class: Friend
    // Author: Nat Manoucheri
    // Purpose: Hold data on a friend, and to duplicate the current friend's data
    // Restrictions: None
    public class Friend
    {
        // starting variables for the class to hold all friend data
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        /// Method: ShallowCopy
        // Purpose: Return a shallow copy of the current object
        // Restrictions: None
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        // constructor initializes class values
        public Friend(string name, string greeting, DateTime birthdate, string address)
        {
            this.name = name;
            this.greeting = greeting;
            this.birthdate = birthdate;
            this.address = address;
        }
    }

    class Program
    {
        // Method: Main
        // Purpose: Create a friend, and then turn them into an enemy
        // Restrictions: None
        static void Main(string[] args)
        {
            // initializes the friend that is about to become an enemy
            Friend friend = new Friend("Charlie Sheen", "Dear Charlie", DateTime.Parse("1967-12-25"), "123 Any Street, NY NY 12202");
            // holds the new enemy
            Friend enemy;

            // now he has become my enemy
            enemy = (Friend)friend.ShallowCopy();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}

