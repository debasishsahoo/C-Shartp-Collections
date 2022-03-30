using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JaggedArrayIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2D array(JAGGED ARRAY Syntax)

            //<Type>[],[]<name>=new <type>[row][]

            //int[],[] arr = new int[5],[];

            int [][] arr = new int[4][];

            arr[0] = new int[3];
            arr[1] = new int[6];
            arr[2] = new int[12];
            arr[3] = new int[24];

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    arr[i][j] = j++;
                }

            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //for (int j = 0; j < arr[i].Length; j++)
                //{
                //    Console.Write(arr[i][j]+" "); 
                //}

                foreach(int x in arr[i])
                {
                    Console.Write(x+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();







        }
    }
}
