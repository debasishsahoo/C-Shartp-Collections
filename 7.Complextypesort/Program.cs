using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Complextypesort
{

    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x,Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
       
    }

    public class Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee emp) 
        {
            if(this.Salary>emp.Salary)
            {
                return 1;
            }
            else if(this.Salary < emp.Salary)
            {
                return -1;
            }
            else { return 0; }
        }

        

    }

    public class Program
    {
        public static void Main(string[] args)
        {
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
                Salary = 1000
            };

            List<Employee> ListOfEmployee = new List<Employee>();

            ListOfEmployee.Add(emp1);
            ListOfEmployee.Add(emp2);
            ListOfEmployee.Add(emp3);
            ListOfEmployee.Add(emp4);
            ListOfEmployee.Add(emp5);
            ListOfEmployee.Add(emp6);
            ListOfEmployee.Add(emp7);
            ListOfEmployee.Add(emp8);
            ListOfEmployee.Add(emp9);
            ListOfEmployee.Add(emp10);

           foreach(Employee e in ListOfEmployee)
            {
          Console.WriteLine("ID={0},Name={1},Gender={2},Salary={3}",
                   e.Id, e.Name, e.Gender, e.Salary);
            }

            Console.WriteLine();

            ListOfEmployee.Sort();

            foreach (Employee e in ListOfEmployee)
            {
                Console.WriteLine("ID={0},Name={1},Gender={2},Salary={3}",
                         e.Id, e.Name, e.Gender, e.Salary);
            }

            Console.WriteLine();

            SortByName SBN = new SortByName();

            ListOfEmployee.Sort(SBN);

            foreach (Employee e in ListOfEmployee)
            {
                Console.WriteLine("ID={0},Name={1},Gender={2},Salary={3}",
                         e.Id, e.Name, e.Gender, e.Salary);
            }

            Console.ReadKey();




        }
    }
}
