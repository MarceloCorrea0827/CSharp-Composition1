using System;
using System.Globalization;
using Composition1.Entities;
using Composition1.Entities.Enums;

namespace Composition1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);
        }
    }
}
