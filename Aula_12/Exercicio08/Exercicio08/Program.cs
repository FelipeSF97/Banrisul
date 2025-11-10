using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);  // 1 a 100
            int tentativas = 0;
            int palpite;

            Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
            Console.WriteLine("Adivinhe o número entre 1 e 100");
            
            do
            {
                palpite = Convert.ToInt32(Console.ReadLine());
                if(palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo!");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Muito alto!");
                }
                tentativas++;
            } while (palpite != numeroSecreto);

            Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas!");
        }
    }
}
