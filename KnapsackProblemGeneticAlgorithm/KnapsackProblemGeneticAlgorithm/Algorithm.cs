using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Algorithm
    {
        public static Population evolvePopulation(Population pop)
        {
            pop.setBest();
            Population newPop = new Population();
            newPop.Kromozomlar[0] = new Kromozom();
            for (int i = 0; i < Program.GEN_SAYISI; i++)
            {
                newPop.Kromozomlar[0].Genler[i] =new Gen( pop.Best.Genler[i].Value);
            }
            newPop.Kromozomlar[0].setFitness();
            newPop.Kromozomlar[0].setWeight();
            
            for (int i = 1; i < Program.KROMOZOM_SAYISI; i++)
            {
                Kromozom child1=selection(pop);
                Kromozom child2=selection(pop);
                Kromozom offspring=crossOver(child1,child2);
                mutate(offspring);
                offspring.setFitness();
                offspring.setWeight();
               
                newPop.Kromozomlar[i] = offspring;
            }
            return newPop;
        }
        public static Kromozom selection(Population pop)
        { 
            Kromozom k1=pop.Kromozomlar[Program.random.Next(0,Program.KROMOZOM_SAYISI)];
            Kromozom k2 = pop.Kromozomlar[Program.random.Next(0, Program.KROMOZOM_SAYISI)];
            if (k1.Fitness > k2.Fitness)
            {
                return k1;
            }
            else return k2;
        
        }
        public static void mutate(Kromozom kro)
        {
            for (int i = 0; i < 3; i++)
            {
                int y = Program.random.Next(0,Program.GEN_SAYISI);
                if(kro.Genler[i].Value == '1') 
                    kro.Genler[i].Value='0';
                else kro.Genler[i].Value= '1';
            }
            
        
        }
        public static Kromozom  crossOver(Kromozom k1,Kromozom k2)
        {
            Kromozom child1 = new Kromozom();
            Array.Copy(k1.Genler,child1.Genler,k1.Genler.Length);
            Kromozom child2 = new Kromozom();
            Array.Copy(k2.Genler, child2.Genler, k2.Genler.Length);
            int point = Program.random.Next(0,Program.GEN_SAYISI);
           
            for (int i = 0; i < point; i++)
            {
                child1.Genler[i]= new Gen(k2.Genler[i].Value);
                child2.Genler[i]=new Gen(k1.Genler[i].Value);
            }
            

            child1.setFitness();
            child2.setFitness();
            child1.setWeight();
            child2.setWeight();
            if (child1.Fitness > child2.Fitness)
            {
                return child1;
            }
            else
                return child2;

        }
    }
}
