using ExercicioFx.Entities;
using ExercicioFx.Services;
using System;
using System.Globalization;

namespace ExercicioFx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pegando os dados do contrato
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            //instanciando objeto
            Contract contractClient = new Contract(contractNumber,contractDate,contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.processContract(contractClient, months);

            //Exibir os Installments
            Console.WriteLine();

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contractClient.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
