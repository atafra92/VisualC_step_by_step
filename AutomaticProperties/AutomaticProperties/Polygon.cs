using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    public class Polygon
    {
        public int NumSides { get; set; }
        public double SideLenght { get; set; }

        /// <summary>
        /// constructor initializes properties with default values 
        /// </summary>
        public Polygon()
        {
            NumSides = 4;
            SideLenght = 10.0;
        }
    }
}
