using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parduotuve
{
    public class Product : IEquatable<Product>
    {
        private static Random Rand = new Random();
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; set; }
        public double Weight { get; }

        public Product(string name)
        {
            this.Name = name;
            this.Price = Rand.Next(100) + Math.Round(Rand.NextDouble(), 2);
            this.Quantity = Rand.Next(1, 20);
            this.Weight = Rand.Next(2) + Math.Round(Rand.NextDouble(), 2);
        }

        public Product(Product prod)
        {
            //Overloaded constructor, to create product copy for the basket
            this.Name = prod.Name;
            this.Price = prod.Price;
            this.Quantity = 1;
            this.Weight = prod.Weight;
        }

        public static List<Product> GetProducts(string[] ProdNames)
        {
            //Creates a list of available products upon opening the shop program
            //And loads these products into the available products' area in ShopForm
            List<Product> Products = new List<Product>();

            foreach (string prodName in ProdNames)
            {
                Products.Add(new Product(prodName));
            }
            return Products;
        }

        public bool Equals(Product other)
        {
            //Equlity checking method
            return this.Name == other.Name;
        }
    }
}
