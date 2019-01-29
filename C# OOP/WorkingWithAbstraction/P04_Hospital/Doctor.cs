using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {
        public Doctor(string firstName, string lastName)
        {
            this.FirstName = firstName;

            this.LastName = LastName;

            this.Patients = new List<string>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> Patients { get; set; }
    }
}
