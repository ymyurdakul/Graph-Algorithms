using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kromozom
    {
        static Random rnd = new Random();
        
        public byte[] genes = new byte[64];
        //Cache
        private int fitness = 0;

        //Create Random individual
        public void generateIndividual()
        {
            for (int i = 0; i < 64; i++)
            {
                byte gene = (byte)(rnd.Next(0, 2));
                genes[i] = gene;

            }
        }
      
       
        public int getFitness()
        {
            fitness = FitnessCalc.getFitness(this);
            return fitness;
        }
        public override string ToString()
        {
            String geneString = "";
            for (int i = 0; i <64; i++)
            {
                geneString += genes[i];
            }
            return geneString;
        }

    }
   









}
