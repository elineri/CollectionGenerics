// Elin Ericstam SUT21
using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects
            Employee E1 = new Employee() { ID = 101, Name = "Elin", Gender = "Kvinna", Salary = 25000 };
            Employee E2 = new Employee() { ID = 102, Name = "Anas", Gender = "Man", Salary = 30000 };
            Employee E3 = new Employee() { ID = 103, Name = "Tobias", Gender = "Man", Salary = 28000 };
            Employee E4 = new Employee() { ID = 104, Name = "Malin", Gender = "Kvinna", Salary = 22000 };
            Employee E5 = new Employee() { ID = 105, Name = "Oskar", Gender = "Man", Salary = 24000 };

            // Stack
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
                Console.WriteLine("---------------------------");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            // POP
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("POP\n");

            Employee Emp1 = EmpSta.Pop();

            Console.WriteLine($"ID:\t{Emp1.ID}\nName:\t{Emp1.Name}\nGender:\t{Emp1.Gender}\nSalary:\t{Emp1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            Employee Emp2 = EmpSta.Pop();

            Console.WriteLine($"ID:\t{Emp2.ID}\nName:\t{Emp2.Name}\nGender:\t{Emp2.Gender}\nSalary:\t{Emp2.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            Employee Emp3 = EmpSta.Pop();

            Console.WriteLine($"ID:\t{Emp3.ID}\nName:\t{Emp3.Name}\nGender:\t{Emp3.Gender}\nSalary:\t{Emp3.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            Employee Emp4 = EmpSta.Pop();

            Console.WriteLine($"ID:\t{Emp4.ID}\nName:\t{Emp4.Name}\nGender:\t{Emp4.Gender}\nSalary:\t{Emp4.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            Employee Emp5 = EmpSta.Pop();

            Console.WriteLine($"ID:\t{Emp5.ID}\nName:\t{Emp5.Name}\nGender:\t{Emp5.Gender}\nSalary:\t{Emp5.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;


            // PUSH
            EmpSta.Push(Emp1);
            EmpSta.Push(Emp2);
            EmpSta.Push(Emp3);
            EmpSta.Push(Emp4);
            EmpSta.Push(Emp5);

            // PEEK
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PEEK\n");
            Employee Em1 = EmpSta.Peek();

            Console.WriteLine($"ID:\t{Em1.ID}\nName:\t{Em1.Name}\nGender:\t{Em1.Gender}\nSalary:\t{Em1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            Employee Em2 = EmpSta.Peek();

            Console.WriteLine($"ID:\t{Em1.ID}\nName:\t{Em1.Name}\nGender:\t{Em1.Gender}\nSalary:\t{Em1.Salary}\n");
            Console.WriteLine($"Items in the Stack: {EmpSta.Count}");
            Console.WriteLine("---------------------------");

            // CONTAINS
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (EmpSta.Contains(Emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }
            Console.WriteLine("---------------------------\n");


            // LIST
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("LIST");
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(E1);
            listEmp.Add(E2);
            listEmp.Add(E3);
            listEmp.Add(E4);
            listEmp.Add(E5);

            Console.ForegroundColor = ConsoleColor.Magenta;
            if (listEmp.Contains(E2))
            {
                Console.WriteLine("Employee2 object exist in the list\n");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            // FIND
            Employee empMan = listEmp.Find(e => e.Gender == "Man");
            Console.WriteLine("First man in the list:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"ID: {empMan.ID}, Name: {empMan.Name}, Gender: {empMan.Gender}, Salary: {empMan.Salary}\n");

            // FIND ALL
            List<Employee> empMen = listEmp.FindAll(e => e.Gender == "Man");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("All men in the list:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (Employee e in empMen)
            {
                Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Gender: {e.Gender}, Salary: {e.Salary}\n");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
