using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"{nome} {sobrenome}");

            string inicialNome = nome.Substring(0, 1);
            string inicialSobrenome = sobrenome.Substring(0, 1);
            int tamanhoNome = nome.Length + sobrenome.Length;
            Console.WriteLine($"Iniciais e Contagem: {inicialNome.ToUpper()}.{inicialSobrenome.ToUpper()}. ({tamanhoNome})");

            string metadeNome = nome.Substring(0, 3);
            string metadeSobrenome = sobrenome.Substring(3);
            Console.WriteLine($"Nome Secreto: {metadeNome}{metadeSobrenome}");
        }
    }
}
