using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kromozom
    {
        private Gen[] genler;
        private int fitness=0;
        private int agırlık = 0;
       
        public Kromozom()
        { 
            genler=new Gen[Program.GEN_SAYISI];
        }

        public void random()
        {
            for (int i = 0; i < Program.GEN_SAYISI; i++)
            {
                int r = Program.random.Next(1,100);
                if (r%2==0)
                {
                    genler[i] = new Gen('0');
                }
                else
                {
                    genler[i] = new Gen('1');
                }
            }
        }
        public void setWeight()
        {
            this.agırlık = Function.setWeight(this);
        }
        public void setFitness()
        {
            this.fitness = 0;
            this.Fitness = Function.setFitness(this);
        }
        public void print()
        {
             
            for (int i = 0; i < Program.GEN_SAYISI; i++)
            {
                Console.Write(genler[i].Value);
            }
            Console.Write("    fitness:::"+Fitness+"  Weight=="+agırlık+"\n");
            
        
        }
        public Gen[] Genler {
            get { return genler; }
            set { this.genler = value; }
        }
        public int Fitness{
            get { return fitness; }
            set { this.fitness = value; }

        }
        public int Agirlik
        {
            get { return this.agırlık; }
            set { this.agırlık = value; }
        }
    
    }
}
