using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_estruturas_condicionais
{
    class Program
    {
        /* Constantes de animais */
        public const string ANIMAL_COMPANHEIRO = "Companheira(o)";
        public const string ANIMAL_ASTUTO = "Astuta(o)";
        public const string ANIMAL_GUARDIAO = "Guardiã(o)";
        public const string ANIMAL_FEROZ = "Feroz";
        public const string ANIMAL_DESCONHECIDO = "Desconhecida(o)";

        /* Constantes de cores */
        public const string COR_FLAMEJANTE = "Flamejante";
        public const string COR_SABEDORIA = "Sábia(o)";
        public const string COR_SILVESTRE = "Silvestre";
        public const string COR_RADIANTE = "Radiante";
        public const string COR_MISTERIOSA = "Misteriosa(o)";

        /* Constantes de aventuras */
        public const string AVENTURA_EXPLORAR = "Pront(a)o para aventuras!";
        public const string AVENTURA_DESCANSAR = "Tranquila(o) e serena(o)!";
        public const string AVENTURA_CRIAR = "Criativa(o) e engenhosa(o)!";
        public const string AVENTURA_COMPETIR = "Audaciosa(o) e competitiva(o)!";
        public const string AVENTURA_DESTEMIDA = "Destemida(o) em qualquer jornada!";

        static void Main(string[] args)
        {
            Console.WriteLine(".:: Descubra seu Avatar ::. \n");

            /* Capturar animal, cor e aventura informados pelo usuário */
            Console.WriteLine("Digite seu animal preferido: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Digite sua cor preferida: ");
            string cor = Console.ReadLine();

            Console.WriteLine("Que tipo de aventura você quer enfrentar? ");
            string aventura = Console.ReadLine();

            /* Implementar lógicas de mapeamento para as constantes fornecidas
             * Exemplo: se o usuário informar "vermelho", uma variável deve receber o valor da constante COR_FLAMEJANTE
            */
            switch (animal)
            {
                case "cão":
                    animal = ANIMAL_COMPANHEIRO;
                    break;
                case "gato":
                    animal = ANIMAL_ASTUTO;
                    break;
                case "coruja":
                    animal = ANIMAL_GUARDIAO;
                    break;
                case "dragão":
                    animal = ANIMAL_FEROZ;
                    break;
                default:
                    animal = ANIMAL_DESCONHECIDO;
                    break;
            }

            //if (cor == "vermelho")
            //{
            //    cor = COR_FLAMEJANTE;
            //}
            //else if (cor == "azul")
            //{
            //    cor = COR_SABEDORIA;
            //}
            //else if (cor == "verde")
            //{
            //    cor = COR_SILVESTRE;
            //}
            //else if (cor == "amarelo")
            //{
            //    cor = COR_RADIANTE;
            //}
            //else
            //{
            //    cor = COR_MISTERIOSA;
            //}


            cor = cor == "vermelho" ? COR_FLAMEJANTE :
                  cor == "azul" ? COR_SABEDORIA :
                  cor == "verde" ? COR_SILVESTRE :
                  cor == "amarelo" ? COR_RADIANTE :
                  COR_MISTERIOSA;


            switch (aventura)
            {
                case "explorar":
                    aventura = AVENTURA_EXPLORAR;
                    break;
                case "descansar":
                    aventura = AVENTURA_DESCANSAR;
                    break;
                case "criar":
                    aventura = AVENTURA_CRIAR;
                    break;
                case "competir":
                    aventura = AVENTURA_COMPETIR;
                    break;
                default:
                    aventura = AVENTURA_DESTEMIDA;
                    break;
            }


            /* Imprimir a descrição do avatar no formato: "Seu avatar é: {animal} {cor} - {aventura}" */
            Console.WriteLine($"Seu avatar é: {animal} {cor} - {aventura}");
        }
    }
}
