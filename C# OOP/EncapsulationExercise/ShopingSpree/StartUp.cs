using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] inputPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] inputProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] tokens = inputPeople[i].Split("=");
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);
                
                Person person = new Person(name, money);
                people.Add(person);
            }

            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] tokens = inputProducts[i].Split("=");
                string name = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string person = tokens[0];
                string productName = tokens[1];

                Product product = products.First(p => p.Name == productName);

                people.First(p => p.Name == person).Add(product);

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
