using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_expressoes_logicas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite a altura da criança (em centímetros): ");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("A criança está acompanhada por um adulto? (sim/não)");
            string acompanhada = Console.ReadLine();
            int alturaMinima = 120;

            if(altura >= alturaMinima || acompanhada == "sim")
            {
                Console.WriteLine("Pode entrar");
            }
            else {
                Console.WriteLine("Não pode entrar");
            }*/

            //--------------------------------------------------------------------------

            /*Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0 && num % 2 == 0)
            {
                Console.WriteLine("O número é positivo e par");
            }
            else
            {
                Console.WriteLine("O número não é positivo ou não é par");
            }*/

            //----------------------------------------------------------------

            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("O ano é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto!");
            }
        }
    }
}
