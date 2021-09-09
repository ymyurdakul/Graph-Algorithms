using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Population
    {
        private Kromozom[] kromozmlar;
        private Kromozom best;
        public Population()
        { 
            kromozmlar=new Kromozom[Program.KROMOZOM_SAYISI];
        }
        public void initialize()
        {
            for (int i = 0; i < Program.KROMOZOM_SAYISI; i++)
            {
                Kromozom temp = new Kromozom();
                temp.random();
                temp.setFitness();
                temp.setWeight();
                kromozmlar[i] = temp;
            }
        }
        public void setBest()
        {
            Kromozom bestOne=kromozmlar[0];
            for (int i = 0; i < Program.KROMOZOM_SAYISI; i++)
            {
                if (kromozmlar[i].Fitness>bestOne.Fitness)
                {
                    bestOne=kromozmlar[i];
                }
            }
            this.best = bestOne;
        }
        public void print()
        {
            foreach (Kromozom item in kromozmlar)
            {
                item.print();
            }
        }
        public Kromozom Best {
            get { return best; }
            set { this.best = value; }
        }
        public Kromozom[] Kromozomlar {
            get { return this.kromozmlar; }
            set { this.kromozmlar = value; }
        
        }

    }
}
