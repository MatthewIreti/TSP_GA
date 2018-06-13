using System;
using System.Collections.Generic;
using System.Linq;

namespace TSP.GA
{
    public class Tour
    {
        public List<City> tours = new List<City>();
        //cache
        public double fitness = 0;
        private double distance = 0;

        public Tour()
        {
            for (int i = 0; i < TourManager.NumberOfCities(); i++)
            {
                tours.Insert(i, null);
            }
        }
        public Tour(List<City> _tours)
        {
            tours = _tours;
        }

        public void GenerateIndividual()
        {
            for (int i = 0; i < TourManager.NumberOfCities(); i++)
            {
                PlaceCity(i, TourManager.GetCity(i));
            }
            tours.Shuffle();
        }

        public void PlaceCity(int tourPosition, City city)
        {
            tours[tourPosition] = city;
            fitness = 0;
            distance = 0;
        }

        public City GetCity(int tourPosition)
        {
            return tours[tourPosition];
        }

        /**
         * Using a fitness function of f(x) =  1/totalDistance * 10000
         * */
        public double GetFitness()
        {
            if (fitness == 0)
            {
                fitness = (1 / CalculateTotalDistance()) *10000;
            }
            return fitness;

        }
        public double CalculateTotalDistance()
        {
            if (distance == 0)
            {
                double tourDistance = 0;
                //loop through the tour
                for (int i = 0; i < tours.Count; i++)
                {
                    var fromCity = GetCity(i);
                    //Check we are not in our last City
                    // If yes set our final destination to our starting
                    var destinationCity = (i + 1 < tours.Count) ? tours[i + 1] : tours[0];
                    tourDistance += fromCity.CalculateDistanceTo(destinationCity);
                }
                distance = tourDistance;
            }
            return distance;
        }

        /**
         * To check if a tour contains a city
         * **/
        public bool ContainsCity(City city)
        {
            return tours.Contains(city);
        }
        public int TourSize()
        {
           return tours.Count;
        }

        public override string ToString()
        {
            return string.Join<City>(",", tours.ToArray());
        }

    }
    public static class IListExtensions
    {
        private static readonly Random rnd = new Random();

        /// <summary>
        /// Shuffles the element order of the specified list.
        /// </summary>
        /// 
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
