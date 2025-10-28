using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ContaBancariaSimples{
        private string numeroConta {get; set; }
        private string CPFtitular { get; set; }
        private string nomeTitular { get; set; }
        private double saldoConta { get; set; }

        public ContaBancariaSimples(string nmrConta, string cpf, string nome, double saldo)
        {
            this.numeroConta = nmrConta;
            this.CPFtitular = cpf;
            this.nomeTitular = nome;
            this.saldoConta = saldo;
        }
        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if(valor < 0)
            {
                Console.WriteLine("Valor inválido!");
            }
            else {
                saldoConta += valor;
                Console.WriteLine($"Você adicionou R${valor}\nSeu novo saldo é: {saldoConta}");
            }
        }
        public void sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado");
            double valor = Convert.ToDouble(Console.ReadLine());

            if(valor < saldoConta)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                saldoConta -= saldoConta;
                Console.WriteLine($"Você sacou R${valor}\nSeu novo saldo é: {saldoConta}");
            }
        }
        public bool sucesso()
        {
            return false;
        }
    }
}
