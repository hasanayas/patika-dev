using System;

namespace static_class_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of Employees: {Employee.EmployeeCount}");

            Employee employee1 = new Employee("Will", "Smith", "IT");
            Console.WriteLine($"Number of Employees: {Employee.EmployeeCount}");

            Employee employee2 = new Employee("Emily", "Smith", "HR");
            Console.WriteLine($"Number of Employees: {Employee.EmployeeCount}");

            Console.WriteLine("Addition result: " + Operations.Addition(100, 200));
            Console.WriteLine("Subtraction result: " + Operations.Subtraction(400, 50));
        }
    }

    class Employee
    {
        private static int employeeCount;

        public static int EmployeeCount { get => employeeCount; }

        private string FirstName;
        private string LastName;
        private string Department;

        static Employee()
        {

            employeeCount = 0;
        }

        public Employee(string firstName, string lastName, string department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            employeeCount++;
        }
    }

    static class Operations
    {
        // Method for addition
        public static long Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        // Method for subtraction 
        public static long Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
