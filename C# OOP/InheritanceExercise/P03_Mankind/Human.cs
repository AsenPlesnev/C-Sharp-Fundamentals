using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Human
    {
        private const int firstNameMinLenght = 4;

        private const int lastNameMinLenght = 3;

        private string firstName;

        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    Exception ex = new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                if (value.Length < firstNameMinLenght)
                {
                    Exception ex = new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(this.firstName)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    Exception ex = new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                if (value.Length < lastNameMinLenght)
                {
                    Exception ex = new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(this.lastName)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.firstName}")
                .AppendLine($"Last Name: {this.lastName}");

            return sb.ToString();
        }

    }
}
