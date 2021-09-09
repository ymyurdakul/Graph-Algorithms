using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int GEN_SAYISI = 10;
        public static int KROMOZOM_SAYISI = 10;
        public static int BOUND = 20;
        public static int[] fayda = new int[] {30,40,20,20,30,15,25,30,35,20 };
        public static int[] agirlik = new int[] {15,6,2,19,18,14,13,8,11,17 };
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Population pop = new Population();
            pop.initialize();
            pop.setBest();
           // pop.print();
            Console.Write("Best");
            pop.Best.print();
            for (int i = 0; i < 1000; i++)
            {
                 pop = Algorithm.evolvePopulation(pop);
         //   pop.print();
            pop.setBest();
            Console.Write("Best");
            pop.Best.print();
            }
           
            
           


            Console.ReadLine();
        }
    }
}
