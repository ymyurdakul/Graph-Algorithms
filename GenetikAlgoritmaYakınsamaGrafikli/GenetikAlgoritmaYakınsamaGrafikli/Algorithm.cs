using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Algorithm
    {
        static Random rnd = new Random();
        //Ga parameters
        private static double uniformRate = .5;
        private static double mutationRate;
        private static int tournamentSize = 5;
        private static bool elitism = true;
        public static Population evolvePopualation(Population pop, bool mutation)
        {
            Population newPopulation = new Population(pop.kromozomlar.Length, false);
            if (elitism)
            {
                newPopulation.kromozomlar[0] = pop.getFittest();
            }
            int elitismOfffset;
            if (elitism)
            {
                elitismOfffset = 1;
            }
            else
            {
                elitismOfffset = 0;
            }

            for (int i = elitismOfffset; i < pop.kromozomlar.Length; i++)
            {
                Kromozom indiv = tournamentSelection(pop);
                Kromozom indiv2 = tournamentSelection(pop);
                Kromozom child = crossover(indiv, indiv2);
                newPopulation.kromozomlar[i] = (child);

            }
            if (mutation)
                for (int i = elitismOfffset; i < newPopulation.kromozomlar.Length; i++)
                {
                    mutate(newPopulation.kromozomlar[i]);
                }

            return newPopulation;
        }


        public static Kromozom crossover(Kromozom indiv1, Kromozom indvi2)
        {

            Kromozom child = new Kromozom();
            Kromozom child2 = new Kromozom();
            int kesmeIndex = rnd.Next(0, 63);
            for (int i = 0; i < kesmeIndex; i++)
            {
                child.genes[i] = indiv1.genes[i];
                child2.genes[i] = indvi2.genes[i];
            }
            for (int i = kesmeIndex; i < indiv1.genes.Length; i++)
            {
                child.genes[i] = indvi2.genes[i];
                child2.genes[i] = indiv1.genes[i];
            }

            if (child.getFitness() > child2.getFitness())
            {
                return child;
            }
            else
                return child2;
        }
        public static void mutate(Kromozom indiv)
        {
            int start = rnd.Next(1, 63);
            for (int i = start; i < 64; i++)
            {
                int g = indiv.genes[i] <= 0 ? 1 : 0;
                indiv.genes[i] = ((byte)g);

            }
        }
        public static Kromozom tournamentSelection(Population
             pop)
        {
            Population tournament = new Population(tournamentSize, false);
            for (int i = 0; i < tournamentSize; i++)
            {
                int random = rnd.Next(1, pop.kromozomlar.Length);
                tournament.kromozomlar[i] = pop.kromozomlar[random];
            }
            Kromozom fittest = tournament.getFittest();
            return fittest;

        }
    }
}
