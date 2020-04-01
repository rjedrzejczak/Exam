using System;
using System.Runtime.CompilerServices;

namespace e16
{
    class Program: Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employeeType1 = new Employee();
        }
    }

    class dupa : Employee
    {
        private void test()
        {
            Employee employee = new Employee();
            employee.EmployeeType.Replace("", "");
        }
        
    }
}