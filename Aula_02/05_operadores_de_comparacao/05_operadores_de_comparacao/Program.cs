using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_operadores_de_comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            bool maior = num1 > num2;
            bool menor = num1 < num2;
            bool igual = num1 == num2;
            bool diferente = num1 != num2;
            bool maiorIgual = num1 >= num2;
            bool menorIgual = num1 <= num2;

            
            Console.WriteLine($"{num1} > {num2} = {maior}\n{num1} < {num2} = {menor}\n{num1} == {num2} = {igual}\n" +
                $"{num1} != {num2} = {diferente}\n{num1} >= {num2} = {maiorIgual}\n{num1} <= {num2} = {menorIgual}");*/

            /*Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            string senhaArmazenada = "TRE1N4MENT0_MM";

            bool confere = senha == senhaArmazenada;

            Console.WriteLine($"Senha válida? {confere}")*/

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            bool maior = num1 > num2;
            bool menor = num1 < num2;
            bool igual = num1 == num2;
            bool diferente = num1 != num2;
            bool maiorIgual = num1 >= num2;
            bool menorIgual = num1 <= num2;

            Console.WriteLine($"{num1} > {num2} = {Convert.ToInt32(maior)}\n{num1} < {num2} = {menor}\n{num1} == {num2} = {igual}\n" +
                $"{num1} != {num2} = {diferente}\n{num1} >= {num2} = {maiorIgual}\n{num1} <= {num2} = {Convert.ToInt32(menorIgual)}");
        }
    }
}
