using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos vão ser alugados? ");
            int n = int.Parse(Console.ReadLine());

            Quartos[] vet = new Quartos[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Reserva #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Quartos(nome, email, quarto);
            }

            Console.WriteLine("Quartos alugados");
            for (int i = 0;i < 10; i++)
            {
                if (vet[i] != null )
                {
                    Console.WriteLine(vet[i].Quarto + ": " + vet[i].Nome + ", " + vet[i].Email);
                }
            }
            Console.ReadLine();
        }
    }
}
