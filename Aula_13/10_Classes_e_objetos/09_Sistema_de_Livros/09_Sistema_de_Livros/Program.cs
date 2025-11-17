using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sistema_de_Livros
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro revolucao = new Livro("Revolução dos Bichos", "George Orwell", "111111", 1945, 112);
            Livro oitentaEQuatro = new Livro("1984", "George Orwell", "222222", 1949, 440);
            Livro dracula = new Livro("Drácula", "Bram Stocker", "333333", 1897, 515);
            Livro guia = new Livro("O Guia do Mochileiro das Galáxias", "Douglas Adams", "444444", 1979, 242);
            Livro don = new Livro("Don Quixote", "Miguel de Cervantes", "555555", 1605, 1200);
            Biblioteca.AdicionarLivro(revolucao);
            Biblioteca.AdicionarLivro(oitentaEQuatro);
            Biblioteca.AdicionarLivro(dracula);
            Biblioteca.AdicionarLivro(guia);
            Biblioteca.AdicionarLivro(don);
            Biblioteca.ListarDisponiveis();
            Biblioteca.BuscarPorTitulo(null);
            Biblioteca.BuscarPorAutor(null);
            revolucao.Emprestar();
            Biblioteca.ListarDisponiveis();
            Biblioteca.ListarTodos();
            Console.WriteLine($"Quantidade de livros: {Biblioteca.QuantidadeLivros()}");

        }
    }
    public class Livro
    {
        public string Titulo {get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public bool Disponivel { get; private set; }

        public Livro(string Titulo, string Autor, string ISBN, int AnoPublicacao, int NumeroPaginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = ISBN;
            this.AnoPublicacao = AnoPublicacao;
            this.NumeroPaginas = NumeroPaginas;
            this.Disponivel = true;
        }
        public void Emprestar() { Disponivel = false; }
        public void Devolver() { Disponivel = true; }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nTítulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Ano publicação: {AnoPublicacao}");
            Console.WriteLine($"Número de páginas: {NumeroPaginas}");
            Console.WriteLine($"Está disponível? {Disponivel}\n");
        }
    }
    public static class Biblioteca
    {
        private static List<Livro> Livros = new List<Livro>();

        public static void AdicionarLivro(Livro livro)
        {
            if(livro != null)
            {
                Livros.Add(livro);

                Console.WriteLine($"O livro {livro.Titulo} do autor {livro.Autor} foi adicionado com sucesso");
            }
        }
        public static void RemoverLivro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn)) 
            {
                Console.WriteLine("Digite o ISBN do livro que deve ser removido:");
                isbn = Console.ReadLine();
            }

            Livro RemoverLivro = null;

            foreach(Livro livro in Livros)
            {
                if(livro.ISBN == isbn)
                {
                    RemoverLivro = livro;
                    break;
                }
            }
            if (RemoverLivro != null)
            {
                Livros.Remove(RemoverLivro);
                Console.WriteLine($"Livro '{RemoverLivro.Titulo}' removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }

        }

        public static void BuscarPorTitulo(string Titulo)
        {
            Console.WriteLine("Digite o título do livro que você deseja buscar");
            Titulo = Console.ReadLine();

            bool livroEncontrado = false;

            foreach(Livro livro in Livros)
            {
                if(livro.Titulo.ToUpper() == Titulo.ToUpper())
                {
                    Console.WriteLine("Título encontrado:");
                    livro.ExibirDetalhes();
                    livroEncontrado = true;
                    break;
                }
            }
            if (!livroEncontrado)
            {
                Console.WriteLine("Título não encontrado.");
            }
        }
        public static void BuscarPorAutor(string Autor)
        {
            Console.WriteLine("Digite o Autor que você deseja buscar");
            Autor = Console.ReadLine();

            bool encontrado = false;

            foreach (Livro livro in Livros)
            {
                if (livro.Autor.ToUpper() == Autor.ToUpper())
                {
                    Console.WriteLine($"Autor encontrado:");
                    livro.ExibirDetalhes();
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Autor não encontrado.");
            }
        }
        public static void ListarDisponiveis()
        {
            bool EstaDisponivel = false;

            foreach(Livro livro in Livros)
            {
                if(livro.Disponivel)
                {
                    if (!EstaDisponivel)
                    {
                        Console.WriteLine("Livros disponíveis:");
                        EstaDisponivel = true;
                    }
                    livro.ExibirDetalhes();
                }
            }

            if (!EstaDisponivel)
            {
                Console.WriteLine("Nenhum livro disponível no momento.");
            }

        }
        public static void ListarTodos()
        {
            if(Livros.Count > 0)
            {
                Console.WriteLine("Livros Cadastrados:");
                foreach (Livro livro in Livros)
                {
                    livro.ExibirDetalhes();
                }
            }
            else
            {
                Console.WriteLine("Biblioteca vazia.");
            }
        }

        public static int QuantidadeLivros()
        {
            return Livros.Count;
        }
    }
}
