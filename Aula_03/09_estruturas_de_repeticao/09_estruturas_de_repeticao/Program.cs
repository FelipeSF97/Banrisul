using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_estruturas_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numero = new Random().Next(1,11);
            int tentativas = 0;
            bool acertou = false;

            while (!acertou) 
            { 
                Console.WriteLine("Escolha um número de 1 até 10: ");
                int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if(numeroEscolhido == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número e precisou de {tentativas} tentativas.");
                    acertou = true;
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente.");
                    if(numeroEscolhido > numero)
                    {
                        Console.WriteLine("O número secreto é menor!");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é maior!");
                    }
                }
            }*/

            int opcaoSelecionada = -1;

            /* Executar infinitamente o assistente virtual, executando cada ação conforme
             * selecionado pelo usuário, até que o mesmo selecione a opção para encerrar
            */
            while (opcaoSelecionada != 0)
            {
                ExibirMenu();
                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
                switch (opcaoSelecionada)
                {
                    case 0:
                        Console.WriteLine("Encerrando o assistente.");
                        break;
                    case 1:
                        Console.WriteLine($"Data atual: {ObterDataAtual()}");
                        break;
                    case 2:
                        Console.WriteLine($"Hora atual: {ObterHoraAtual()}");
                        break;
                    case 3:
                        DizerOla();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        static void ExibirMenu()
        {
            Console.WriteLine("===== Menu Interativo =====");
            Console.WriteLine("1 - Exibir data atual");
            Console.WriteLine("2 - Exibir hora atual");
            Console.WriteLine("3 - Exibir saudação");
            Console.WriteLine("0 - Finalizar");
            Console.WriteLine("===========================");
            Console.Write("Escolha uma opção válida: ");
        }

        // Método que retorna a data atual formatada
        static string ObterDataAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Método que retorna a hora atual formatada
        static string ObterHoraAtual()
        {
            return DateTime.Now.ToString("HH:mm");
        }

        // Método que imprime uma saudação
        static void DizerOla()
        {

            Console.WriteLine($"Olá, usuário!\n");
        }
    }
}
