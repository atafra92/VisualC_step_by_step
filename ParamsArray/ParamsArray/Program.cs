using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());

            //Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));

            //at runtime overload of Sum method it called because it is most closely matches the method call
            Console.WriteLine(Util.Sum(2, 4, 6, 8)); //outputs 20

            //clr uses method overload which accepts optional parameters once more - it has precedence before params int[] parameter 
            Console.WriteLine(Util.Sum(2, 4, 6)); //outputs 12

            //this time there is 5 parameters passed in so CLR takes parameters list overload of Sum method 
            Console.WriteLine(Util.Sum(2, 4, 6, 8, 10)); //outputs 30

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
