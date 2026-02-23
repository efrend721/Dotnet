using System;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;

namespace Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // Question 1: Retrieve and Serialize Categories and Products
                Console.WriteLine("Retrieving categories and products...");
                var data = db.Categories
                             .Include(c => c.Products)
                             .Select(c => new
                             {
                                 c.CategoryName,
                                 Products = c.Products.Select(p => new { p.ProductName, p.UnitPrice })
                             }).ToList();

                Console.WriteLine("Serializing data...");

                // JSON Serialization
                var json = JsonSerializer.Serialize(data);
                File.WriteAllText("categories_products.json", json);

                // XML Serialization
                var xmlSerializer = new XmlSerializer(data.GetType());
                using (var xmlStream = new FileStream("categories_products.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(xmlStream, data);
                }

                // Binary Serialization
                using (var binaryStream = new FileStream("categories_products.dat", FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
#pragma warning disable SYSLIB0011 // Suppress obsolete warning for BinaryFormatter
                    binaryFormatter.Serialize(binaryStream, data);
#pragma warning restore SYSLIB0011
                }

                // Measure sizes
                Console.WriteLine("Calculating file sizes...");
                var sizes = new[]
                {
                    new { Format = "JSON", Size = new FileInfo("categories_products.json").Length },
                    new { Format = "XML", Size = new FileInfo("categories_products.xml").Length },
                    new { Format = "Binary", Size = new FileInfo("categories_products.dat").Length }
                };

                foreach (var size in sizes.OrderBy(s => s.Size))
                {
                    Console.WriteLine($"{size.Format}: {size.Size} bytes");
                }

                // Question 2: Query Customers by City
                Console.WriteLine("\nRetrieving unique customer cities...");
                var cities = db.Customers
                               .Select(c => c.City)
                               .Distinct()
                               .OrderBy(city => city)
                               .ToList();

                Console.WriteLine("Available cities:");
                Console.WriteLine(string.Join(", ", cities));

                Console.Write("\nEnter the name of a city: ");
                string inputCity = Console.ReadLine();

                var customers = db.Customers
                                  .Where(c => c.City == inputCity)
                                  .Select(c => c.CompanyName)
                                  .ToList();

                if (customers.Any())
                {
                    Console.WriteLine($"\nThere are {customers.Count} customers in {inputCity}:");
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer);
                    }
                }
                else
                {
                    Console.WriteLine($"\nNo customers found in {inputCity}.");
                }
            }
        }
    }
}

