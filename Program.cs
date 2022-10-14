using System;
using System.Collections;
using System.Transactions;
using Curso5.Entities;

namespace Curso5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("common,used or imported?(c/u/i) ");
                char op = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine($"Product #{i} data: " );
                switch (op)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Product product = new Product(name, price);
                        products.Add(product);
                        break;
                     case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Manufacture Date: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        UsedProduct usedProduct = new UsedProduct(name, price, date);
                        products.Add(usedProduct);
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Custom Fee: ");
                        double customFee = double.Parse(Console.ReadLine());
                        ImportedProduct importedProduct = new ImportedProduct(name, price, customFee);
                        products.Add(importedProduct);
                        break;
                    default:
                        Console.WriteLine("invalid option, try again");
                        break;
                }
            }
            foreach (Product product1 in products)
            {
                Console.WriteLine(product1.PriceTag());
            }
        }
    }
}
