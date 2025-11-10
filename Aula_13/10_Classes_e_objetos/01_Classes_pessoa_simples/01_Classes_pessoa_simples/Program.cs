using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes_pessoa_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa felipe = new Pessoa("Felipe Flores", 28, "fsflores97@gmail.com");
            Pessoa eduarda = new Pessoa("Eduarda Vitória", 17, "dudavitoria@gmail.com");
            Pessoa rosane = new Pessoa("Rosane Soutinho", 57, "rosane-soutinho@hotmail.com");

            felipe.ApresentarSe();
            felipe.EhMaiorDeIdade();

            eduarda.ApresentarSe();
            eduarda.EhMaiorDeIdade();

            rosane.ApresentarSe();
            rosane.EhMaiorDeIdade();
        }
    }
    public class Pessoa
    {
        public string Nome {get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Pessoa(string Nome,int Idade, string Email)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Email = Email;
        }
        public void ApresentarSe()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}, tenho {Idade} anos e meu email é {Email}");
        }
        public bool EhMaiorDeIdade()
        {
            if (Idade >= 18)
            {
                Console.WriteLine("Sou maior de idade");
                return true;
            }
            else
            {
                Console.WriteLine("Sou menor de idade");
                return false;
            }
        }
    }
}
