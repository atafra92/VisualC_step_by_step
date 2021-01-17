using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Conctact");
            myPlane.TakeOff(); 
            myPlane.Drive(); //Drive() method in base class Vehicle and ovveriden method are not the same 
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine();

            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("brm brm");
            myCar.Accelerate();
            myCar.Drive(); //Drive() method in base class Vehicle and ovveriden method are not the same 
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar; //creating a reference to Car object by using a Vehicle variable
            v.Drive(); //calls Drive() method by using Vehicle variable (which is Motoring)
            v = myPlane;
            v.Drive(); // this is Flying 
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
