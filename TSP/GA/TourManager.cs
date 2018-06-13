using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    class TourManager
    {
        public static List<City> cities = new List<City>();

        public static City GetCity(int index)
        {
            return cities[index];
        }
        public static int NumberOfCities()
        {
            return cities.Count;
        }
        public static void AddCity(City city)
        {
            cities.Add(city);
        }
    }
}
