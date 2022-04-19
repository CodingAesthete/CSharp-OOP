using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bagOfProducts = new List<Product>();
        }
        public string Name 
        {
            get
            {
                return this.name;
            }
            private set 
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty");
                this.name = value;
            } 
        }
        public decimal Money 
        { 
            get 
            {
                return this.money;
            } 
            private set 
            {
                Validator.ThrowIfMoneyIsNegative(value, "Money cannot be negative");
                this.money = value;
            } 
        }
        public void AddProduct(Product product)
        {
            if (product.Cost>this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            Console.WriteLine($"{this.Name} bought {product.Name}");
            Money -= product.Cost;
            bagOfProducts.Add(product);
        }
        public override string ToString()
        {
            if (bagOfProducts.Count==0)
            {
                return $"{this.Name} - Nothing bought";
            }
            return $"{this.Name} - {String.Join(", ", bagOfProducts.Select(p=>p.Name))}";
        }
    }
}