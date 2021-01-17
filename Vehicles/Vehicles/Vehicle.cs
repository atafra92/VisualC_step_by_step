using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine...");
        }

        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine...");
        }

        /// <summary>
        /// This method should be virtual if we want to override it in some of derived classes 
        /// </summary>
        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drive method");
        }
    }
}
