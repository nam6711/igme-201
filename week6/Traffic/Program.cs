using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class Program
    {
        static void AddPassengers(IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger("Jimmy");

            Console.WriteLine(vehicleObject.ToString());
        }

        static void Main(string[] args)
        {
            // a vehicle that inherits IPassengerCarrier
            Compact compact = new Compact();
            AddPassengers(compact);

            // a vehicle that does not inherit IPassengerCarrier
            FreighTrain freightTrain = new FreighTrain();
            // AddPassengers(freightTrain); doesn't work! causes errors
        }
    }
}
