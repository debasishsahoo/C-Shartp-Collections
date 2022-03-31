using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsIntro
{
    //Array(1D,2D,Jagged Array,Rectangular Array)
    //Collections
    //ArrayList
    //HashTable
    //Stack and Queue
    //Geneic Collection
    //Dictionary
    internal class Program
    {
        static void Main(string[] args)
        {

            //1D array(Syntax)
            //<Type>[]<name>=new <type>[size]
            //int[] arr = new int[5];
            //int[] arr2;
            //arr2 = new int[5];
            //int[] arr3 = { 10, 20, 30, 40, 50, 60 };

            //create and access array
            int[] arr = new int[6];

            for(int i=0;i<6;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
           

            //insert value
            int a = 10;
            for(int i=0; i<6;i++)
            {
                a += 10;//a=a+10
                arr[i] = a;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Methods we have in Array
            //Sort(<Array>)
            //Reverse(<Array>)
            //Copy(src,dest,n)
            //GetLength(int)
            //Length()


            int[] arr2 = { 17, 12, 45, 28, 10, 5, 7, 2, 91,0 };

            for(int i=0;i<arr2.Length;i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            //SORTING
           Array.Sort(arr2);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            //Reverse
            Array.Reverse(arr2);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            //Copy
            int []arr3=new int [5];

            Array.Copy(arr2,arr3,5);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();

         Console.WriteLine("array Length:"+arr2.Length);
         Console.WriteLine("array length:"+arr2.GetLength(0));
         Console.WriteLine();

            //Type Cast
         var arr4 = new[] { 17,45,86,49,12,73,10};
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();











            Console.ReadKey();









        }
    }
}
