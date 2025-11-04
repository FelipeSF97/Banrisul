//Exibe um menu de opções
//Solicita o nome do usuário
//Mostra informações sobre o.NET instalado
//Exibe a data e hora atual formatada(use o System.DateTime.Now para obter a data e hora atual)
//Permite sair da aplicação
//using System;

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
           Sistema s = new Sistema();
            s.Apresentar();
            s.MostrarMenu();
        }
    }
    public class Sistema
    {
        string nome;

        public void Apresentar()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("   BEM-VINDO AO SISTEMA .NET     ");
            Console.WriteLine("=================================");
            Console.WriteLine();


            Console.Write("Digite seu nome: ");

            string nome = Console.ReadLine() ?? "Visitante";

            Console.WriteLine($"Olá, {nome}");

        }
        public void MostrarMenu()
        {
            int opcao = 0;

            while(opcao != 3) { 
                Console.WriteLine("\nMENU:");
                Console.WriteLine("[1] Ver informações do sistema\n[2] Ver data e hora\n[3] Sair\n");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        //Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Version);
                        Console.WriteLine("=== Informações do Sistema ===");
                        Console.WriteLine($"Versão do .NET: {Environment.Version}");
                        Console.WriteLine($"Sistema Operacional: {Environment.OSVersion}");
                        Console.WriteLine($"64 bits: {(Environment.Is64BitOperatingSystem ? "Sim" : "Não")}");
                        Console.WriteLine($"Arquitetura do Processo: {(Environment.Is64BitProcess ? "64 bits" : "32 bits")}");
                        Console.WriteLine($"Máquina: {Environment.MachineName}");
                        Console.WriteLine($"Usuário: {Environment.UserName}");
                        break;

                    case 2:
                        Console.WriteLine(DateTime.Now);
                        break;
                    case 3:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
