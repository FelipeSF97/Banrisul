using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_estruturas_controle
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculo = new Calculadora();
            calculo.ExibirMenu();
            calculo.Calcular();

        }
    }
    public class Calculadora
    { 
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public Calculadora()
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }
        public void ExibirMenu()
        {
            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potência");
        }

        public void Calcular()
        {
            Console.WriteLine("Escolha a operação: ");
            decimal operacao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Digite o segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            switch (operacao)
            {
                case 1: Console.WriteLine($"Resultado: {numero1} + {numero2} = {numero1 + numero2}"); break;
                case 2: Console.WriteLine($"Resultado: {numero1} - {numero2} = {numero1 - numero2}"); break;
                case 3: Console.WriteLine($"Resultado: {numero1} x {numero2} = {numero1 * numero2}"); break;
                case 4:
                    if (numero2 == 0) { Console.WriteLine("Não é possível dividir por zero."); }
                    else { Console.WriteLine($"Resultado: {numero1} / {numero2} = {numero1 / numero2}"); }  
                    break;
                //case 5: Console.WriteLine($"Resultado: {numero1}^{numero2} = {numero1  numero2}"); break;
                default: throw new Exception("Opção inválida!");
            }
        }
    }
}
