using System;

namespace PopulationTask
{
    public static class Population
    {
        /// <summary>
        /// Calculates the count of years which the town need to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation">The population at the beginning of a year.</param>
        /// <param name="percent">The percentage of growth per year.</param>
        /// <param name="visitors">The visitors (new inhabitants per year) who come to live in the town.</param>
        /// <param name="currentPopulation">The population at present.</param>
        /// <returns>The count of years which the town need to see its population greater or equal to currentPopulation inhabitants.</returns>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("The initial population is less or equal 0.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("The count of visitors cannot be less 0.");
            } 

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("The current population is less or equals 0.");
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("The current population is less than initial population");
            }
            
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            int years = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = (int)(initialPopulation * (1 + (percent / 100.0))) + visitors;
                years += 1;
            }

            return years;
        }
    }
}
