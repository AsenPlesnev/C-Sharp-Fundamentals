using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Worker : Human
    {
        private const decimal MinWeekSalary = 10;
        private const int MinWorkingHoursPerDay = 1;
        private const int MaxWorkingHoursPerDay = 12;

        private decimal weekSalary;

        private double workingHours;

        public Worker(string firstName, string lastName, decimal weekSalary, double workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;

            this.WorkingHours = workingHours;
        }

        private decimal WeekSalary
        {
            set
            {
                if (value < MinWeekSalary)
                {
                    Exception ex = new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                weekSalary = value;
            }
        }

        private double WorkingHours
        {
            set
            {
                if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
                {
                    Exception ex = new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workingHours)}");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                workingHours = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            var salaryPerDay = this.weekSalary / 5;
            return salaryPerDay / (decimal)this.workingHours;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.weekSalary:F2}")
                .AppendLine($"Hours per day: {this.workingHours:F2}")
                .AppendLine($"Salary per hour: {this.GetSalaryPerHour():F2}");

            return sb.ToString();
        }
    }
}
