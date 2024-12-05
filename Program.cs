using System;

namespace demo_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();
            while (true)
            {
                Menu();
                int choose = manager.InputInt("enter your choose:");
                switch (choose)
                {
                    case 1: manager.AddProduct(); break;
                    case 2: manager.Display(); break;
                    case 3: manager.FindProductByID(); break;
                    case 4: manager.FindProductByName(); break;
                    case 5: manager.DeleteProduct(); break;
                    case 6: manager.UpdateProduct(); break;
                    case 7: manager.FilterProductByCategory(); break;
                    case 8: manager.SortProductByPrice(); break;
                    case 9: manager.CalculateTotalValue(); break;
                    case 10: manager.SaveToFile(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice, please try again."); break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("\nProduct Management Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("4. Search by Name");
            Console.WriteLine("5. Delete Product");
            Console.WriteLine("6. Update Product");
            Console.WriteLine("7. Filter by Category");
            Console.WriteLine("8. Sort by Price");
            Console.WriteLine("9. Calculate Total Value");
            Console.WriteLine("10. Save to File");
            Console.WriteLine("0. Exit");
        }
    }
}
