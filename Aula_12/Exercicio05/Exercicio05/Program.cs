using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (1-10): ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            if (numero >= 1 && numero <= 10)
            {
                for(int i = 1; i <= 10; i++) { Console.WriteLine($"{numero} x {i} = {numero * i}"); }
            }
            Console.WriteLine($"\nTabuada do {numero} (divisão):");
            Convert.ToDecimal(numero);
            
            for (int i = 1; i <= 10; i++)
            {
                decimal divisao = numero / Convert.ToDecimal(i);
                Console.WriteLine($"{numero} / {i} = {divisao:F2}");
            }
        }
    }
}
