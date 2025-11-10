using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            while (true)
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                if(nome.Length < 3)
                {
                    Console.WriteLine("Nome deve ter pelo menos 3 caracteres!");
                }
                else
                {
                    Console.WriteLine("Nome Válido!");
                    break;
                }
            }
            int idade;
            while (true)
            {
                Console.Write("\nDigite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine()); 

                if (idade >= 0 && idade <= 120)
                {
                    Console.WriteLine("Idade Válida!");
                    break;
                }
                else
                {
                    Console.WriteLine("Idade deve estar entre 0 e 120!");
                    
                }
            }
            string email;
            while (true)
            {
                Console.Write("\nDigite seu email: ");
                email = Console.ReadLine();

                if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.WriteLine("Email inválido!");
                }
                else
                {
                    Console.WriteLine("email Válido!");
                    break;
                }
            }
            Console.WriteLine("\nDados válidos:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
