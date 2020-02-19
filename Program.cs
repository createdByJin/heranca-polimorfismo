using System;
using System.Globalization;
using PrimeiroProjeto.Entities;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'c')
                {
                    list.Add(new Product(nameProduct, priceProduct));
                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nameProduct, priceProduct, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nameProduct, priceProduct, customsFee));
                }
            }


            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
