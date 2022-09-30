using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger(string rider)
        {
            Console.WriteLine("{0} hopped in the vehicle", rider);
        }
    }

    public abstract class Car : Vehicle
    {
        // code to impliment
    }

    public interface IPassengerCarrier
    {
        void LoadPassenger(string rider);
    }

    public interface IHeaveyLoadCarrier
    {
        // code to impliment
    }

    public abstract class Train : Vehicle
    {
        // code to impliment
    }

    public class Compact : Car, IPassengerCarrier
    {
        // code to impliment
    }

    public class SUV : Car, IPassengerCarrier
    {
        // code to impliment
    }

    public class Pickup : Car, IPassengerCarrier, IHeaveyLoadCarrier
    {
        // code to impliment
    }

    public class PassengerTrain : Train, IPassengerCarrier
    {
        // code to impliment
    }

    public class FreighTrain : Train, IHeaveyLoadCarrier
    {
        // code to impliment
    }

    public class _424DoubleBogey : Train, IHeaveyLoadCarrier
    {
        // code to impliment
    }

}
