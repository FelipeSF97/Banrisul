using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_atribuicao_de_variaveis_e_constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacidadeMaxima = 5000;
            int ingressosVendidos = 2000;
            int ingressosRestantes = capacidadeMaxima - ingressosVendidos;

            System.Console.WriteLine($"Ingressos Vendidos: {ingressosVendidos} de {capacidadeMaxima}");
            System.Console.WriteLine($"Ingressos Restantes: {ingressosRestantes}");
        }
    }
}
