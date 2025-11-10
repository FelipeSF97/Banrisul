using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int numero = 2; numero <= 100; numero++) 
            {
                bool primo = true;
                int divisor = 0;

                for (int i = 2; i < Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        divisor = i;
                        break;
                    }
                }
                if (primo)
                {
                    Console.WriteLine($"{numero} é PRIMO");
                }
                else
                {
                    Console.WriteLine($"{numero} NÃO é primo (divisível por {divisor})");
                }

            }
            

            
            
            // TODO: Implemente a lógica de verificação
            // Dica: número primo só é divisível por 1 e ele mesmo
            // Teste divisões de 2 até √numero
        }
    }
}
