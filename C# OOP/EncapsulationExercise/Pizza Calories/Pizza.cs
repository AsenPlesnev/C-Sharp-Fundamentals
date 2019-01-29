﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;

            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;

            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    Exception ex = new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                name = value;
            }
        }
        internal Dough Dough { get => dough; set => dough = value; }
        internal List<Topping> Toppings
        {
            get => toppings;

            set
            {
                if (toppings.Count > 10)
                {
                    Exception ex = new ArgumentException("Number of toppings should be in range [0..10].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                toppings = value;
            }
        }

        public void Add(Topping topping)
        {
            this.Toppings.Add(topping);
        }

        public double PizzaCalories { get => this.GetCalories(); }

        private double GetCalories()
        {
            double doughCalories = this.Dough.DoughCalories;

            double toppingCalories = this.Toppings.Sum(c => c.ToppingCalories);

            return doughCalories + toppingCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.PizzaCalories:f2} Calories.";
        }
    }
}
