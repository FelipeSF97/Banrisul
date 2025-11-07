using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine($"O número {numero1} é PAR");
            }
            else
            {
                Console.WriteLine($"O número {numero1} é ÍMPAR");
            }
        }
    }
}
