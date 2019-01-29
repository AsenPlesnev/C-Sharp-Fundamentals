using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Cargo
    {
        public Cargo(string type, int weight)
        {
            this.Type = type;

            this.Weight = weight;
        }

        public string Type { get; set; }

        public int Weight { get; set; }
    }
}
