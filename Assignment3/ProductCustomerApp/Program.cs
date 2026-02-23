using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using static ProductCustomerApp.Northwind;

namespace ProductCustomerApp
{
    class Program
    {
        static void Main()
        {

            // Serialization of categories and products
            Console.WriteLine("\nSerializing categories and products...");

            // JSON Serialization
            var json = JsonSerializer.Serialize(Categories, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("categories_products.json", json);

            // XML Serialization
            var xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (var xmlStream = new FileStream("categories_products.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(xmlStream, Categories);
            }

            // Binary Serialization
            var binarySerializer = new DataContractSerializer(typeof(List<Category>));
            using (var binaryStream = new FileStream("categories_products.dat", FileMode.Create))
            {
                binarySerializer.WriteObject(binaryStream, Categories);
            }

            // Measure file sizes
            Console.WriteLine("\nCalculating file sizes...");
            var fileSizes = new List<(string Format, long Size)>
            {
                ("JSON", new FileInfo("categories_products.json").Length),
                ("XML", new FileInfo("categories_products.xml").Length),
                ("Binary", new FileInfo("categories_products.dat").Length)
            };

            // Display file sizes ranked from smallest to largest
            foreach (var file in fileSizes.OrderBy(f => f.Size))
            {
                Console.WriteLine($"{file.Format}: {file.Size} bytes");
            }

            // Existing customer search functionality...
            // Customer Search Logic (existing functionality)
            
            bool continueSearching = true;

            while (continueSearching)
            {
                Console.Write("\nEnter the name of a city: ");
                string? inputCity = Console.ReadLine();

                var customersInCity = Northwind.Customers
                    .Where(c => c.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase))
                    .Select(c => c.CompanyName)
                    .ToList();

                if (customersInCity.Any())
                {
                    Console.WriteLine($"\nThere are {customersInCity.Count} customers in {inputCity}:");
                    foreach (var customer in customersInCity)
                    {
                        Console.WriteLine(customer);
                    }
                }
                else
                {
                    Console.WriteLine($"\nNo customers found in {inputCity}.");
                }

                Console.Write("\nWould you like to search for another city? (yes/no): ");
                string? response = Console.ReadLine()?.Trim().ToLower();

                if (response != "yes")
                {
                    continueSearching = false;
                    Console.WriteLine("Goodbye!");
                }
            }

            
        }
    }
}
