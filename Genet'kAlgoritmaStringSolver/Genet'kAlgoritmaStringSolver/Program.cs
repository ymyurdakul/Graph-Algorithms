using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Individual
    {
        static Random rnd = new Random();
        static int defaultGeneLength = 64;
        private byte[]genes=new byte[defaultGeneLength];
        //Cache
        private int fitness = 0;

        //Create Random individual
        public void generateIndividual()
        {
            for (int i = 0; i < size(); i++)
            {
                byte gene = (byte)(rnd.Next(0,2));
                genes[i] = gene;

            }
        }
        public static void setDefaultGeneLength(int len)
        {
            defaultGeneLength = len;
        }
        public byte getGen(int index)
        { 
            return genes[index];
        }
        public void setGene(int index, byte value)
        {
            genes[index] = value;
            fitness = 0;
        }
        public int size()
        {
            return genes.Length;
        }
        public int getFitness()
        {
            if (fitness==0)
            {
                fitness = FitnessCalc.getFitness(this);
            }
            return fitness;
        }
        public override string ToString()
        {
            String geneString = "";
            for (int i = 0; i < size(); i++)
            {
                geneString += getGen(i);
            }
            return geneString;
        }

    }
   
















    
    class Program
    {
         
        static void Main(string[] args)
        {
            FitnessCalc.setSolution("1111000000000000000000000000000000000000000000000000000000001111");
            Population myPop = new Population(100,true);

            for (int i = 0; i < myPop.kromozomlar.Length; i++)
            {
                Console.WriteLine(myPop.kromozomlar[i].ToString()+" "+FitnessCalc.getFitness(myPop.kromozomlar[i]));
            }
            Console.WriteLine(myPop.getFittest().getFitness());
            Console.WriteLine("------------------------------");
            while (myPop.getFittest().getFitness() < FitnessCalc.getMaxFitness())
            {
                myPop = Algorithm.evolvePopualation(myPop);
                for (int i = 0; i < myPop.kromozomlar.Length; i++)
                {
                    Console.WriteLine(myPop.kromozomlar[i].ToString() + " " + FitnessCalc.getFitness(myPop.kromozomlar[i]));
                }
                Console.WriteLine(myPop.getFittest().getFitness());
                Console.WriteLine("------------------------------");
            }
          
            Console.ReadKey();
           
        }
    }
}
