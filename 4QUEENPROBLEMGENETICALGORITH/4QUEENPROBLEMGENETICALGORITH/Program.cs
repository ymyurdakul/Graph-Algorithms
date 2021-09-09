using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        } 
        
        public Program()
        {
            Populasyon p = new Populasyon();
            p.initializePop();
            for (int i = 0; i < 10000; i++)
            {
                 p.writePopulasyon();
                Console.WriteLine("-------------------------------------------"+p.getPopFitness());
                p.selection();
                p.crossover();
                p.mutasyon();
                p.exchange();
                p.writePopulasyon();
                Console.WriteLine("-------------------------------------------" + p.getPopFitness());
                if (p.getPopFitness()==0)
                {
                    break;
                }
            }
               
            Console.ReadLine();

        }
     
        
    
    }
}
/*
            p.selection();
            p.writePopulasyon();
            Console.WriteLine("Fittest is"+p.fittestIndex);
            p.fittestKromozom.writeGen();
            Console.WriteLine("\nSecond is"+p.secnondFittestIndex);
            p.secondFittestKromozom.writeGen();

            p.crossover();
            Console.WriteLine("\nAfter Crosover");
            Console.WriteLine("\nFittest is" + p.fittestIndex);
            p.fittestKromozom.writeGen();
            Console.WriteLine("\nSecond is" + p.secnondFittestIndex);
            p.secondFittestKromozom.writeGen();

            p.mutasyon();
            Console.WriteLine("\nAfter Mutasyon");
            Console.WriteLine("\nFittest is" + p.fittestIndex);
            p.fittestKromozom.writeGen();
            Console.WriteLine("\nSecond is" + p.secnondFittestIndex);
            p.secondFittestKromozom.writeGen();
            Console.WriteLine("\n");
            p.exchange();
            p.writePopulasyon();


            Console.WriteLine(p.getPopFitness());

            Console.ReadLine();
            */
