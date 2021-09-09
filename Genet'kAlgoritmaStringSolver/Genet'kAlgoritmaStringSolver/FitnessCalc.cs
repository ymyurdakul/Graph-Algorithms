using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 static   class FitnessCalc
    {
        static byte[]solution=new byte[64];
        public static void setSolution(byte[] newSolution)
        {
            solution = newSolution;
        }
        public static void setSolution(String newSlution)
        { 
            solution=new byte[newSlution.Length];
            for (int i = 0; i < newSlution.Length; i++)
            {


              
                    solution[i] = Byte.Parse(newSlution[i].ToString());
                
               
            }
        }
        public static int getFitness(Individual ind)
        {
            int fitness = 0;
            for (int i = 0; i < ind.size(); i++)
            {
                if (ind.getGen(i)==solution[i])
                {
                    fitness++;
                }
            }
            return fitness;
        }
        public static int getMaxFitness()
        {
            return 50;
        }
    }
}
