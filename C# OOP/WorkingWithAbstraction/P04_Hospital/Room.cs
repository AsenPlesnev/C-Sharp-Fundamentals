﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        public Room()
        {
            this.Patients = new List<string>();
        }

        public List<string> Patients { get; set; }
    }
}
