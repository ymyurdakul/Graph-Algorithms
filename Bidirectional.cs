using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    { 
        public  String data;
        private HashSet<Node> adjacentNodes = new HashSet<Node>(); 
        public  Node(String data)
        {
            this.data = data;
        }

        public String getData() {
            return data;
        }

        public HashSet<Node > getAdjacentNodes()
        {
            return adjacentNodes;
        }
        public bool addAdjacentNode(Node  node) {
            return adjacentNodes.Add(node);
        }
    
    }
    class BidirectioanalSearch {
        public static bool pathExists(Node a, Node b)
        {
            Queue<Node> queeA = new Queue<Node>();
            Queue<Node> queeB = new Queue<Node>();

            HashSet<Node> visitedA = new HashSet<Node>();
            HashSet<Node> visitedB = new HashSet<Node>();
            visitedA.Add(a);
            visitedB.Add(b);

            queeA.Enqueue(a);
            queeB.Enqueue(b);

            while (queeA.Count > 0 | queeB.Count > 0)
            {
                if (pathExistHelper(queeA,visitedA,visitedB))
                {
                    return true;
                }
                if (pathExistHelper(queeB,visitedB,visitedA))
                {
                    return true;
                }
            }
            return false;

        }
        public static bool pathExistHelper(Queue<Node> quee,
            HashSet<Node> visitedFromThisSide, HashSet<Node> visitedFromThatSide)
        {
            if (quee.Count>0)
            {
                Node next = quee.Dequeue();
                HashSet<Node> adjacentNodes = next.getAdjacentNodes();
                foreach (Node item in adjacentNodes)
                {
                    if (visitedFromThatSide.Contains(item))
                    {
                        return true;
                    }
                    else if(visitedFromThisSide.Add(item))
                    {
                        Console.WriteLine(item.data);
                        quee.Enqueue(item);
                    }
                }
               
               
            }
        
         return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node[] nodes =new Node[1001];
            nodes[1] = e;
            for (int i = 2; i < 100; i++)
            {
                nodes[i] = new Node(((char)65+i).ToString());
                nodes[i].addAdjacentNode(nodes[i-1]);
            }
            a.addAdjacentNode(b);
            b.addAdjacentNode(c);
            c.addAdjacentNode(d);
            d.addAdjacentNode(e);
            BidirectioanalSearch bs = new BidirectioanalSearch();
            BidirectioanalSearch.pathExists(a,e);
            Console.ReadLine();
            
        }
    }
}
