using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    {
        public List<Node> successor;
        public int heuristicCost=0, realisticCost=0, fCost=0;
        public Node parrent;
       public int[,] matris = new int[3, 3];
        public void setMatris(int[,] matris)
        {
            this.matris = matris;

        }
        public Node()
        {
            successor = new List<Node>();
        }
        public void createSuccessor()
        {

            //Boşluğun nerde oldugunu anlamaya yarar
            int satirPos = 0;
            int sutunPos = 0;
            bool isFound = false;
            for (int satir = 0; satir < 3; satir++)
            {
                for (int sutun = 0; sutun < 3; sutun++)
                {
                    if (matris[satir, sutun] == 0)
                    {
                        satirPos = satir;
                        sutunPos = sutun;
                        isFound = true;
                        break;
                    }
                    if (isFound) break;
                }
            }
            Node sag = swap(satirPos, sutunPos, satirPos, sutunPos + 1);
            Node sol = swap(satirPos, sutunPos, satirPos, sutunPos - 1);


            Node alt = swap(satirPos, sutunPos, satirPos + 1, sutunPos);
            Node üst = swap(satirPos, sutunPos, satirPos - 1, sutunPos);
            if (sag != null)
                successor.Add(sag);
            if (sol != null)
            {
                successor.Add(sol);
            }
            if (alt != null)
            {
                successor.Add(alt);
            }
            if (üst != null)
            {
                successor.Add(üst);
            }

        }
        public Node swap(int mevcutSatir, int mevcutSutun, int toSatir, int toSutun)
        {
            if (toSatir < 0 | toSutun < 0 | toSutun > 2 | toSatir > 2)
                return null;
            int[,] matrisCopy = (int[,])matris.Clone();

            int temp = matrisCopy[mevcutSatir, mevcutSutun];
            matrisCopy[mevcutSatir, mevcutSutun] = matrisCopy[toSatir, toSutun];
            matrisCopy[toSatir, toSutun] = temp;

            //writeMatris(matrisCopy);
            Node t = new Node();
            t.setMatris(matrisCopy);

            return t;
        }
        public void writeMatris()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + matris[i, j]);

                }
                Console.WriteLine();
            }
        }
        public void writeMatris(int[,] matris)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + matris[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
