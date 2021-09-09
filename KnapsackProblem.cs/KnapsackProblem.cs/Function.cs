using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackProblem.cs
{
    class Function
    {
        public static int calc(int []matrix,int[,] pivotMatrix)
        {
            int fitness = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i]==1)
	            {
                    fitness += pivotMatrix[0, i];
	            }
               
            }
            return fitness;
        }
    }
}
