using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Singleton;
using System;

namespace DesignPatternsPractice
{

    public class Program
    {
        //static void Main(string[] args)
        //{
        //    string vehicleName = Console.ReadLine();
        //    VehicleFactory factory = new VehicleFactory();
        //    IVehicle vehicle = factory.CreateInstance(vehicleName);
        //    vehicle.Start();
        //    vehicle.Stop();
        //    Console.ReadKey();


        //}
    }










    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string vehicleName = Console.ReadLine();

    //        if(vehicleName =="Car")
    //        {
    //            IVehicleFactory factory = new CarFactory();

    //            var car = factory.CreateVehicle();

    //            car.Start();
    //            car.Stop();
    //        }


    //    }
    //}













    //class Program
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    //singleton start
    //    //    Console.WriteLine("Testing NoThreadSafeSingleton Pattern");

    //    //    //Create two references
    //    //   NoThreadSafeSingleton obj1 = NoThreadSafeSingleton.Instance;
    //    //    NoThreadSafeSingleton obj2 = NoThreadSafeSingleton.Instance;

    //    //    //Check if both are the same object
    //    //    if (obj1 == obj2)
    //    //    {
    //    //        Console.WriteLine("Both obj1 and obj2 are the same instance.");
    //    //    }
    //    //    else
    //    //    {
    //    //        Console.WriteLine("obj1 and obj2 are different instances!");
    //    //    }

    //    //    Console.ReadLine();
    //    //    //singleton end


    //    //}

    //    static void Main(string[] args)
    //    {


    //        //factory start
    //        string vehicleName = Console.ReadLine();
    //        IVehicle vehicle = GetVehicle(vehicleName);
    //        vehicle.Start();
    //        vehicle.Stop();
    //        Console.ReadLine();



    //    }


    //    //start factory
    //    public static IVehicle GetVehicle(string vehicleName)
    //    {
    //        switch (vehicleName)
    //        {
    //            case "Car":
    //                return new Car();
    //            case "Truck":
    //                return new Truck();
    //            case "Bus":
    //                return new Bus();
    //            case "Tempo":
    //                return new Tempo();
    //            default:
    //                throw new Exception("no vehicle found");
    //        }
    //    }
    //}
}
