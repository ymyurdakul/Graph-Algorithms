using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
namespace ConsoleApplication1
{
    class Node
    {
     public   String data;
       public bool visited;
       public bool isSeller = false;
        List<Node> neighbours;
        public  Node(String data)
        {
            this.data = data;
            this.neighbours = new List<Node>();
        }
        public void addNiegbour(Node node)
        {
            this.neighbours.Add(node);
        }
        public List<Node> getNeigbhbour()
        {
            return neighbours;
        }
        public void setNeighbour(List<Node> neighs)
        {
            this.neighbours = neighs;
        }
    }
 
    class Program
    {
        private Queue<Node> queue;
        List<Node> nodes = new List<Node>();

        public Program()
        {
            queue = new Queue<Node>();

            Node kn1 = new Node("MUSTAFA");
            Node kn2 = new Node("ALİ");
            Node kn3 = new Node("BEGUM");
            Node kn4 = new Node("ESMA");

            Node kn5 = new Node("BANU");
            Node kn6 = new Node("HILAL");
            Node kn7 = new Node("MAHMUT");
            kn7.isSeller = true;
            //Mustafa
            kn1.addNiegbour(kn2);
            kn1.addNiegbour(kn3);
            kn1.addNiegbour(kn7);
            //Ali
            kn2.addNiegbour(kn3);
            kn2.addNiegbour(kn1);
            //Begüm
            kn3.addNiegbour(kn2);
            kn3.addNiegbour(kn4);
            kn3.addNiegbour(kn1);
            //Esma için
            kn4.addNiegbour(kn1);
            //maho
            kn7.addNiegbour(kn1);
            kn7.addNiegbour(kn5);
            kn7.addNiegbour(kn6);
            //hilal
            kn6.addNiegbour(kn7);
            //Banu
            kn5.addNiegbour(kn7);

            bfs(kn1);
            Console.ReadLine();









        }
        public void bfs(Node node)
        {
            queue.Enqueue(node);
            node.visited = true;
            while (queue.Count>0)
            {
                
                Node x = queue.Dequeue();
                Console.WriteLine(x.data);
                if (x.isSeller)
                {
                    Console.WriteLine("Mango Satıcı Bulundu");
                    return;
                }
                List<Node> nf = x.getNeigbhbour();
                nf.ForEach(nd => {

                    if (nd != null && !nd.visited)
                    {
                        queue.Enqueue(nd);
                        nd.visited = true;
                    }
                });
            }
        }





        static void Main(string[] args)
        {

            new Program();
        }
    }
}
