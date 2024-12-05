using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop
{
    internal class ProductManager
    {
        readonly List<Product> products = new List<Product>();

        public int InputInt(string msg)
        {
            while (true)
            {
                int n = 0;
                try
                {
                    Console.Write(msg);
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("enter number!");
                }
                return n;
            }

        }

        public void AddProduct()
        {
            int id;
            while (true)
            {
                id = InputInt("enter id number:");
                bool idExists = false;
                foreach (var item in products)
                {
                    if (id.Equals(item.Id))
                    {
                        Console.WriteLine("number id has existed");
                        idExists = true; 
                        break; 
                    }
                }
                if (!idExists)
                {
                    break;
                }
            }
            Console.Write("enter name:");
            string name = Console.ReadLine();
            Console.Write("enter category:");
            string cate = Console.ReadLine();
            int price = InputInt("enter price:");
            int quanlity = InputInt("enter quanlity:");

            products.Add(new Product(id, name, cate, price, quanlity));
            Console.WriteLine("add done");

        }

        public void Display()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Category: {item.Category}, Price: {item.Price}, Quantity: {item.Quantity}");
            }

        }

        public void FindProductByID()
        {
            int id = InputInt("enter number find:");
            bool check = false;
            foreach (var item in products)
            {
                if (id.Equals(item.Id))
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Category: {item.Category}, Price: {item.Price}, Quantity: {item.Quantity}");
                    check = true;
                    break;
                }

            }
            if (!check) Console.WriteLine("product find not found");
            else Console.WriteLine("find done");

        }

        public void FindProductByName()
        {
            string name = Console.ReadLine();
            bool check = false;
            foreach (var item in products)
            {
                if (name.Equals(item.Name))
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Category: {item.Category}, Price: {item.Price}, Quantity: {item.Quantity}");
                    check = true;
                    break;
                }

            }
            if (!check) Console.WriteLine("product find not found");
            else Console.WriteLine("find done");
        }

        public void DeleteProduct()
        {
            int id = InputInt("enter number find:");
            bool check = false;
            foreach (var item in products)
            {
                if (id.Equals(item.Id))
                {
                    products.Remove(item);
                    check = true;
                    break;
                }

            }
            if (!check) Console.WriteLine("product find not found");
            else Console.WriteLine("delete done!");
        }

        public void UpdateProduct()
        {
            int id = InputInt("enter number find:");
            bool check = false;
            foreach (var item in products)
            {
                if (id.Equals(item.Id))
                {
                    Console.Write("enter name:");
                    string name = Console.ReadLine();
                    Console.Write("enter category:");
                    string cate = Console.ReadLine();
                    int price = InputInt("enter price:");
                    int quanlity = InputInt("enter quanlity:");
                    item.Name = name;
                    item.Price = price;
                    item.Category = cate;
                    item.Quantity = quanlity;
                    check = true;
                    break;
                }

            }
            if (!check) Console.WriteLine("product find not found");
            else Console.WriteLine("update done!");
        }

        public void FilterProductByCategory()
        {
            string cate = Console.ReadLine();
            Console.WriteLine("id     name     category    quanlity     price");
            bool check = false;
            foreach (var item in products)
            {
                if (cate.Equals(item.Category))
                {
                    Console.WriteLine(item.ToString());
                    check = true;
                }

            }
            if (!check) Console.WriteLine("product find not found");
            else Console.WriteLine("filter done");
        }

        public void SortProductByPrice()
        {
            Console.Write("Enter sort order (asc/desc): ");
            string order = Console.ReadLine();
            var sorted = order.Equals("desc", StringComparison.OrdinalIgnoreCase) ?
                products.OrderByDescending(p => p.Price) :
                products.OrderBy(p => p.Price);
            Console.WriteLine("sort done");
        }

        public void CalculateTotalValue()
        {
            int total = 0;
            foreach (var item in products)
            {
                total += (item.Quantity * item.Price);
            }
            Console.WriteLine($"total value = {total}");
        }

        public void SaveToFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Id},{product.Name},{product.Category},{product.Price},{product.Quantity}");
                }
            }
            Console.WriteLine("Data saved to file successfully!");
        }

    }


}
