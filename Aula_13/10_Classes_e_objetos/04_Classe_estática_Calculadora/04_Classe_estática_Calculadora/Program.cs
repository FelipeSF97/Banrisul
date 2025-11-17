using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classe_estática_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            var soma = Calculadora.Somar(2, 2);
            Console.WriteLine(soma);
            var sub = Calculadora.Subtrair(2, 2);
            Console.WriteLine(sub);
            var mult = Calculadora.Multiplicar(2, 2);
            Console.WriteLine(mult);
            var div = Calculadora.Dividir(2, 2);
            Console.WriteLine(div);
            var pot = Calculadora.Potencia(2, 2);
            Console.WriteLine(pot);
            var raiz = Calculadora.RaizQuadrada(4);
            Console.WriteLine(raiz);
            var porc = Calculadora.Porcentagem(100, 10);
            Console.WriteLine(porc);
        }
    }
    public static class Calculadora
    {
        public static string Somar(double a, double b)
        {
            double total = a + b;
            return $"{a} + {b} = {total}";
        }
        public static string Subtrair(double a, double b)
        {
            double total = a - b;
            return $"{a} - {b} = {total}";
        }
        public static string Multiplicar(double a, double b)
        {
            double total = a * b;
            return $"{a} x {b} = {total}";
        }
        public static string Dividir(double a, double b)
        {
            if(b > 0)
            {
                double total = a / b;
                return $"{a} / {b} = {total}";
            }
            else
            {
                return "Número inválido!";
            }
        }
        public static string Potencia(double b, double expoente)
        {
            double total = Math.Pow(b, expoente);
            return $"{b} elevado a {expoente} é igual a: {total}";
        }
        public static string RaizQuadrada(double numero)
        {
            if(numero >= 0)
            {
                double total = Math.Sqrt(numero);
                return $"A raiz quadrada de {numero} é: {total}";
            }
            else
            {
                return "Número inválido!";
            }
            
        }
        public static string Porcentagem(double valor, double percentual)
        {
            percentual = percentual /100;
            double total = valor * percentual;
            return $"%{percentual*100} de {valor} é: {total}";
        }
    }
}
