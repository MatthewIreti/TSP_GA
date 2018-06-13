using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    class Population
    {
        List<Tour> tours;
        public Population()
        {

        }
        public Population(int populationSize, bool initialize)
        {
            tours = new List<Tour>(populationSize);
            for (int i = 0; i < populationSize; i++)
            {
                tours.Insert(i, null);
            }
            
             
            if (initialize)
            {
                for (int i = 0; i < populationSize; i++)
                {
                    Tour tour = new Tour();
                    tour.GenerateIndividual();
                    SaveTour(i, tour);
                }
            }
             
        }

        public Tour GetTourByPosition(int index)
        {
            return tours[index];
        }
        public void SaveTour(int index, Tour tour)
        {
            tours[index]= tour;
        }

        public int PopulationSize()
        {
            return tours.Count;
        }
         
        public Tour GetFittest()
        {
            Tour fittest = tours[0];
            for (int i = 0; i < tours.Count; i++)
            {
                if (fittest.GetFitness() <= GetTourByPosition(i).GetFitness())
                {
                    fittest = GetTourByPosition(i);
                }
            }
            return fittest;
        }
    }
}
