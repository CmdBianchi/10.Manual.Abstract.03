using System;
using System.Collections.Generic;
using System.Globalization;
using Entitites;
namespace _10.Manual.Abstract._03 {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company ( i / c )? ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (type == 'i' || type == 'I') {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else {
                    Console.WriteLine("number of employees: ");
                    int numberOfEMployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEMployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer tp in list) {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2"));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}
