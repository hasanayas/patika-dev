using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a student 
            Student student = new Student("John", "Doe", -90, 4); // Setting a negative student ID to test validation
            student.GetStudentInfo();
            student.PromoteGrade();
            student.GetStudentInfo();
            

            // Creating another student 
            Student student1 = new Student("", "Doe", 91, 1); // Setting an empty first name to test validation
            student1.GetStudentInfo();
            student1.ReduceGrade();
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;
        private int studentID;
        private int grade;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("First name cannot be empty!"); // Validation: First name cannot be empty
                    firstName = "Unknown";
                }
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Last name cannot be empty!"); // Validation: Last name cannot be empty
                    lastName = "Unknown";
                }
                else
                    lastName = value;
            }
        }
        public int StudentID
        {
            get => studentID;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Student ID cannot be negative!"); // Validation: Student ID cannot be negative
                    studentID = 0;
                }
                else
                    studentID = value;
            }
        }
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Grade cannot be less than 1!"); // Validation: Grade cannot be less than 1
                    grade = 1;
                }
                else
                    grade = value;
            }
        }

        public Student(string firstName, string lastName, int studentID, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            Grade = grade;
        }

        public Student() { }

        public void GetStudentInfo()
        {
            Console.WriteLine("*** Student Information: ***");
            Console.WriteLine("First Name  : " + this.FirstName);
            Console.WriteLine("Last Name   : " + this.LastName);
            Console.WriteLine("Student ID  : " + this.StudentID);
            Console.WriteLine("Student Grade: " + this.Grade);
            Console.WriteLine("-------------------\n ");

        }

        public void PromoteGrade()
        {
            this.Grade = this.Grade + 1;
        }

        public void ReduceGrade()
        {
            this.Grade = this.Grade - 1;
        }
    }
}
