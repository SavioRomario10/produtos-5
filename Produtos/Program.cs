﻿using System;
using Produtos.Entitites;
using System.Collections.Generic;

namespace Produtos
{
    class Program
    {
        public void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

                Console.WriteLine();
                Console.WriteLine("Price Tags: ");
                foreach (Product prod in list)
                {
                    Console.WriteLine(prod.PriceTag());
                }
            }
        }
    }
}