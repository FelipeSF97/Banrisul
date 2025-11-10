using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int vogais = 0;
            int consoantes = 0;
            int numeros = 0;
            //char[] numero = {' ', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            foreach(char letra in frase.ToUpper())
            {
            //    if (numero.Contains(letra))
            //    {
            //        continue;
            //    }
                switch (letra)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vogais++;
                        break;;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                       numeros++;
                        break;
                    case ' ':
                        continue;
                    default:
                        consoantes++;
                        break;
                }
            }
            Console.WriteLine($"Vogais: {vogais}");
            Console.WriteLine($"Consoantes: {consoantes}");
            Console.WriteLine($"Números: {numeros}");
        }
    }
}
