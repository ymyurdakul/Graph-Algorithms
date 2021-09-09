using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        int[,] matrix;
        static void Main(string[] args)
        {
            new Program();
        }
        Stack<int> stack;
        List<int> visited;
        void dfs(int index)
        {
            visited = new List<int>();
            stack = new Stack<int>();
            stack.Push(index);
            while (stack.Count>0)
            {
                int currentNode = stack.Pop();
                visited.Add(currentNode);
                Console.WriteLine(currentNode+1);
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[currentNode, i] > 0 && !stack.Contains(i)&&! visited.Contains(i))
                        stack.Push(i);
                }
            }
        
        }
        public Program()
        {
            matrix = new int[,] {{0,4,2,3,0},
                                {0,0,0,1,0},
                                {0,0,0,1,0},
                                {0,0,0,0,1},
                                {0,0,0,0,0}
                                };
            dfs(0);
           
            Console.ReadKey();
        }
    }
}
