using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    // Interface: Program
    // Author: Nat Manoucheri
    // Purpose: Set up for any phone that plans to have any calls coming in or our
    // Restrictions: None
    public interface IPhoneInterface
    {
        // Method: Answer
        // Purpose: Answers a call
        // Restrictions: interface
        void Answer();

        // Method: MakeCall
        // Purpose: Makes a call
        // Restrictions: interface
        void MakeCall();

        // Method: HangUp
        // Purpose: Hangs up a call
        // Restrictions: interface
        void HangUp();
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: Set up for connecting calls and any classes that inherit from the phone interface
    // Restrictions: abstract
    public abstract class Phone
    {
        // properties of the Phone class
        private string phoneNumber;
        public string address;

        // accessor for phoneNumber private property
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Method: Connect
        // Purpose: Connects the call
        // Restrictions: abstract
        public abstract void Connect();

        // Method: Disconnect
        // Purpose: Disconnects the call
        // Restrictions: abstract
        public abstract void Disconnect();
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: All functionality expected from a rotary phone, and writes to console
    //          each action done
    // Restrictions: None
    public class RotaryPhone : Phone, IPhoneInterface
    {
        // inherited from IPhoneInterface interface

        // Method: Answer
        // Purpose: Answers a call
        // Restrictions: inherited from IPhoneInterface
        public void Answer()
        {
            // code to impliment NONE
        }
        // Method: MakeCall
        // Purpose: Makes a call
        // Restrictions: inherited from IPhoneInterface
        public void MakeCall()
        {
            Console.WriteLine("You made a call using the rotary phone");
        }
        // Method: HangUp
        // Purpose: Hangs up the phone
        // Restrictions: inherited from IPhoneInterface
        public void HangUp()
        {
            Console.WriteLine("You hung up the rotary phone");
        }


        // Methods inherited from Phone class

        // Method: Connect
        // Purpose: Connects a call
        // Restrictions: None
        public override void Connect()
        {
            throw new NotImplementedException();
        }
        // Method: Disconnect
        // Purpose: Disconnects a call
        // Restrictions: Inherited from Phone
        public override void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: The tardis can time travel, and holds unique data for the doctor inside,
    //          as well as unique boolean operator functionality comparing doctor number
    // Restrictions: None
    public class Tardis : RotaryPhone
    {
        // properties for the doctor within the tardis
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;

        // properties for the tardis
        public double exteriorSurfaceArea;
        public double interiorVolume;

        // accessor method for private whichDrWho (read-only)
        public byte WhichDrWho
        {
            get { return this.whichDrWho; }
        }

        // accessor method for private femaleSideKick (read-only)
        public string FemaleSideKick
        {
            get { return this.femaleSideKick; }
        }


        // Method: TimeTravel
        // Purpose: Tells the tardis to time travel
        // Restrictions: none
        public void TimeTravel()
        {
            Console.WriteLine("The Tardis time travelled");
        }


        // Operator: bool ==
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator == (Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho == doc2.WhichDrWho)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Operator: bool !=
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator !=(Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho != doc2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Operator: bool >=
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator >=(Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho == 10 || doc2.WhichDrWho == 10)
            {
                if (doc1.WhichDrWho == 10) { return true; }
                else if (doc1 == doc2) { return true; }
                else { return false; }
            }
            else if (doc1.WhichDrWho >= doc2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Operator: bool >
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator >(Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho == 10 || doc2.WhichDrWho == 10)
            {
                if (doc1.WhichDrWho == 10) { return true; }
                else { return false; }
            }
            else if (doc1.WhichDrWho > doc2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Operator: bool <=
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator <=(Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho == 10 || doc2.WhichDrWho == 10)
            {
                if (doc1.WhichDrWho == 10) { return false; }
                else if (doc1 == doc2) { return true; }
                else { return true; }
            }
            else if (doc1.WhichDrWho <= doc2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Operator: bool <
        // Purpose: Changes program to compare based upon the WhichDrWho
        //          property two Tardis' hold
        // Restrictions: if value of WhichDrWho == 10, then it is always > the other Dr
        public static bool operator <(Tardis doc1, Tardis doc2)
        {
            if (doc1.WhichDrWho == 10 || doc2.WhichDrWho == 10)
            {
                if (doc1.WhichDrWho == 10) { return false; }
                else { return true; }
            }
            else if (doc1.WhichDrWho < doc2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: Holds functionality for using a push button phone
    // Restrictions: None
    public class PushButtonPhone : Phone, IPhoneInterface
    {
        // inherited from IPhoneInterface interface
        
        // Method: Answer
        // Purpose: Answers a call
        // Restrictions: inherited from IPhoneInterface
        public void Answer()
        {
            // code to impliment NONE
        }
        // Method: MakeCall
        // Purpose: Makes a call
        // Restrictions: inherited from IPhoneInterface
        public void MakeCall()
        {
            Console.WriteLine("You made a call using the push button phone");
        }
        // Method: HangUp
        // Purpose: Hangs up the phone
        // Restrictions: inherited from IPhoneInterface
        public void HangUp()
        {
            Console.WriteLine("You hung up the push button phone");
        }


        // Methods inherited from Phone class

        // Method: Connect
        // Purpose: Connects a call
        // Restrictions: None
        public override void Connect()
        {
            throw new NotImplementedException();
        }
        // Method: Disconnect
        // Purpose: Disconnects a call
        // Restrictions: Inherited from Phone
        public override void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: Prints the actions taken by using a phone booth (which is assumed to be boring)
    // Restrictions: None
    public class PhoneBooth : PushButtonPhone
    {
        // holds if superman is inside
        private bool superMan;
        // holds if a phonebook is inside
        public bool phoneBook;

        public double costPerCall;
        // Method: OpenDoor
        // Purpose: Opens a door
        // Restrictions: None
        public void OpenDoor()
        {
            Console.WriteLine("You boringly open the door (this booth isn't cool)");
        }
        // Method: CloseDoor
        // Purpose: Closes a door
        // Restrictions: None
        public void CloseDoor()
        {
            Console.WriteLine("You boringly close the door (this booth isn't cool)");
        }
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: Console Read/Write the actions of Using any generic phone
    // Restrictions: None
    public static class Program
    {

        // Method: UsePhone
        // Purpose: Determines the type of phone being used, and then performs
        //          actions unique to that phone type
        // Restrictions: None
        public static void UsePhone(object obj)
        {

            if (obj is Tardis)
            {
                Tardis phone = (Tardis)obj;
                phone.MakeCall();
                phone.HangUp();
                phone.TimeTravel();
            } else if (obj is PhoneBooth)
            {
                PhoneBooth phone = (PhoneBooth)obj;
                phone.OpenDoor();
                phone.MakeCall();
                phone.HangUp();
                phone.CloseDoor();
            }
        }

        // Method: Main
        // Purpose: Creates some phones and makes calls on them!
        // Restrictions: None
        public static void Main()
        {
            Tardis tardis = new Tardis();
            PhoneBooth pBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(pBooth);
        }
    }
}
