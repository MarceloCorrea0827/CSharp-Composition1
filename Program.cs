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
            // Nome do Departamento
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();

            // Recebendo Dados iniciais do Funcionário
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Composição entre as classe Worker e Department
            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            // Ler os contratos do Funcionário(Worker)
            Console.WriteLine("How many contracts to this Worker?: ");
            int numContracts = int.Parse(Console.ReadLine());

            for (int i=1; i < numContracts; i++)
            {
                // Dados do Contrato
                Console.WriteLine($"Enter #{i} contract data"); //Interpolação
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durations (hours): ");
                int hours = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(date, valuePerHour, hours); // Instanciando Contract             
                worker.AddContract(contract); // Adicionando este Contrato de trabalho ao Funcionário (Worker)
            }
        }
    }
}
