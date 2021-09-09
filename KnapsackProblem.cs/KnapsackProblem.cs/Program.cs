using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackProblem.cs
{
    class Program
    {
        public static int[,] itemProfitAndWeigth = new int[2, 7] {
            {6,5,8,9,6,7,3},
            {2,3,6,7,5,9,4} };
        public static int maxWeight = 9;
        static void Main(string[] args)
        {
            new Program();

        }
        public Program()
        {
            Population pop = new Population();
            pop.random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(pop.liste[i,j].ToString());
                }
              //  Console.Write(" Fitness::=> "+Function.calc( Program.itemProfitAndWeigth));
                Console.WriteLine();
            }
            Console.ReadLine();



        }
        
    }
}
