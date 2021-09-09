using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PriorityQuee
    {
        public List<Node> nodes;
        public PriorityQuee()
        {
            nodes = new List<Node>();
        }
        public void enquee(Node node)
        {
            nodes.Add(node);
        }
        public Node dequee()
        {
            Node temp;
            if (nodes.Count > 0)
            {
                temp = nodes[0];

            }
            else
                return null;
            nodes.ForEach(nod =>
            {
                if (nod.heuristicCost < temp.heuristicCost)
                {
                    temp = nod;
                }
            });
            nodes.Remove(temp);
            return temp;
        }
        public int count()
        {
            return nodes.Count;
        }
        public bool contains(Node nod)
        {
            return nodes.Contains(nod);
        }
    }
}
