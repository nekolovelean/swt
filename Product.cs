using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(int id, string name, string category, int price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Category + " " + Quantity + " " + Price;
        }
    }
}
