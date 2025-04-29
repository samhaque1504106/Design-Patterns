using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    internal class ImplementationFactory
    {
    }

    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class BusFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Bus();
        }
    }

    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }

    public class TempoFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Tempo();
        }
    }
}
