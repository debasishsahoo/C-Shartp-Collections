using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.GenericListCillections
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<int> list = new List<int>();

        //    Console.WriteLine("Initial Capacity:" + list.Capacity);
        //    list.Add(10);
        //    Console.WriteLine("Capacity after adding First item:" + list.Capacity);
        //    list.Add(20);
        //    list.Add(30);
        //    list.Add(40);
        //    Console.WriteLine("Capacity after adding Forth item:" + list.Capacity);
        //    list.Add(50);
        //    Console.WriteLine("Capacity after adding Fifth item:" + list.Capacity);

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.Write(list[i] + " ");
        //    }
        //    Console.WriteLine();

        //    list.Remove(30);
        //    list.RemoveAt(1);
        //    list.Insert(2, 25);


        //    foreach (int item in list)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //    Console.WriteLine();
        //        Console.ReadKey();
        //    }\

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Deb",
                Gender = "Male",
                Salary = 90000000
            };
            Employee emp2 = new Employee()
            {
                Id = 1,
                Name = "Puja",
                Gender = "FeMale",
                Salary = 98000000
            };
            Employee emp3 = new Employee()
            {
                Id = 1,
                Name = "Kundan",
                Gender = "Male",
                Salary = 95000000
            };
            Employee emp4 = new Employee()
            {
                Id = 1,
                Name = "Abir",
                Gender = "Male",
                Salary = 92000000
            };

            List<Employee> ListOfEmployee = new List<Employee>();

            ListOfEmployee.Add(emp1);
            ListOfEmployee.Add(emp2);
            ListOfEmployee.Add(emp3);
            ListOfEmployee.Add(emp4);

            foreach(Employee e in ListOfEmployee)
            {
                Console.WriteLine("ID={0},Name={1},Gender={2},Salary={3}",
                    e.Id,e.Name,e.Gender,e.Salary);
            }

            Console.WriteLine();
            Console.ReadKey();






        }



    }
}
