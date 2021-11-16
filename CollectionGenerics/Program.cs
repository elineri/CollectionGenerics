// Elin Ericstam SUT21
using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Employee E1 = new Employee() { ID = 101, Name = "Elin", Gender = "Kvinna", Salary = 25000 };
            Employee E2 = new Employee() { ID = 102, Name = "Anas", Gender = "Man", Salary = 30000 };
            Employee E3 = new Employee() { ID = 103, Name = "Tobias", Gender = "Man", Salary = 28000 };
            Employee E4 = new Employee() { ID = 104, Name = "Malin", Gender = "Kvinna", Salary = 22000 };
            Employee E5 = new Employee() { ID = 105, Name = "Oskar", Gender = "Man", Salary = 24000 };

            Stack<Employee> EmpSta = new Stack<Employee>();
            EmpSta.Push(E1);
            EmpSta.Push(E2);
            EmpSta.Push(E3);
            EmpSta.Push(E4);
            EmpSta.Push(E5);

            foreach (Employee employee in EmpSta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ID:\t{employee.ID}\nName:\t{employee.Name}\nGender:\t{employee.Gender}\nSalary:\t{employee.Salary}\n");
                Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("---------------------------");
            }

            // POP
            Console.WriteLine("POP");

            Employee Emp1 = EmpSta.Pop();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID:\t{Emp1.ID}\nName:\t{Emp1.Name}\nGender:\t{Emp1.Gender}\nSalary:\t{Emp1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            Employee Emp2 = EmpSta.Pop();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID:\t{Emp2.ID}\nName:\t{Emp2.Name}\nGender:\t{Emp2.Gender}\nSalary:\t{Emp2.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            Employee Emp3 = EmpSta.Pop();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID:\t{Emp3.ID}\nName:\t{Emp3.Name}\nGender:\t{Emp3.Gender}\nSalary:\t{Emp3.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            Employee Emp4 = EmpSta.Pop();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID:\t{Emp4.ID}\nName:\t{Emp4.Name}\nGender:\t{Emp4.Gender}\nSalary:\t{Emp4.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            Employee Emp5 = EmpSta.Pop();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID:\t{Emp5.ID}\nName:\t{Emp5.Name}\nGender:\t{Emp5.Gender}\nSalary:\t{Emp5.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            // PUSH
            EmpSta.Push(Emp1);
            EmpSta.Push(Emp2);
            EmpSta.Push(Emp3);
            EmpSta.Push(Emp4);
            EmpSta.Push(Emp5);

            //PEEK
            Console.WriteLine("PEEK");
            Employee Em1 = EmpSta.Peek();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"ID:\t{Em1.ID}\nName:\t{Em1.Name}\nGender:\t{Em1.Gender}\nSalary:\t{Em1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            Employee Em2 = EmpSta.Peek();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"ID:\t{Em1.ID}\nName:\t{Em1.Name}\nGender:\t{Em1.Gender}\nSalary:\t{Em1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------");

            if (EmpSta.Contains(Emp3))
            {
                Console.WriteLine("Emp3 finns i stack");
            }
            else
            {
                Console.WriteLine("Emp3 finns inte i stack");
            }


        }
    }
}
