using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AStarSolver
    {
        Node giris, çikiş;
        
        public AStarSolver(Node giris,Node çıkış)
        {
            this.giris = giris;
            this.çikiş = çıkış;
        }
        public void solve()
        {
            PriorityQuee açıkListe = new PriorityQuee();
            List<Node> kapalıListe = new List<Node>();
            açıkListe.enquee(giris);
            bool isFound = false;

            while (açıkListe.count() > 0)
            {
                Node current = açıkListe.dequee();
                current.writeMatris();
                if (current==çikiş)
                {
                    current.writeMatris();
                    return;
                }
                current.createSuccessor();
                current.successor.ForEach(child => {
                   // child.realisticCost += 1;
                    child.heuristicCost = getHeuristic(child.matris);
                     //if (açıkListe.contains(child)&&child.fVal<child.gValue+child.heurisicVal)
                    if (açıkListe.contains(child)&&child.fCost<child.realisticCost+child.heuristicCost)
                    {
                        child.fCost = child.heuristicCost + child.realisticCost+1;
                        child.parrent = current;
                        açıkListe.nodes.Remove(child);
                        açıkListe.nodes.Add(child);
                    }
                    else if (kapalıListe.Contains(child) && child.fCost < child.realisticCost + child.heuristicCost)
                    {


                        child.fCost = child.heuristicCost + child.realisticCost;
                        child.parrent = current;
                        kapalıListe.Remove(child);
                        kapalıListe.Add(child);
                    }
                     else
                    {

                        child.fCost = child.heuristicCost + child.realisticCost;
                        child.parrent = current;
                        açıkListe.enquee(child);
                    }

                    kapalıListe.Add(current);
                    
                   
                    if (child == çikiş)
                    {
                       // Console.WriteLine("bulundu"+child.fVal);
                        isFound = true;
                        return;

                    }
	                

                });

            }
        }
        public int getHeuristic(int[,] matris)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (çikiş.matris[i,j]==matris[i,j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
    