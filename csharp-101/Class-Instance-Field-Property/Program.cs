using System;

public class Program
{
    static void Main(string[] args)
    {

        //Access Modifiers
        // * Public
        // * Private
        // * Internal
        // * Protected

        Employee employeeOne = new Employee();
        employeeOne.FirstName = "John";
        employeeOne.Surname = "Wick";
        employeeOne.EmployeeID = 1001;
        employeeOne.Department = "Gun Engineering";
        employeeOne.Salary = 50000;

        employeeOne.GetEmployeeInfo();

        Console.WriteLine("************");

        Employee employeeTwo = new Employee();
        employeeTwo.FirstName = "Jane";
        employeeTwo.Surname = "Smith";
        employeeTwo.EmployeeID = 1002;
        employeeTwo.Department = "Marketing";
        employeeTwo.Salary = 45000;

        employeeTwo.GetEmployeeInfo();
       
    }

    class Employee
    {
        public string FirstName;
        public string Surname;
        public int EmployeeID;
        public string Department;
        public double Salary;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("First Name of the employee: {0}", FirstName);
            Console.WriteLine("Last Name of the employee: {0}", Surname);
            Console.WriteLine("ID of the employee: {0}", EmployeeID);
            Console.WriteLine("Department of the employee: {0}", Department);
            Console.WriteLine("Salary of the employee: {0}", Salary);
        }
    }
}
