using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.GA;

namespace TSP
{
    class Constants
    {
        public static readonly double EARTH_EQUATORIAL_RADIUS = 6371.137D;
        public static readonly double CONVERT_TO_RADIANS = Math.PI/180D;
        public static readonly double CONVERT_KM_TO_MILES = 0.621371;
        static Random random = new Random();
        public static double GetRandom()
        {
            return random.NextDouble();
        }


    }
}
