using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Seller
    {
       public String name;
       public bool isVisited=false;
       public bool isMangoSeller = false;
       public List<Seller> komsular = new List<Seller>();
       public Seller(String name)
       {
           this.name = name;
       }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Seller a = new Seller("A");
            Seller b = new Seller("B");
            Seller c = new Seller("C");
            c.isMangoSeller = true;
            Seller d = new Seller("D");
            Seller e = new Seller("E");
            a.komsular.Add(b);
            a.komsular.Add(c);
            c.komsular.Add(d);
            c.komsular.Add(e);
            d.komsular.Add(b);
            Queue<Seller> kuuk = new Queue<Seller>();
            kuuk.Enqueue(a);

            while (kuuk.Count>0)
            {
                Seller x = kuuk.Dequeue();
                if (x.isMangoSeller==false)
                {
                    x.isVisited = true;
                    x.komsular.ForEach(y => {
                        if(!y.isVisited)
                        kuuk.Enqueue(y);
                    });
                }
                else
                {
                    Console.WriteLine(x.name+"Mango seller bulundu");
                    break;
                }
                Console.WriteLine(x.name);
            }
            Console.ReadKey();
        }
    }
}
