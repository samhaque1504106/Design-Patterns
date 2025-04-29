using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory
{
    public class FactoryClass
    {

    }

    public class VehicleFactory
    {
        Dictionary<string, Type> vehicles;

        public VehicleFactory()
        {
            LoadTypesICanReturn();
        }

        public IVehicle CreateInstance(string vehicleName)
        {
            Type t = GetTypeToCreate(vehicleName);
            if(t==null)
            {
                throw new Exception("Bad type");
            }
            else return Activator.CreateInstance(t) as IVehicle;
        }

        private Type GetTypeToCreate(string vehicleName)
        {
            foreach(var vehicle in vehicles)
            {
                if(vehicle.Key.Equals(vehicleName.ToLower()))
                {
                    return vehicles[vehicle.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {

            vehicles = new Dictionary<string, Type>();
            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach(Type type in typeInThisAssembly)
            {
                if(type.GetInterface(typeof(IVehicle).ToString())!=null)
                {
                    vehicles.Add(type.Name.ToLower(), type);
                }
            }
        }
    }

}
