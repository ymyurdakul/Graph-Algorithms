using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    static class FitnessCalc
    {
        public static byte[] solution = new byte[64];
        public static void setSolution(byte[] newSolution)
        {
            solution = newSolution;
        }
        public static void setSolution(String newSlution)
        {
            solution = new byte[newSlution.Length];
            for (int i = 0; i < newSlution.Length; i++)
            {
                solution[i] = Byte.Parse(newSlution[i].ToString());
            }
        }
        public static int getFitness(Kromozom kro)
        {
            int fitness = 0;
            for (int i = 0; i < 64; i++)
            {
                if (kro.genes[i] == solution[i])
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
