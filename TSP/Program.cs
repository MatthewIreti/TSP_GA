using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TSP.GA;

namespace TSP
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            List<City> cities = new List<City> {

                 new City("Boston", 42.3601, -71.0586),
                 new City("Houston", 29.7604,-95.3698),
                 new City("Austin", 30.2672, -97.7431),
                 new City("San Francisco", 37.7749, -122.4194),
                 new City("Denver", 39.7392, -104.9903),
                 new City("Los Angeles", 34.0522, -118.2437),
                 new City("Chicago", 41.8781,-87.6298),
                 new City("New York", 40.7128,-74.0059),
                 new City("Dallas", 40.7128,-74.0059),
                 new City("Seattle", 47.6062,-122.3321)
             };
            TourManager.cities = cities;
            Population population = new Population(50, true);
            Console.WriteLine($"Initial Distance: {population.GetFittest().CalculateTotalDistance()} | -- fitness: {population.GetFittest().GetFitness()}");
            var initialTour = population.GetFittest();
            population = GeneticAlgorithm.EvolvePopulation(population);
            for (int i = 0; i < 100; i++)
            {
                population = GeneticAlgorithm.EvolvePopulation(population);
                Console.WriteLine($" SN {i+1} --- | Distance: {population.GetFittest().CalculateTotalDistance()} | -- fitness: {population.GetFittest().GetFitness()}");
                
            }

            Console.WriteLine($"Finished");
            Console.WriteLine($"Final Distance: {population.GetFittest().CalculateTotalDistance()}");
            Console.WriteLine($"=========================SOLUTION=======================================");
            Console.WriteLine($"{population.GetFittest()}");
            //Console.ReadKey();

            ChartPlotter chartPlotter = new ChartPlotter();
            chartPlotter.PlotData(initialTour, population.GetFittest());

            Application.EnableVisualStyles();
            Application.Run(chartPlotter);
        }

    }
}
