using System;
using System.Collections.Generic;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee E1 = new Employee() { ID = 101, Name = "Elin", Gender = "Kvinna", Salary = 25000 };
            Employee E2 = new Employee() { ID = 101, Name = "Anas", Gender = "Man", Salary = 30000 };
            Employee E3 = new Employee() { ID = 101, Name = "Tobias", Gender = "Man", Salary = 28000 };
            Employee E4 = new Employee() { ID = 101, Name = "Malin", Gender = "Kvinna", Salary = 22000 };
            Employee E5 = new Employee() { ID = 101, Name = "Oskar", Gender = "Man", Salary = 24000 };

            Stack<Employee> EmpSta = new Stack<Employee>();

            EmpSta.Push(E1);
            EmpSta.Push(E2);
            EmpSta.Push(E3);
            EmpSta.Push(E4);
            EmpSta.Push(E5);
        }
    }
}
