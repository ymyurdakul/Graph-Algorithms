using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class Node
    {
        public bool isVisited = false;
        public String data;
        public Node(String nd)
        {
            data = nd;
        }
    }
    class Program
    {
        //Belge No 3
        List<Node> nodes;
        Queue<Node> queue;
        static void Main(string[] args)
        {
            new Program();
        }
        public List<Node> findNeighbourhoods(int[,]komsuluk_matrisi,Node x)
        {
            List<Node>all=new List<Node>();
            int satir = 0;
            for (int i = 0; i < nodes.Count(); i++)
            {
                if (nodes[i].Equals(x))
                {
                    satir = i;
                }
            }
        
            for (int sutunhiza = 0; sutunhiza < 6; sutunhiza++)
			{
			    if (komsuluk_matrisi[satir,sutunhiza]==1&&!nodes[sutunhiza].isVisited)
	            {
                    if(nodes[sutunhiza].isVisited==false)
		            all.Add(nodes[sutunhiza]);
	            }
			}
            return all;
        }
        public void bfs(int[,]komsuluk_matrisi,Node node)
        {
            queue.Enqueue(node);
            node.isVisited = true;

            ///Node un indexini öğrenmek için
        
                while(queue.Count>0)
                {

                    Node deq = queue.Dequeue();
                    Console.WriteLine(deq.data+"  ");
                    List<Node>neifs= findNeighbourhoods(komsuluk_matrisi,deq);
                    neifs.ForEach(x => {
                    queue.Enqueue(x);
                 
                    x.isVisited = true;
                    });
                    
                }
            
           
        }
        public Program()
        {
            nodes = new List<Node>();
            queue = new Queue<Node>();
            Node n1 = new Node("A");
            Node n2 = new Node("X");
            Node n3 = new Node("Y");
            Node n4 = new Node("Z");
            Node n5 = new Node("T");
            Node n6 = new Node("O");

            nodes.Add(n1);//0 index A yı işaret ediyor
            nodes.Add(n2);
            nodes.Add(n3);
            nodes.Add(n4);
            nodes.Add(n5);
            nodes.Add(n6);

         

            int[,] adjancency_matrix =new int[6,6] { {0,1,1,0,0,0}
                                                    ,{0,0,0,0,0,1}
                                                    ,{0,1,0,1,1,0}
                                                    ,{0,0,0,0,0,1}
                                                    ,{0,0,1,0,0,0}
                                                    ,{0,1,0,0,0,0}};



            bfs(adjancency_matrix,n1);
            Console.ReadLine();
        }

    }
}
