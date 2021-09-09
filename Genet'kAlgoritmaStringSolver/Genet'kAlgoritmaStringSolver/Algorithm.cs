using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Algorithm
    {
        static Random rnd = new Random();
        //Ga parameters
        private static double uniformRate = .5;
        private static double mutationRate;
        private static int tournamentSize = 5;
        private static bool elitism = true;
        public static Population evolvePopualation(Population pop)
        {
            Population newPopulation = new Population(pop.kromozomlar.Length,false);
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
                Individual indiv = tournamentSelection(pop);
                Individual indiv2 = tournamentSelection(pop);
                Individual child = crossover(indiv,indiv2);
                newPopulation.kromozomlar[i]=(child);

            }
            for (int i = elitismOfffset; i < newPopulation.kromozomlar.Length; i++)
            {
                mutate(newPopulation.kromozomlar[i]);
            }
            return newPopulation;
        }


        public static Individual crossover(Individual indiv1, Individual indvi2)
        {
            
            Individual child = new Individual();
            for (int i = 0; i < indiv1.size(); i++)
            {
                int y=rnd.Next(1,64);
                if (y % 32 > 0)
                {
                    child.setGene(i,indiv1.getGen(i));
                }
                else {
                    child.setGene(i, indvi2.getGen(i));
                }
            }
            return child;
        }
        public static void mutate(Individual indiv)
        {
            int start=rnd.Next(1,63);
            for (int i = start; i < indiv.size(); i++)
            {
               int g= indiv.getGen(i)<=0?1:0;
                indiv.setGene(i,(byte)g);

            }
        }
        public static Individual tournamentSelection(Population
             pop)
        {
            Population tournament = new Population(tournamentSize,false);
            for (int i = 0; i < tournamentSize; i++)
            {
                int random = rnd.Next(1,pop.kromozomlar.Length);
                tournament.kromozomlar[i]=pop.kromozomlar[random];
            }
            Individual fittest = tournament.getFittest();
            return fittest;
        
        }
    }
}
