using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Produto_Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto viagra = new Produto("Viagra", 10, 1, "Medicamento", 69);

            viagra.ExibirDetalhes();
            viagra.AdicionarEstoque(2);
            viagra.RemoverEstoque(1);
            viagra.AplicarDesconto(0.5m);
            viagra.ExibirDetalhes();

            Produto tadalafila = new Produto("Tadalafila", 20, 3, "Medicamento", 101);

            tadalafila.ExibirDetalhes();
            tadalafila.AdicionarEstoque(2);
            tadalafila.RemoverEstoque(1);
            tadalafila.AplicarDesconto(0.3m);
            tadalafila.ExibirDetalhes();
        }
    }
    public class Produto
    {
        public string Nome {get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; private set; }
        public string Categoria { get; set; }
        private static int contador = 0;
        public int CodigoProduto { get;}
        public decimal ValorTotalEstoque { get; set; }

        public Produto(string Nome, decimal Preco, int QuantidadeEstoque, string Categoria, int CodigoProduto)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.QuantidadeEstoque = QuantidadeEstoque;
            this.Categoria = Categoria;
            contador ++;
            this.CodigoProduto = contador;
            this.ValorTotalEstoque = Preco * QuantidadeEstoque;
        }

        public void AdicionarEstoque(int Quantidade)
        {
            QuantidadeEstoque += Quantidade;

            ValorTotalEstoque = Preco * Quantidade;

        }

        public bool RemoverEstoque(int Quantidade)
        {
            if(QuantidadeEstoque > 0 && QuantidadeEstoque > Quantidade)
            {
                QuantidadeEstoque -= Quantidade;
                return true;
            }
            else
            {
                Console.WriteLine("Estoque zerado!");
                return false;
            }
        }

        public void AplicarDesconto(decimal percentual)
        {
            if(percentual > 1.0m)
            {
                Console.WriteLine("Valor inválido!");
            }
            else
            {
                Console.WriteLine($"Aplicando desconto de %{percentual * 100}");
                Preco *= (1 - percentual);
                ValorTotalEstoque = Preco * QuantidadeEstoque;
            }

        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nProduto: {Nome}");
            Console.WriteLine($"Preco: R${Preco}");
            Console.WriteLine($"Quantidade: {QuantidadeEstoque}");
            Console.WriteLine($"Categoria: {Categoria}");
            Console.WriteLine($"Código do produto: {CodigoProduto}");
            Console.WriteLine($"Valor total do estoque: R${ValorTotalEstoque}\n");
        }
    }
}
