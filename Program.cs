using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayers.Entities;

namespace TaxPayers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> list = new List<Payers>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expenditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Payers payer in list)
            {
                Console.WriteLine(payer);
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach (Payers payer in list)
            {
                sum += payer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
