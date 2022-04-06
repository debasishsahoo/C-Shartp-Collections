using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Dict
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //  Dictionary<string,object> Dict = new Dictionary<string,object>();
            ////Dictionary<string, string> Dict = new Dictionary<string, string>();

            //      Dict.Add("Id",1000);
            //      Dict.Add("Name", "KD");
            //      Dict.Add("Job", "SQL");
            //      Dict.Add("Salary",9000000);
            //      Dict.Add("Locations","KOLKATA");
            //      Dict.Add("IsSingle", false);


            //      foreach (string KEY in Dict.Keys)
            //      {
            //          Console.WriteLine(KEY+":"+Dict[KEY]);
            //      }


            //      Console.WriteLine();

            //      Dict.Remove("IsSingle");

            //      Console.WriteLine();

            //      foreach (string KEY in Dict.Keys)
            //      {
            //          Console.WriteLine(KEY + ":" + Dict[KEY]);
            //      }
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Deb",
                Gender = "Male",
                Salary = 900
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Puja",
                Gender = "FeMale",
                Salary = 980
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Kundan",
                Gender = "Male",
                Salary = 950
            };
            Employee emp4 = new Employee()
            {
                Id = 4,
                Name = "Abir",
                Gender = "Male",
                Salary = 920
            };
            Employee emp5 = new Employee()
            {
                Id = 5,
                Name = "Saikat",
                Gender = "Male",
                Salary = 930
            };
            Employee emp6 = new Employee()
            {
                Id = 6,
                Name = "Poly",
                Gender = "Male",
                Salary = 930
            };
            Employee emp7 = new Employee()
            {
                Id = 7,
                Name = "Amrita",
                Gender = "FeMale",
                Salary = 890
            };
            Employee emp8 = new Employee()
            {
                Id = 8,
                Name = "ASIF",
                Gender = "Male",
                Salary = 820
            };
            Employee emp9 = new Employee()
            {
                Id = 9,
                Name = "RIZ",
                Gender = "Male",
                Salary = 860
            };
            Employee emp10 = new Employee()
            {
                Id = 10,
                Name = "Arnab",
                Gender = "Male",
                Salary = 100
            };

  //Dictionary<Key, Value> DictionaryOfEmployee = new Dictionary<Key, Value>();
  Dictionary<int, Employee> DictionaryOfEmployee = new Dictionary<int, Employee>();

            DictionaryOfEmployee.Add(emp1.Id,emp1);
            DictionaryOfEmployee.Add(emp2.Id, emp2);
            DictionaryOfEmployee.Add(emp3.Id, emp3);
            DictionaryOfEmployee.Add(emp4.Id, emp4);

            Employee empOBj = DictionaryOfEmployee[3];

            Console.WriteLine("ID={0},Name={1},Gender={2},Salary={3}",
               empOBj.Id, empOBj.Name, empOBj.Gender, empOBj.Salary);

            Console.WriteLine();

            foreach(KeyValuePair<int,Employee> EKVP in DictionaryOfEmployee)
            {
                Console.WriteLine("KEY="+EKVP.Key);
                Console.WriteLine("Value=" + EKVP.Value.Name);

            }

            Console.WriteLine();

            foreach (int Key in DictionaryOfEmployee.Keys)
            {
                Console.Write(Key+ " ");

            }
            Console.WriteLine();
            foreach (Employee Abir in DictionaryOfEmployee.Values)
            {
                Console.Write(Abir.Name + " ");

            }
            Console.WriteLine();

            if(!DictionaryOfEmployee.ContainsKey(5))
            {
                DictionaryOfEmployee.Add(5, emp5);
            }
            Console.WriteLine();




            Console.ReadKey();


        }
    }
}
