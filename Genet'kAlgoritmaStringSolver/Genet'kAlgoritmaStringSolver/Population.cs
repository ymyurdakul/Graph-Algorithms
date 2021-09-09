using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Population
    {
       public Individual[] kromozomlar;
       public Population(int popSize,bool isElit)
       {

           kromozomlar = new Individual[popSize];
        
           if (isElit)
           {
               for (int i = 0; i < popSize; i++)
               {
                   Individual ino=new Individual();
                   ino.generateIndividual();
                   kromozomlar[i] = ino;
               }
           }
       
       
       }
       public Individual getFittest()
       {
           Individual indiv = kromozomlar[0];
           for (int i = 0; i < kromozomlar.Count(); i++)
           {
               if (kromozomlar[i].getFitness()>indiv.getFitness())
               {
                   indiv = kromozomlar[i];
               }
           }
           return indiv;
       }
    }
}
