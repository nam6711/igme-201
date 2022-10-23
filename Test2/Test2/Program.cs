using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public interface IPhoneInterface
    {
        void Answer();

        void MakeCall();

        void HangUp();
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        // accessor for phoneNumber private property
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public class RotaryPhone : Phone, IPhoneInterface
    {
        // inherited from IPhoneInterface interface
        public void Answer()
        {
            // code to impliment
        }
        
        public void MakeCall()
        {
            // code to impliment
        }
        
        public void HangUp()
        {
            // code to impliment
        }


        // Methods inherited from Phone class
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;

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

        public void TimeTravel()
        {
            // code to impliment
        }

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

    public class PushButtonPhone : Phone, IPhoneInterface
    {
        // inherited from IPhoneInterface interface
        public void Answer()
        {
            // code to impliment
        }

        public void MakeCall()
        {
            // code to impliment
        }

        public void HangUp()
        {
            // code to impliment
        }


        // Methods inherited from Phone class
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    public class PhoneBotth : PushButtonPhone
    {
        private bool superMan;
        public bool phoneBook;

        public double costPerCall;
        
        public void OpenDoor()
        {
            // code to impliment
        }

        public void CloseDoor()
        {
            // code to impliment
        }
    }
}
