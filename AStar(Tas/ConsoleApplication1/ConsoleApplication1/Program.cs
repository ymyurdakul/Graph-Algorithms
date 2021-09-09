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
            Node node = new Node();
            node.setMatris(new int[3, 3]{
            {1,0,2},{3,4,5},{6,7,8}
            });

              Node çıkış = new Node();
            node.setMatris(new int[3, 3]{
            {1,2,0},{3,4,5},{6,7,8}
            });


           AStarSolver ads=new AStarSolver(node,çıkış);
           ads.solve();

          
          
            Console.ReadLine();

        }
    }
}
