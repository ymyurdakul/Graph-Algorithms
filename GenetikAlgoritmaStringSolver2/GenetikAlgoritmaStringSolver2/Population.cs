using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Population
    {
        public Kromozom[] kromozomlar;
        public Population(int popSize, bool isElit)
        {

            kromozomlar = new Kromozom[popSize];

            if (isElit)
            {
                for (int i = 0; i < popSize; i++)
                {
                    Kromozom ino = new Kromozom();
                    ino.generateIndividual();
                    kromozomlar[i] = ino;
                }
            }


        }
        public Kromozom getFittest()
        {
            Kromozom kro = kromozomlar[0];
            for (int i = 0; i < kromozomlar.Count(); i++)
            {
                if (kromozomlar[i].getFitness() > kro.getFitness())
                {
                    kro = kromozomlar[i];
                }
            }
            return kro;
        }
    }
}
