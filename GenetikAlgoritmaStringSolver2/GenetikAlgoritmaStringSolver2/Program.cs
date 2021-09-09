using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            FitnessCalc.setSolution("0000000000000000000000000000000000000000000000000000000000000000");
            Population myPop = new Population(100, true);
            int i = 0;
            while(myPop.getFittest().getFitness()!=64)
            {
                /*
                foreach (Kromozom item in myPop.kromozomlar)
                 {
                    Console.WriteLine(item.ToString()+"  Fitness::"+item.getFitness());
                }
                Console.WriteLine("------------------------------------------------");
                 * */
                i++;
                Console.WriteLine(myPop.getFittest().ToString()+" Fitness::"+myPop.getFittest().getFitness());
                if(i%2==0)
                myPop = Algorithm.evolvePopualation(myPop,true);
                else
                    myPop = Algorithm.evolvePopualation(myPop, false);
            }
            Console.WriteLine( myPop.getFittest().ToString()+"   Fitness::"+myPop.getFittest().getFitness());
            
             

            Console.ReadKey();
        }
    }
}
