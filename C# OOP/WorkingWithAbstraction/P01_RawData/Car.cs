﻿using System.Collections.Generic;

namespace P01_RawData
{
    public class Car
    {
        private string model;

        private Engine engine;

        private Cargo cargo;

        private List<Tire> tires;

        public Car(string model,Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public string Model { get; set; }

        public List<Tire> Tires { get; set; }
    }
}
