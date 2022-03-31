using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();

            Console.WriteLine("----------------------Data Capacity------------------------");
            Console.WriteLine("Initial Capacity:"+A1.Capacity);

            Console.WriteLine("----------------------Data Add------------------------");
            A1.Add(10);
            Console.WriteLine("After First Element Capacity:" + A1.Capacity);

            A1.Add("KUNDAN");
            Console.WriteLine("After Second Element Capacity:" + A1.Capacity);

            A1.Add(true);
            Console.WriteLine("After Third Element Capacity:" + A1.Capacity);

            A1.Add(3.14f);
            Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);
            A1.Add(3.14f);
            Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);
            A1.Add(3.14f);
            Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);

            A1.Add(null);
            Console.WriteLine("After Six Element Capacity:" + A1.Capacity);

            A1.Add('M');
            Console.WriteLine("After Fifth Element Capacity:" + A1.Capacity);

            

            Console.WriteLine("----------------------Data View------------------------");

            for (int i=0;i<A1.Count;i++)
            {
                Console.WriteLine(A1[i]+" ");
            }
            Console.WriteLine("---------------------Data Delete-------------------------");

            A1.Remove(true);
            A1.Remove(null);
            A1.RemoveAt(2);

            foreach(object obj in A1)
            {
                Console.WriteLine(obj+" ");
            }
            Console.WriteLine("---------------------Data Insert-------------------------");

            A1.Insert(1,"Asif");

            foreach (object obj in A1)
            {
                Console.WriteLine(obj + " ");
            }

            Console.WriteLine("---------------------Array List Colne -------------------------");
            ArrayList Col1=new ArrayList(A1);

            Console.WriteLine("Initial Capacity Col1:"+Col1.Capacity);

            foreach (object obj in Col1)
            {
                Console.WriteLine(obj + " ");
            }
            Console.ReadKey();

        }
    }
}
