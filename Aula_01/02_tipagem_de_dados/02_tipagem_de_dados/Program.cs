using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_tipagem_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //char emoji = '😊';
            //System.Console.WriteLine($"{emoji}");
            //Too many characters in character literal

            char emoji = '☺';
            System.Console.WriteLine($"{emoji}");
            //☺

            char letra = 'A';
            int numero = letra;
            System.Console.WriteLine($"{numero}");
            //65

            string condicao = "TRUE";
            bool converte = System.Convert.ToBoolean(condicao);
            System.Console.WriteLine($"{converte}");
            //True

            double pontosGanhos = 84.68;
            int barrasChocolate = System.Convert.ToInt32(pontosGanhos);
            System.Console.WriteLine($"{barrasChocolate}");
            //85
        }
    }
}
