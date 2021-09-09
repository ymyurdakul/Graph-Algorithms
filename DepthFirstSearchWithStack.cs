using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node {
        public bool isVisited = false;
        String val;
        public List<Node> komsular = new List<Node>();
        public Node(String value)
        {
            val = value;
        }
        public override string ToString()
        {
            return val;
        }
        
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        Stack<Node> stack;
         
        public void dfs(Node startNode)
        {
          
            stack.Push(startNode);
            while (stack.Count>0)
            {
                Node x = stack.Pop();
                Console.WriteLine(x);
                x.isVisited = true;
                x.komsular.ForEach(komsu => {
                    if (!komsu.isVisited && !stack.Contains(komsu))
                        stack.Push(komsu);
                });
            }

        }

        public Program()
        {
            stack = new Stack<Node>();
            Node n1 = new Node("1");
            Node n2 = new Node("2");
            Node n3 = new Node("3");
            Node n4 = new Node("4");
            Node n5 = new Node("5");
            n1.komsular.Add(n3);
            n1.komsular.Add(n2);
            n1.komsular.Add(n4);
            n2.komsular.Add(n4);
            n3.komsular.Add(n4);
            n4.komsular.Add(n5);
            dfs(n1);
            Console.ReadKey();


        }
    }
}
