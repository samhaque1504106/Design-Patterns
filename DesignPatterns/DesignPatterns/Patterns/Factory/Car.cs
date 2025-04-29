using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    internal class Car : IVehicle
    {
        public string VehicleName
        {
            get
            {
                return "Car";
            }
        }

        public void Start()
        {
            Console.WriteLine("Car is getting started");
        }

        public void Stop()
        {
            Console.WriteLine("Car is getting stopped");
        }
    }

    internal class Truck : IVehicle
    {
        public string VehicleName
        {
            get
            {
                return "Truck";
            }
        }

        public void Start()
        {
            Console.WriteLine("Truck is getting started");
        }

        public void Stop()
        {
            Console.WriteLine("Truck is getting stopped");
        }
    }


    public class Bus : IVehicle
    {
        public string VehicleName 
        {
            get
            {
                return "Bus";
            }
        }

        public void Start()
        {
            Console.WriteLine("Bus is getting started");
        }

        public void Stop()
        {
            Console.WriteLine("Bus is getting stopped");
        }
    }

    public class Tempo : IVehicle
    {
        public string VehicleName
        {
            get
            {
                return "Tempo";
            }
        }
        public void Start()
        {
            Console.WriteLine("I am a Tempo and I am going to start.");
        }
        public void Stop()
        {
            Console.WriteLine("I am a Tempo and I am going to stop");
        }
    }
}
