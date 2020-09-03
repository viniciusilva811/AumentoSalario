
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] vect = new Funcionario[10];

            Console.Write("Quantos funcionarios serao registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionario #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionario que terá aumento no salário: ");
            int buscarId = int.Parse(Console.ReadLine());


            Funcionario busc = list.Find(x => x.ID == buscarId);
            if (busc != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                busc.aumentoSalario(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
