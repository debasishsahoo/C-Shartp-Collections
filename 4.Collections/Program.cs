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
            //ArrayList A1 = new ArrayList();

            //Console.WriteLine("----------------------Data Capacity------------------------");
            //Console.WriteLine("Initial Capacity:"+A1.Capacity);

            //Console.WriteLine("----------------------Data Add------------------------");
            //A1.Add(10);
            //Console.WriteLine("After First Element Capacity:" + A1.Capacity);

            //A1.Add("KUNDAN");
            //Console.WriteLine("After Second Element Capacity:" + A1.Capacity);

            //A1.Add(true);
            //Console.WriteLine("After Third Element Capacity:" + A1.Capacity);

            //A1.Add(3.14f);
            //Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);
            //A1.Add(3.14f);
            //Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);
            //A1.Add(3.14f);
            //Console.WriteLine("After Fourth Element Capacity:" + A1.Capacity);

            //A1.Add(null);
            //Console.WriteLine("After Six Element Capacity:" + A1.Capacity);

            //A1.Add('M');
            //Console.WriteLine("After Fifth Element Capacity:" + A1.Capacity);

            

            //Console.WriteLine("----------------------Data View------------------------");

            //for (int i=0;i<A1.Count;i++)
            //{
            //    Console.WriteLine(A1[i]+" ");
            //}
            //Console.WriteLine("---------------------Data Delete-------------------------");

            //A1.Remove(true);
            //A1.Remove(null);
            //A1.RemoveAt(2);

            //foreach(object obj in A1)
            //{
            //    Console.WriteLine(obj+" ");
            //}
            //Console.WriteLine("---------------------Data Insert-------------------------");

            //A1.Insert(1,"Asif");

            //foreach (object obj in A1)
            //{
            //    Console.WriteLine(obj + " ");
            //}

            //Console.WriteLine("---------------------Array List Colne -------------------------");
            //ArrayList Col1=new ArrayList(A1);

            //Console.WriteLine("Initial Capacity Col1:"+Col1.Capacity);

            //foreach (object obj in Col1)
            //{
            //    Console.WriteLine(obj + " ");
            //}

            //ArrayList Emp=new ArrayList();
            //Emp.Add(1002);
            //Emp.Add("Kundan");
            //Emp.Add("SEARCHING");

            //Emp.Add(1003);
            //Emp.Add("Abir");
            //Emp.Add("POKEING");

            //Emp.Add(1004);
            //Emp.Add("MIR");
            //Emp.Add("143");

            //Emp.Add(1005);
            //Emp.Add("Debasish");
            //Emp.Add("TRAP");

            //Console.WriteLine("MIR:"+Emp[8]);



            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("ID",1002);
            //hashtable.Add(hashtable["ID"], "Kundan");
            //hashtable.Add(hashtable[1002], "SEARCHING");



            //hashtable.Add("id", 1004);
            //hashtable.Add("name", "MIR");
            //hashtable.Add("job", "143");

            //hashtable.Add("id", 1005);
            //hashtable.Add("name", "Debasish");
            //hashtable.Add("job", "TRAP");

            //hashtable.Add("id", 1003);
            //hashtable.Add("name", "Abir");
            //hashtable.Add("job", "POKEING");

            //Console.WriteLine("ID:" + hashtable["id"]);

            //foreach (object key in hashtable.Keys)
            //{
            //    Console.WriteLine(key +":"+ hashtable[key]);
            //}

            //Console.WriteLine("is Email id Key Exist:"+ hashtable.ContainsKey("Emailid"));
            //Console.WriteLine("is Email id Key Exist:" +hashtable.ContainsKey("name"));


            //Console.WriteLine("is Kundan value Exist:" + hashtable.ContainsValue("kundan"));
            //Console.WriteLine("is Abir Value  Exist:" + hashtable.ContainsValue("Abir"));


//            Stack S= new Stack();

//            S.Push(10);
//            S.Push("Kunden");
//            S.Push(3.14f);
//            S.Push(true);
//            S.Push(67.1f);
//            S.Push('A');

//            foreach(object obj in S)
//            {
//                Console.WriteLine(obj + " ");
//            }
//            Console.WriteLine("-------------------------");

//            Console.WriteLine(S.Pop());

//            Console.WriteLine("--------------------------");

//            foreach(object obj in S)
//            {
//                Console.WriteLine(obj+" ");
//            }
//            Console.WriteLine("-------------------------");

//            Console.WriteLine(S.Peek());

//            Console.WriteLine("--------------------------");

//Console.WriteLine($"No of Element in the Collections:{S.Count}");
//Console.WriteLine($"Value present in Collections:{S.Contains("Kunden")}");

//            S.Clear();

//            Console.WriteLine($"No of Element in the Collections after Clear Method :{S.Count}");

            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue("Deb");
            //queue.Enqueue('A');
            //queue.Enqueue(3.14f);
            //queue.Enqueue(true);
            //queue.Enqueue(67.8);

            //foreach (object obj in queue)
            //{
            //    Console.WriteLine(obj + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.Contains("Deb"));
            //queue.Clear();
            //Console.WriteLine(queue.Count);

            //Console.WriteLine();


            //Stack S = new Stack();
            //Queue queue = new Queue();
            //Hashtable hashtable = new Hashtable();
            //ArrayList A1 = new ArrayList();


            int a = 23;
            Object obj = a; //Boxing        //implicit Typecast
            a = 1500;
            Console.WriteLine(a);//1500
            Console.WriteLine(obj);//23


            int b = 1120;
            Object obj2 = b;
            int c = (int)obj2;//Unboxing     //Explicit TypeCast 


















            Console.ReadKey();

































            Console.ReadKey();

        }
    }
}
