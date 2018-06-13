using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.GA
{
    class GeneticAlgorithm
    {
        //GA Parameters
        public static readonly double MUTATION_RATE = 0.005;
        public static readonly bool ELITISM = true;
        public static readonly int TOURNAMENT_SIZE = 3;

        //Evolve a population over one generation
        public static Population EvolvePopulation(Population population)
        {
            var newPopulation = new Population(population.PopulationSize(), false);

            //keep our best individual if ellitism is enabled
            int ellitismOffset = 0;
            if (ELITISM)
            {
                newPopulation.SaveTour(0, population.GetFittest());
                ellitismOffset = 1;
            }

            //Cross over the Population
            //loop over the new population and create individuals from the current population
            for (int i = ellitismOffset; i < newPopulation.PopulationSize(); i++)
            {
                var firstParent = TournamentSelection(population);
                var secondParent = TournamentSelection(population);
                var child = CrossOver(firstParent, secondParent);

                // Add child to new population
                newPopulation.SaveTour(i, child);
            }

            //Mutate the new population to allow for Genetic Saucing
            for (int i = 0; i < newPopulation.PopulationSize(); i++)
            {
                MutatePopulation(newPopulation.GetTourByPosition(i));
            }
            return newPopulation;
        }

       

        private static Tour CrossOver(Tour firstParent, Tour secondParent)
        {
            Tour child = new Tour();

            Random rand = new Random();

            //Get start and end tour position for parent 1
            int startPosition =(int) (Constants.GetRandom() * firstParent.TourSize());
            int endPosition = (int)(Constants.GetRandom() * firstParent.TourSize());

            for (int i = 0; i < child.TourSize(); i++)
            {
                if (startPosition < endPosition && i > startPosition && i < endPosition)
                    child.PlaceCity(i, firstParent.GetCity(i));
                else if (startPosition > endPosition)
                {
                    if (!(i < startPosition && i > endPosition))
                        child.PlaceCity(i, firstParent.GetCity(i));
                }
                
            }

            //Loop through second parent's tour
            for (int i = 0; i < secondParent.TourSize(); i++)
            {
                // if child does not have the city add
                if (!child.ContainsCity(secondParent.GetCity(i)))
                {
                    //loop through to find a spare position in the childs tour
                    for (int j = 0; j < child.TourSize(); j++)
                    {
                        if (child.GetCity(j)==null)
                        {
                            child.PlaceCity(j, secondParent.GetCity(i));
                            break;
                        }
                    }
                }
            }
            return child;

        }
        /**
         * Mutate by swapping
         * */
        private static void MutatePopulation(Tour tour)
        {
            //Get the number of cities to be mutated
            
            for (int i = 0; i < tour.TourSize(); i++)
            {
                //Apply mutation rate
                if (Constants.GetRandom() < MUTATION_RATE)
                {
                    int tourPosition =(int) (Constants.GetRandom() * tour.TourSize());

                    var firstCity = tour.GetCity(i);
                    var secondCity = tour.GetCity(tourPosition);

                    //Swap the city around
                    tour.PlaceCity(tourPosition, firstCity);
                    tour.PlaceCity(i, secondCity);
                }
            }
        }
        //Select candidate tour for crossover
        private static Tour TournamentSelection(Population population)
        {
            //Create a tournament population
            Population tournament = new Population(TOURNAMENT_SIZE, false);
            for (int i = 0; i < TOURNAMENT_SIZE; i++)
            {
                int randomIndex = (int)(Constants.GetRandom() * population.PopulationSize());
                tournament.SaveTour(i, population.GetTourByPosition(randomIndex));
            }
            var fittest = tournament.GetFittest();
            return fittest;
        }
    }
}
