﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;

        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => type;

            set
            {
                if (value.ToLower() != "meat" || value.ToLower() != "veggies" || value.ToLower() != "cheese" || value.ToLower() != "sauce")
                {
                    Exception ex = new ArgumentException($"Cannot place {value} on top of your pizza.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                type = value;
            }
        }

        public int Weight
        {
            get => weight;

            set
            {
                if (value < 1 || value > 50)
                {
                    string type = Char.ToUpper(this.Type[0]) + this.Type.Substring(1); 

                    Exception ex = new ArgumentException($"{type} weight should be in the range [1..50].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                weight = value;
            }
        }

        public double ToppingCalories { get => this.CalculateCalories();}

        private double CalculateCalories()
        {
            double modifier = this.Type == "meat" ? 1.2 : this.Type == "veggies" ? 0.8 : this.Type == "cheese" ? 1.1 : 0.9;

            return Weight * 2 * modifier;
        }
    }
}
