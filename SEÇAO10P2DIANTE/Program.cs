using System;
using System.Globalization;
using System.Collections.Generic;
using SEÇAO10P2DIANTE.Entities;
using System.Diagnostics.CodeAnalysis;

namespace SEÇAO10P2DIANTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number De Tax Payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> tx = new List<TaxPayer>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer {i} Data: ");
                Console.Write("Individual Or Company (i/c): ");
                char ci = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double rendaanual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ci == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    tx.Add(new Individual(name, rendaanual, health));
                }
                else if (ci == 'c')
                {
                    Console.Write("Number Of Employees: ");
                    int numemply = int.Parse(Console.ReadLine());
                    tx.Add(new Company(name, rendaanual, numemply));
                }
            }
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;


            foreach (TaxPayer tax in tx)
            {
                Console.WriteLine("Name: " + tax.Name + "  |  $: " + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += tax.Tax();
            }

            Console.WriteLine("TOTAL TAXES: $: " + sum.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
