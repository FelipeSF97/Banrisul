using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if(idade < 0)
            {
                Console.WriteLine("Idade inválida!");
            }else if(idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Classificação: Criança");
            }else if(idade >= 13 && idade <= 17)
            {
                Console.WriteLine("Classificação: Adolescente");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("Classificação: Adulto");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("Classificação: Idoso");
            }
        }
    }
}
