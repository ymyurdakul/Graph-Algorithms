using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

class Node
{
  public  int data;
   public Boolean visited;
    List<Node> neigbours;
   public Node(int data)
    {
        this.data = data;
        this.neigbours = new List<Node>();
    }
   public void addneighbours(Node ne)
    {
        this.neigbours.Add(ne);
    }
    public List<Node> getNighbour()
    {
        return this.neigbours;
    }
    public void setNeigh(List<Node> nief)
    {
        this.neigbours = nief;

    }
}


namespace DepthFirstSearch
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          void dfs(Node node)
        {
            MessageBox.Show(node.data.ToString());
            List<Node> naifs = node.getNighbour();
            node.visited = true;
            for (int i = 0; i < naifs.Count; i++)
            {
                Node x = naifs[i];
                if (x != null && !x.visited)
                {
                    dfs(x);
                }

            }
        }
          void dfsUsingStack(Node node)
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);
            node.visited = true;
            while (stack.Count != 0)
            {
                Node element = stack.Pop();
                MessageBox.Show(element.data.ToString());
                List<Node> naifs = element.getNighbour();
                for (int i = 0; i < naifs.Count; i++)
                {
                    Node n = naifs[i];
                    if (n != null && !n.visited)
                    {
                        stack.Push(n);
                        n.visited = true;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Node node40 = new Node(40);
            Node node10 = new Node(10);
            Node node20 = new Node(20);
            Node node30 = new Node(30);
            Node node60 = new Node(60);
            Node node50 = new Node(50);
            Node node70 = new Node(70);

            node40.addneighbours(node10);
            node40.addneighbours(node20);
            node10.addneighbours(node30);
            node20.addneighbours(node10);
            node20.addneighbours(node30);
            node20.addneighbours(node60);
            node20.addneighbours(node50);
            node30.addneighbours(node60);
            node60.addneighbours(node70);
            node50.addneighbours(node70);


             dfsUsingStack(node40);

        }
    }
}
