using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        int[,] matrix;
        bool[] visited;

        static void Main(string[] args)
        {
            new Program().start();

        }
        public void start()
        {
            readMatrix();
            showMatrix();
            BFS(2);
            Console.ReadKey();
        }
        public void BFS(int root)
        {
            Queue<int> kuyruk = new Queue<int>();
            kuyruk.Enqueue(root);visited[root] = true;
            while (kuyruk.Count>0)
            {
                root = kuyruk.Dequeue();
                Console.WriteLine(root);
                
                 for (int i = 0; i < 6; i++)
            {
                if (matrix[root, i] == 1 && visited[i] == false)
                {
                    kuyruk.Enqueue(i);
                    visited[i] = true;
                }
              
            }
             
                
            }
               
                


        }
        public void readMatrix()
        {
            visited = new bool[6];
         
            for (int i = 0; i < visited.Count(); i++)
            {
                visited[i] = false;
            }
            matrix=new int[6,6];
            String []allLines=File.ReadAllLines(@"C:\Users\Mustafa\Desktop\Algoritmalar\matris.txt");
            for (int i = 0; i < allLines.Count(); i++)
            {
                String[] splited= allLines[i].Split(' ');
                for (int j = 0; j < splited.Count(); j++)
                {
                    matrix[i, j] = int.Parse(splited[j]);
                }
                
               
            }
           
        }
        public void showMatrix()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
