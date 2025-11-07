using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            string tipo;
            if(dia >= 2 && dia <= 6) { tipo = "Dia útil"; }
            else if(dia == 1 || dia ==7) { tipo = "Fim de semana"; }
            else {  throw new Exception("Número inválido!"); }

            switch (dia)
            {
                case 1: Console.WriteLine($"Dia: Domingo(Sunday)\nTipo: {tipo}"); break;
                case 2: Console.WriteLine($"Dia: Segunda-feira(Monday)\nTipo: {tipo}"); break;
                case 3: Console.WriteLine($"Dia: Terça-feira(Tuesday)\nTipo: {tipo}"); break;
                case 4: Console.WriteLine($"Dia: Quarta-feira(Wednesday)\nTipo: {tipo}"); break;
                case 5: Console.WriteLine($"Dia: Quinta-feira(Thursday)\nTipo: {tipo}"); break;
                case 6: Console.WriteLine($"Dia: Sexta-feira(Friday)\nTipo: {tipo}"); break;
                case 7: Console.WriteLine($"Dia: Sábado(Saturday)\nTipo: {tipo}"); break;
            }
        }
    }
}
