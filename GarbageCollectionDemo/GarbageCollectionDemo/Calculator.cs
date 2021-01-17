using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    public class Calculator : IDisposable
    {
        private bool disposed = false; //control bool field 
        public Calculator()
        {
            Console.WriteLine("Calaculator being created");
        }

        /// <summary>
        /// destructor of a class
        /// It is never being called in the Main!!!??
        /// </summary>
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            Dispose();
        }

        public void Dispose()
        {
            if(disposed == false)
            {
                Console.WriteLine("Calculator being disposed");
            }

            disposed = true;
            GC.SuppressFinalize(this); //provides access to harbage collector, use with caution!!!
        }


        /// <summary>
        /// implementation of IDisposable interface
        /// </summary>
        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
