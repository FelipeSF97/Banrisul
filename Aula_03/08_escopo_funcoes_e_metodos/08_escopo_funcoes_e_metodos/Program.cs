using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_escopo_funcoes_e_metodos
{
    class Program
    {
        // Preço de cada sabor de sorvete
        const double PRECO_CHOCOLATE = 5, PRECO_MORANGO = 6, PRECO_FLOCOS = 4;

        // Cálculo do total do pedido
        static double calcularTotalPedido(double qtdChocolate, double qtdMorango, double qtdFlocos)
        {
            double totalChocolate = qtdChocolate * PRECO_CHOCOLATE;
            double totalMorango = qtdMorango * PRECO_MORANGO;
            double totalFlocos = qtdFlocos * PRECO_FLOCOS;

            double valorTotalPedido = totalChocolate + totalMorango + totalFlocos;

            return valorTotalPedido;
        }

        static void aplicarDesconto(int quantidadeChocolate, int quantidadeMorango, int quantidadeFlocos, double valorTotalPedido)
        {
            // Aplicação de desconto
            int qtdTotalSorvetes = quantidadeChocolate + quantidadeMorango + quantidadeFlocos;

            if (qtdTotalSorvetes > 5) // Mais do que 5 sorvetes tem desconto de 10%
            {
                valorTotalPedido -= valorTotalPedido / 10;
            }

            if (valorTotalPedido > 20) // Pedido acima de R$ 20,00 ganha cobertura gratuita
            {
                Console.WriteLine($"Total do pedido: R$ {valorTotalPedido:0.00} e com cobertura gratuita!");
            }
            else
            {
                Console.WriteLine($"Total do pedido: R$ {valorTotalPedido:0.00}.");
            }
        }

        static void Main(string[] args)
        {
            // Quantidade de sorvetes pedidos pelo cliente
            Console.Write("Quantos sorvetes de chocolate? ");
            int quantidadeChocolate = int.Parse(Console.ReadLine());

            Console.Write("Quantos sorvetes de morango? ");
            int quantidadeMorango = int.Parse(Console.ReadLine());

            Console.Write("Quantos sorvetes de flocos? ");
            int quantidadeFlocos = int.Parse(Console.ReadLine());

            double valorTotalPedido = calcularTotalPedido(quantidadeChocolate, quantidadeMorango, quantidadeFlocos);

            aplicarDesconto(quantidadeChocolate, quantidadeMorango, quantidadeFlocos, valorTotalPedido);
        }
    }
}
