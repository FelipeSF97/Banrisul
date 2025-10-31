using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Reserva r1 = new Reserva("John Doe", "305", 5, 250.00m, 1250.00m);
            Reserva r2 = new Reserva("102", 180.00m, 360.00m);

            r1.exibirResumo();
            r2.exibirResumo();

        }
    }
    public class Reserva
    {
        public string nome {get; private set; }
        public string numeroQuarto {get; private set; }
        public int numeroDias { get; private set; }
        public decimal valorDiaria { get; private set; }
        public decimal valorTotal { get; private set; }
        public string status { get; private set; }

        public Reserva(string nome, string numeroQuarto, int numeroDias, decimal valorDiaria, decimal valorTotal, string status)
        {
            this.nome = nome;
            this.numeroQuarto = numeroQuarto;
            this.numeroDias = numeroDias;
            this.valorDiaria = valorDiaria;
            this.valorTotal = valorTotal;
            this.status = status;
        }

        public Reserva(string nome, string numeroQuarto, int numeroDias, decimal valorDiaria, decimal valorTotal) : 
            this(nome, numeroQuarto, numeroDias, valorDiaria, valorTotal, "CONFIRMADA") { }

        public Reserva(string nome, string numeroQuarto, decimal valorDiaria, decimal valorTotal) :
            this(nome, numeroQuarto, 2, valorDiaria, valorTotal, "CONFIRMADA") { }

        public Reserva(string numeroQuarto, decimal valorDiaria, decimal valorTotal) :
            this("A definir", numeroQuarto, 2, valorDiaria, valorTotal, "PENDENTE"){ }

        public void exibirResumo()
        {
            if(numeroDias > 2) 
            { 
                Console.WriteLine("Reserva completa criada com sucesso!");
            }
            else
            {
                Console.WriteLine("Reserva mínima criada com sucesso!");
            }
            Console.WriteLine($"Cliente: {nome}\nQuarto: {numeroQuarto}\nNúmero de Dias: {numeroDias}" +
                $"\nValor da diária: {valorDiaria}\nValor Total: {valorTotal}\nStatus: {status}\n");
        }
        
    }
}
