using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_arrays_e_colecoes
{
    class Program
    {
        bool estaMarcada(string[,] tabuleiro, int linha, int coluna)
        {
            return tabuleiro[linha, coluna] != "";
        }

        static void exibirTabuleiro(string[,] tabuleiro)
        {
            Console.WriteLine($"{tabuleiro[0, 0]}   |{tabuleiro[0, 1]}   |    {tabuleiro[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{tabuleiro[1, 0]}   |{tabuleiro[1, 1]}   |    {tabuleiro[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{tabuleiro[2, 0]}   |{tabuleiro[2, 1]}   |    {tabuleiro[2, 2]} ");
        }

        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3] { {" ", " ", " " }, { " ", " ", " " } , { " ", " ", " " } };
            Console.WriteLine("Bem vindo ao jogo da velha");
            bool foiDigitadoNove = false;

            for (int turnos = 1; turnos <= 9; turnos++) {
                exibirTabuleiro(tabuleiro);

                Console.WriteLine("É a vez do jogador X. selecione uma posição para jogar");
                Console.WriteLine("Digite a posição da linha desejada: ");
                int linhaJogadorX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a posição da coluna desejada");
                int colunaJogadorX = Convert.ToInt32(Console.ReadLine());

                if(linhaJogadorX == 9 || colunaJogadorX == 9)
                {
                    break;
                }

                tabuleiro[linhaJogadorX, colunaJogadorX] = "X";
        
                exibirTabuleiro(tabuleiro);

                Console.WriteLine("É a vez do jogador O. selecione uma posição para jogar");
                Console.WriteLine("Digite a posição da linha desejada: ");
                int linhaJogadorO = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a posição da coluna desejada");
                int colunaJogadorO = Convert.ToInt32(Console.ReadLine());

                tabuleiro[linhaJogadorO, colunaJogadorO] = "O";

                exibirTabuleiro(tabuleiro);
            }
        }
    }
}
