using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class EightQueenMatrix
    {

      public  char[,] matris = {
                              {'-','-','x','-'}
                             ,{'-','x','-','-'}
                             ,{'-','-','x','-'}
                             ,{'-','x','-','-'} };


        public void matrisYazdir()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********");
        }
        public void matrisSıfırla()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matris[i, j] = '-';
                }
            }
        }
        public void setMatris(int[] genes)
        {
            for (int i = 0; i < 4; i++)
            {
                matris[i, genes[i]] = 'x';
            }

        }
      public  int getFullCost(char[,] matris)
        {
            int all = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matris[i, j] == 'x')
                    {
                        all += getCost(matris, i, j);
                    }
                }
            }
            return all;

        }
        int getCost(char[,] matris, int row, int col)
        {

            int cost = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matris[i, j] == 'x')
                    {
                        if (i == row && j == col)
                        {
                            continue;
                        }
                        if (kontrol(row, col, i, j))
                            cost++;
                    }
                }

            }
            return cost;
        }
        public bool kontrol(int row, int col, int row1, int col1)
        {
            if (row == row1)
            {
                return true;
            }
            if (col == col1)
            {
                return true;
            }
            if (Math.Abs(row - row1) == Math.Abs(col - col1))
            {
                return true;

            }
            return false;

        }
    }
}
