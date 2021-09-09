using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        
                int [,]graph=new int[6,6];
                        graph[0,0]=0;
                        graph[0, 1] = 1;
                        graph[0, 2] = 0;
                        graph[0,3]=1;
                        graph[0, 4] = 0;
                        graph[0,5]=0;
                                        graph[1,0]=0;
                                        graph[1,1]=0;
                                        graph[1,2]=1;
                                        graph[1,3]=0;
                                        graph[1,4]=0;
                                        graph[1,5]=0;
            calcDegree(graph,0);
                
                Console.ReadKey();
            
        }
        public static void calcDegree(int [,]arr,int x)
        {
            int degree = 0;
            int dg = 0;
            for (int i = 0; i < 6; i++)
            {
                if (arr[x, i] == 1)
                {
                    degree++;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (arr[i,x]==1)
                {
                    dg++;
                }
            }
            Console.WriteLine("Inner Degree::"+dg);
            Console.WriteLine("DC:::"+degree);
        }
    }
}
