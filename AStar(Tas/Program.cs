using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    { 
        int [,]matris=new int[3,3];
        public void setMatris(int[,] matris)
        {
            this.matris = matris;
        }
        public Node()
        { 
        
        }
        public int[,] swap(int mevcutSatir, int mevcutSutun, int toSatir, int toSutun)
        {
            if (toSatir < 0 | toSutun < 0)
                return null;
            int[,] matrisCopy =(int[,]) matris.Clone();
            
            int temp=matrisCopy[mevcutSatir, mevcutSutun];
            matrisCopy[mevcutSatir,mevcutSutun]=matrisCopy[toSatir,toSutun];
            matrisCopy[toSatir,toSutun]=temp;
             
            writeMatris(matrisCopy);
            return matrisCopy;
        }
        public void writeMatris()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" "+matris[i,j]);
             
               }
                Console.WriteLine();
            }
        }
        public void writeMatris(int [,]matris)
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
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            node.setMatris(new int[3,3]{
            {1,0,2},{3,4,5},{6,7,8}
            });
            node.writeMatris();
            node.swap(0,1,0,2);
            node.swap(0, 1, 0, 0);
            node.swap(0, 1, 1, 1);
            node.swap(0, 1, -1, 2);
            Console.ReadLine();

        }
    }
}
