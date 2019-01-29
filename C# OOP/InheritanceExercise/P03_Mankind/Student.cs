using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Student : Human
    {
        private const int FacNumMinLength = 5;
        private const int FacNumMaxLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }

            set
            {
                if (value.Length < FacNumMinLength || value.Length > FacNumMaxLength)
                {
                    Exception ex = new ArgumentException("Invalid faculty number!");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.facultyNumber}");

            return sb.ToString();
        }

    }
}
