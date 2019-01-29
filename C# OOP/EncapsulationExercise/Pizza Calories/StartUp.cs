using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Topping> toppings = new List<Topping>();
            
            string[] pizzaName = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = pizzaName[1];
            
            string[] doughTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string doughType = doughTokens[1];

            string bakingTechnique = doughTokens[2];

            int doughWeight = int.Parse(doughTokens[3]);

            Dough dough = new Dough(doughType, bakingTechnique, doughWeight);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] toppingTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string toppingType = toppingTokens[1];

                int toppingWeight = int.Parse(toppingTokens[2]);

                Topping topping = new Topping(toppingType, toppingWeight);

                toppings.Add(topping);
            }

            Pizza pizza = new Pizza(name);

            Console.WriteLine(pizza.ToString());
        }
    }
}
