using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _8PuzzleAStar
{
    class Node
    {
        public List<Node> successor;
        public int heuristicCost = 0, realisticCost = 0, fCost = 0;
        public Node parent;
        public int[,] matris = new int[3, 3];
        public void setMatris(int[,] matris)
        {
            this.matris = matris;
            parent = this;
            realisticCost = 0;

        }
        
        
        public Node()
        {
            successor = new List<Node>();
        }
       
      
        public void  writeMatris()
        {
            StringBuilder builder = new StringBuilder();
         
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    builder.Append(" " + matris[i, j]);

                }
                builder.Append(Environment.NewLine);
            }
            MessageBox.Show(builder.Append("F Cost"+this.fCost).ToString());
            
        }
        public String getMatrisAsString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    builder.Append(" " + matris[i, j]);

                }
                builder.Append(Environment.NewLine);
            }

            return builder.ToString();
        }
        public void writeMatris(int[,] matris)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    builder.Append(" " + matris[i, j]);

                }
                builder.Append(Environment.NewLine);
                
            }
            MessageBox.Show(builder.ToString());
        }


    }
}
