using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //Belge no2
    class Node{
       public int data;
        public bool visited = false;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Program
    {  
        static void Main(string[] args)
        {
            new Program();
        }
        private Queue<Node> quee;
        List<Node> nodes = new List<Node>();
        
      
        public Program()
        {
            quee = new Queue<Node>();
            Node node40 = new Node(400);
            Node node10 = new Node(100);
            Node node20 = new Node(200);
            Node node30 = new Node(300);
            Node node60 = new Node(600);
            Node node50 = new Node(500);
            Node node70 = new Node(700);

            nodes.Add(node40);
            nodes.Add(node10);
            nodes.Add(node20);
            nodes.Add(node30);
            nodes.Add(node60);
            nodes.Add(node50);
            nodes.Add(node70);

           int [,]adjacency_matrix = {
				{0,1,1,0,0,0,0}, // Node 1: 40
				{0,0,0,1,0,0,0}, // Node 2 :10
				{0,1,0,1,1,1,0}, // Node 3: 20
				{0,0,0,0,1,0,0}, // Node 4: 30
				{0,0,0,0,0,0,1}, // Node 5: 60
				{0,0,0,0,0,0,1}, // Node 6: 50
				{0,0,0,0,0,0,0}, // Node 7: 70
		};
           bfs(adjacency_matrix,node10);
           Console.ReadLine();












        }
        public List<Node> findNighbours(int [,]adjacency_matrix,Node x)
        {
            int nodeIndex = -1;
            List<Node> neigbourbods = new List<Node>();
            for (int i = 0; i < nodes.Count(); i++)
            {
                if (nodes[i].Equals(x))
                {
                    nodeIndex = i;
                    break;
                }
            }
            if (nodeIndex!=-1)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (adjacency_matrix[nodeIndex,j]==1)
                    {
                        neigbourbods.Add(nodes[j]);
                    }
                }
            }
            return neigbourbods;
        }

        public void bfs(int [,]adcacenjy_matrix,Node node)
        {
            quee.Enqueue(node);
            node.visited = true;
            while (quee.Count>0)
            {
                Node element = quee.Dequeue();
                Console.WriteLine("Data+====----    "+element.data);
                List<Node> neighs = findNighbours(adcacenjy_matrix,element);
                for (int i = 0; i < neighs.Count; i++)
                {
                    Node x=neighs[i];
                    if (x!=null&&!x.visited)
                    {
                        quee.Enqueue(x);
                        x.visited = true;
                    }
                }
            }
            
        }



    }
}
