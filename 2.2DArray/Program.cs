using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2DArray
{
    internal class Program
    {

        //2D array(RECTANGULAR ARRAY Syntax)
        //<Type>[,]<name>=new <type>[row,col]
        //int[,] arr = new int[5,5];

        //int[,] arr2;
        //arr2 = new int[5,5];

        //int[,] arr3 = { list of values };
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];

            int[,] arr2 = { {1,2,3 },{ 4,5,6} };
            int a = 0;

            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    a += 5;
                    arr[i, j] = a;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();





           Console.ReadKey();
        }
    }
}
