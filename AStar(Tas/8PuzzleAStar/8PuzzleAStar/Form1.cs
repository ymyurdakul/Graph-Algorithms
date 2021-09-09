using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8PuzzleAStar
{
    public partial class Form1 : Form
    {
        Node giris, cikis;
        NodeSolver nodeSolver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nodeSolver = new NodeSolver();
             giris = new Node();
            giris.setMatris(new int[3, 3]{
            {1,2,3},{0,4,6},{7,5,8}
            
            });

             cikis = new Node();
            int[,] cikisMatrisi = new int[3, 3]{
            {1,2,3},{4,5,6},{7,8,0}
            };
            cikis.setMatris(cikisMatrisi);

            giris.parent = null;
            //Giris olduğu belli olsun
            


            solve();

            


        
           
            
        }
        
        public void solve()
        {
            PriorityQuee açıkListe = new PriorityQuee();
            QueePrinter printer = new QueePrinter(açıkListe);
            List<Node> kapalıListe = new List<Node>();
            açıkListe.enquee(giris);
            bool isFound = false;
            while (açıkListe.count() > 0)
            {
                //printer.writeQuee();
                Node current = açıkListe.dequee();
                MessageBox.Show(açıkListe.count().ToString());
                nodeSolver.calcHeuristic(current,cikis);
                nodeSolver.calcRealistic(current);
                nodeSolver.calcFVal(current);
               current.writeMatris();
                if (nodeSolver.compareMatris(current,cikis))
                {
                    MessageBox.Show("Bulundu");
                    return;
                }
                nodeSolver.createSuccessor(current);
                current.successor.ForEach(sc => {
                    nodeSolver.calcHeuristic(sc, cikis);
                    nodeSolver.calcRealistic(sc);
                    nodeSolver.calcFVal(sc);
                });

                current.successor.ForEach(x=>açıkListe.enquee(x));
                kapalıListe.Add(current);
                

            }
        
        }
        private void btnÇöz_Click(object sender, EventArgs e)
        {
             

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
