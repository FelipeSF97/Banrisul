using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_expressoes_aritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o primeiro número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo numero: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int soma = num1 + num2;
            //int subtracao = num1 - num2;
            //int mult = num1 * num2;
            //double div = Convert.ToDouble(num1)/Convert.ToDouble(num2);
            //int resto = num1 % num2;

            //Console.WriteLine($"Soma: {soma}");
            //Console.WriteLine($"Subtração: {subtracao}");
            //Console.WriteLine($"Multiplicação: {mult}");
            //Console.WriteLine($"Divisão: {div}");
            //Console.WriteLine($"Resto: {resto}");

            Console.WriteLine("Digite um número inteiro de três dígitos: ");
            int num = int.Parse(Console.ReadLine());

            int unidade = num % 10;
            Console.WriteLine($"Unidade: {unidade}");

            int dezena = ((num % 100) - unidade) / 10;
            Console.WriteLine($"Dezena: {dezena}");

            int centena = ((num % 1000) - dezena - unidade) / 100;
            Console.WriteLine($"Centena: {centena}");

            int soma = unidade + dezena + centena;
            Console.WriteLine($"Soma dos dígitos: {soma}");
        }
    }
}
