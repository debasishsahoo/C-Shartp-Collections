using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Generic_Collections
{
    // internal class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         //Stack<T>
    //         //Queue<T>
    //         //LinkList<T>
    //         //SortedList<T>
    //         //List<T>
    //         //Dictionary<TKey,TValue>
    //         //*<T> ==DATA TYPE

    ////List<string> listofString = new List<string>();
    ////List<int> listofInt = new List<int>();

    //     }
    // }

    public class ClsMain
    {
        private static void Main()
        {
            //bool IsEqual = ClsCalculator.AreEqual(10, 10);
            //bool IsEqual = ClsCalculator.AreEqual("deb", "dev");
            //bool IsEqual = ClsCalculator.AreEqual(3.65, 3.14);


            bool IsEqual = ClsCalculator.AreEqual<int>(11, 10);
            //bool IsEqual = ClsCalculator.AreEqual<string>("deb", "dev");
            //bool IsEqual = ClsCalculator.AreEqual(3.14, 3.14);





            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

            Console.ReadKey();

        }
    }

    public class ClsCalculator
    {
        //public static bool AreEqual(int a,int b )
        //{
        //    return a == b;
        //}
        //public static bool AreEqual(string a, string b)
        //{
        //    return a == b;
        //}
        //public static bool AreEqual(double a, double b)
        //{
        //    return a == b;
        //}

        //public static bool AreEqual(object a, object b)
        //{
        //    return a == b;
        //}

        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }





    }

    ////Generic Class
    //class MyGenClass<A>
    //{
    //    //Generic Varible
    //    private A MemberVar;

    //    //Generic Constructor
    //    public MyGenClass(A Value)
    //    {
    //        MemberVar=Value;
    //    }

    //    //Generic Method
    //    public A genMethod(A parameter)
    //    {
    //Console.WriteLine("Parameter Type {0},  Value {1}", typeof(A).ToString(), parameter);

    //Console.WriteLine("Return Type {0},  Value {1}", typeof(A).ToString(), MemberVar);

    //        return MemberVar;
    //    }


    //    //Generic Property
    //    public A genProperty { get; set; }


    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        MyGenClass<int> a = new MyGenClass<int>(10);

    //        int v=a.genMethod(200);


    //        MyGenClass<string> b = new MyGenClass<string>("Deb");

    //        string w = b.genMethod("Sahoo");

    //        Console.ReadKey();
    //    }
    //}








}
