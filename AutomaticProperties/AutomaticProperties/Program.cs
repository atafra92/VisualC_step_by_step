using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triange = new Polygon()
            {
                NumSides = 3
                //SideLenght is set to 10.0 in a class constructor 
            };
            Polygon pentagon = new Polygon
            {
                SideLenght = 15.5,
                NumSides = 5
            };

            Console.WriteLine($"Square: number of sides is {square.NumSides }, length of each side is { square.SideLenght }");
            Console.WriteLine($"Triangle: number of sides is { triange.NumSides }, length of each side is { triange.SideLenght }");
            Console.WriteLine($"Pentagon: number of sides is { pentagon.NumSides }, length of each side is { pentagon.SideLenght }");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
