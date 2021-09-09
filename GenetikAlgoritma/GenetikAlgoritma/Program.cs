using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kromozom
    {
     public   int uygunluk = 0;
    public    int []genes=new int[5];
        static Random rnd = new Random();
        int genBoyutu = 5;
        public Kromozom()
        {
            Random rn = new Random();
           
            //Set genes randomly for each individual
            for (int i = 0; i < genes.Count(); i++)
            {
               
               int res= Math.Abs(Kromozom.rnd.Next() % 2);
               genes[i] = res;
               
            }

            uygunluk = 0;
        }
        public void write()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(genes[i]);
            }
            calcFitness();
            Console.WriteLine("--->"+uygunluk+"\n");
        }
        public Kromozom(int[] genler)
        {
            for (int i = 0; i < genes.Length; i++)
            {
                this.genes[i]=genler[i];
            }
        }
        public void calcFitness()
        {
            this.uygunluk = 0;
            for (int i = 0; i < 5; i++)
            {
                if (genes[i]==1)
                {
                    ++uygunluk;
                }
            }
        }
    
    }
    class Population
    {
        int popSize = 10;
        public Kromozom[] kromozomlar=new Kromozom[10];
      public int fittest = 0;

        public void initializePopulation()
        {
            for (int i = 0; i < kromozomlar.Count(); i++)
            {
                kromozomlar[i] = new Kromozom();
            }
        }
       
        public Kromozom getFittest() {
            int maxFit = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < kromozomlar.Count(); i++)
            {
                if (maxFit<=kromozomlar[i].uygunluk)
                {
                    maxFit = kromozomlar[i].uygunluk;
                    maxIndex = i;
                }
            }

            fittest = kromozomlar[maxIndex].uygunluk;
            return kromozomlar[maxIndex];
        
        }
        public Kromozom getSecondFittest()
        {

            int maxFit1 = 0;
            int maxFit2 = 0;
            for (int i = 0; i < kromozomlar.Count(); i++)
            {
                if (kromozomlar[i].uygunluk>kromozomlar[maxFit1].uygunluk)
                {
                    maxFit2 = maxFit1;
                    maxFit1 = i;
                }
                else if (kromozomlar[i].uygunluk > kromozomlar[maxFit2].uygunluk)
                {
                    maxFit2 = i;
                }
               
            }
            return kromozomlar[maxFit2];
        }
        public int getLeastFittestIndex() {
            int minFitVal = int.MaxValue;
            int minFitIndex = 0;
            for (int i = 0; i < kromozomlar.Count(); i++)
            {
                if (minFitVal>=kromozomlar[i].uygunluk)
                {
                    minFitVal = kromozomlar[i].uygunluk;
                    minFitIndex = i;
                }
            }
            return minFitIndex;
        }
        public void calculateFitness() {
            kromozomlar.ToList().ForEach(k=>k.calcFitness());
            getFittest();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            new Program();

        }
        Population population = new Population();
        Kromozom fittest;
        Kromozom secondFittest;
        int generationCount = 0;
        static Random rnd = new Random();
        public Program()
        {
            population.initializePopulation();

            population.calculateFitness();

            Console.WriteLine("Jeneraasyon : "+generationCount+" Fittest ::"+population.getFittest().uygunluk);
            population.kromozomlar.ToList().ForEach(f=>f.write());
            while (population.fittest<5)
            {
                 ++generationCount;
                selection();
                crossover();
                if (Program.rnd.Next()%2==0)
                {
                    mutation();
                }
                addFittestOffSpring();
                population.calculateFitness();
                Console.WriteLine("Jeneraasyon : " + generationCount + " Fittest ::" + population.getFittest().uygunluk);
                population.kromozomlar.ToList().ForEach(f=>f.write());

            }
            
               
             
Console.ReadLine();
            
        
        }
        public void selection()
        {

            fittest = population.getFittest();
            secondFittest = population.getSecondFittest();
        }
        public void crossover()
        {
            int crossOverPoint = Program.rnd.Next(5);
            for (int i = 0; i < crossOverPoint; i++)
            {
                int temp = fittest.genes[i];
                fittest.genes[i] = secondFittest.genes[i];
                secondFittest.genes[i] = temp;
            }
        }
        void mutation() {
            int mutationPoint = Program.rnd.Next(5);
            if (fittest.genes[mutationPoint] == 0)
            {
                fittest.genes[mutationPoint] = 1;
            }
            else {
                fittest.genes[mutationPoint] = 0;
            }
            mutationPoint = Program.rnd.Next(5);

            if (secondFittest.genes[mutationPoint]==0)
            {
                secondFittest.genes[mutationPoint] = 1;
            }
            else
            {
                secondFittest.genes[mutationPoint] = 0;
            }
        }
        Kromozom getFittestOffSpring()
        {
            if (fittest.uygunluk>secondFittest.uygunluk)
            {
                return fittest;
            }
            return secondFittest;
        }
        public void addFittestOffSpring()
        {
            fittest.calcFitness();
            secondFittest.calcFitness();
            int leastFittestIndex=population.getLeastFittestIndex();
            population.kromozomlar[leastFittestIndex] = getFittestOffSpring();
        }

    }
}
