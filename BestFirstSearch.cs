using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    {
        public bool isVisited = false;
        public List<Node> komsular;
        public String val;
        public int heuristicCost = 999;
        public Node(String val, int estimatedCost)
        {
            this.val = val;
            this.heuristicCost = estimatedCost;
            komsular = new List<Node>();
        }

       
    }
    class PriorityQuee
    {
        private List<Node> all;
        public PriorityQuee()
        {
            all = new List<Node>();

        }
        public void enquee(Node node)
        {
            all.Add(node);
        }
        public Node dequee() {
            if(all.Count>0)
            {
            Node x = all[0];
            all.ForEach(nod => {
                if (nod.heuristicCost < x.heuristicCost)
                    x = nod;
            });
            
            all.Remove(x);
            return x;
            }
            return null;
        }
        public void writeAllQuee()
        {
            all.ForEach(nod => {
                Console.WriteLine(nod.val+"-"+nod.heuristicCost);
            });
        }
        public bool contains(Node nod)
        {
            return all.Contains(nod);
        }
    
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            Node s = new Node("s",1);
            Node a = new Node("a",3);

            Node b = new Node("b", 6);
            Node c = new Node("c", 5);

            Node d = new Node("d", 9);
            Node e = new Node("e", 8);


            Node f = new Node("f", 12);
            Node g = new Node("g", 14);

            Node h = new Node("h", 7);
            Node j = new Node("j", 6);

            Node ı = new Node("ı", 5);
            Node k = new Node("k", 1);
            Node l = new Node("l",10);
            Node m = new Node("m", 2);
            s.komsular.Add(a);
            s.komsular.Add(b);
            s.komsular.Add(c);

            a.komsular.Add(d);
            a.komsular.Add(e);

            b.komsular.Add(f);
            b.komsular.Add(g);

            c.komsular.Add(h);

            h.komsular.Add(j);
            h.komsular.Add(ı);

            ı.komsular.Add(k);
            ı.komsular.Add(m);
            ı.komsular.Add(l);
            
            bestFirstSearch(s,ı);
            Console.ReadLine();
        }
        public static void bestFirstSearch(Node start, Node goal)
        {
            PriorityQuee quee = new PriorityQuee();
            quee.enquee(start);
            start.isVisited = true;
            start.heuristicCost = 0;

            Node temp;
            while((temp=quee.dequee())!=null)
            {
                Console.WriteLine(temp.val);
                if (temp.val == goal.val)
                    return;
                temp.komsular.ForEach(nod => {
                    if (nod.isVisited == false&&quee.contains(nod)==false)
                        quee.enquee(nod); nod.isVisited = true;
                });
            }

         
        
        }
    }
}
