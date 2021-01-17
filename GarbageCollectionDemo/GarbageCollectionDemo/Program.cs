using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //at the end of using statment object is being disposed and resources are released
            using (Calculator calculator = new Calculator())
            {
                // Console.WriteLine($"120 / 15 = { calculator.Divide(120, 15) }");
                Console.WriteLine($"120 / 0 = { calculator.Divide(120, 0) }");

            }

            Console.WriteLine("Program finishing");

            Console.ReadLine();
        }
    }
}
