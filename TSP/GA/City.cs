using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
     
    public class City
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public String  Name { get; set; }

        public City(String _name, double _longitude, double _latitude)
        {
            Longitude = _longitude * Constants.CONVERT_TO_RADIANS;
            Latitude = _latitude * Constants.CONVERT_TO_RADIANS;
            Name = _name;
        }

        /**
            * using the Haversine formula to calculate distance between two geopoints
            * 
            *     a = sin²(Δφ/2) + cos φ1 ⋅ cos φ2 ⋅ sin²(Δλ/2)
            *     c = 2 ⋅ atan2( √a, √(1−a) )
            *     d = R ⋅ c
            * where φ is latitude, λ is longitude, R is earth’s radius (mean radius = 6,371km);
            * d is distance
         */
        public double CalculateDistanceTo(City city)
        {
           
            double deltaLat = city.Latitude - Latitude;
            double deltaLong = city.Longitude - Longitude;
            var a = Math.Pow(Math.Sin(deltaLat/2D), 2D) + Math.Cos(Latitude) * Math.Cos(city.Latitude)* Math.Pow(Math.Sin(deltaLong/2D), 2D);
            return   Constants.EARTH_EQUATORIAL_RADIUS* 2D* Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D-a));
        }

        public override string ToString()
        {
            return Name;
        }
    }
    
}
