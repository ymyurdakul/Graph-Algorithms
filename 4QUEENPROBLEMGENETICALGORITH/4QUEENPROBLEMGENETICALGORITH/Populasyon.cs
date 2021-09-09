using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Populasyon
    {
        public int popFitness = 0;
        public static Random rnd = new Random();
        Kromozom[] kromozomlar;
        public const int popSize = 10;
        public int fittestIndex = 0;
        public int secnondFittestIndex = 0;
        public Kromozom fittestKromozom;
        public Kromozom secondFittestKromozom;
        public Populasyon()
        {
            kromozomlar = new Kromozom[popSize];
        }
        public void initializePop()
        {
            for (int i = 0; i < 10; i++)
            {
                kromozomlar[i]=(new Kromozom());
            }
            
        }
        public void selection()
        { 
          getfittest();
            getSecondFittest();
        
        }
        public void crossover()
        {
             
            
            int r=Populasyon.rnd.Next(4);
            int temp=fittestKromozom.genes[r].gen;
            fittestKromozom.genes[r].gen = secondFittestKromozom.genes[r].gen;
            secondFittestKromozom.genes[r].gen = temp;
            fittestKromozom.setFitneess();
            secondFittestKromozom.setFitneess();

        }
          Kromozom getSecondFittest()
        {
            int min = 1000;
            for (int i = 0; i < popSize; i++)
            {
                if (i==fittestIndex)
                {
                    continue;
                }
                if (min>kromozomlar[i].fitness)
                {
                    min=kromozomlar[i].fitness;
                    secnondFittestIndex = i;
                }

            }
              secondFittestKromozom = kromozomlar[secnondFittestIndex];
            return kromozomlar[secnondFittestIndex];
        }
          public void mutasyon()
          {
              int r = Populasyon.rnd.Next(4);
              fittestKromozom.genes[r].gen = (fittestKromozom.genes[r].gen + 1) % 4;
              secondFittestKromozom.genes[r].gen =  ( secondFittestKromozom.genes[r].gen+1)%4;
            fittestKromozom.setFitneess();
            secondFittestKromozom.setFitneess();
          
          }
          public void exchange()
          {
              int least = 0,leastIndex=0;
              for (int i = 0; i < popSize; i++)
              {
                  if (kromozomlar[i].fitness>least)
                  {
                      least = kromozomlar[i].fitness;
                      leastIndex = i;
                  }
              }
              if (fittestKromozom.fitness<secondFittestKromozom.fitness)
              {
                  kromozomlar[leastIndex] = fittestKromozom;
              }
              if (fittestKromozom.fitness > secondFittestKromozom.fitness)
              {
                  kromozomlar[leastIndex] = secondFittestKromozom;
              }
          
          }
        public void writePopulasyon()
        {
            for (int i = 0; i < popSize; i++)
            {
                  kromozomlar[i].writeGen(); Console.WriteLine();
            }
            
        }
        public int getPopFitness()
        {
            return getfittest().fitness;

        }
         Kromozom getfittest()
        {
            int min = 1000;
            for (int i = 0; i < popSize; i++)
            {
                if (kromozomlar[i].fitness<min)
                {
                         
                    min=kromozomlar[i].fitness;
                    fittestIndex = i;
                }
            }
            fittestKromozom=kromozomlar[fittestIndex];
            return kromozomlar[fittestIndex];
        }
    }
}
