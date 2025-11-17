using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo logan = new Veiculo("Renô", "Logan", "Cinza", 2015, 200);

            logan.Ligar();
            logan.Desligar();
            logan.Frear(10);
            logan.Acelerar(200);
            logan.Ligar();
            logan.Acelerar(200);
            logan.Acelerar(20);
            logan.Frear(50);
            logan.ExibirStatus();
            logan.Frear(150);
            logan.Desligar();
        }
    }
    public class Veiculo
    {
        public string Marca {get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public int VelocidadeAtual { get; private set; }
        public int VelocidadeMaxima { get; }
        public bool Ligado { get; private set; }

        public Veiculo(string Marca, string Modelo, string Cor, int Ano, int VelocidadeMaxima)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Cor = Cor;
            this.Ano = Ano;
            this.VelocidadeAtual = 0;
            this.VelocidadeMaxima = VelocidadeMaxima;
            this.Ligado = false;
            this.VelocidadeMaxima = VelocidadeMaxima;
        }
        public void Ligar()
        {
            if(Ligado == false)
            {
                Console.WriteLine("Ligando o carro");
                Ligado = true;
            }
            else
            {
                Console.WriteLine("O carro já está ligado.");
            }
        }
        public void Desligar()
        {
            if(VelocidadeAtual == 0)
            {
                Console.WriteLine("Desligando o carro");
                Ligado = false;
            }
            else
            {
                Console.WriteLine("O carro já está deligado");
            }
        }
        public void Acelerar(int incremento)
        {
            if(VelocidadeAtual + incremento <= VelocidadeMaxima && Ligado == true)
            {
                Console.WriteLine($"Acelerando {incremento}km/h");
                VelocidadeAtual += incremento;
            }
            else if(Ligado == false)
            {
                Console.WriteLine("O carro está desligado;");
            }
            else
            {
                Console.WriteLine("O carro atingiu o limite de velocidade");
            }
        }
        public void Frear(int descremento)
        {
            if(VelocidadeAtual >= 0 && Ligado == true)
            {
                Console.WriteLine($"Freando {descremento}km/h");
                VelocidadeAtual -= descremento;
            }
            else
            {
                Console.WriteLine("O carro já está parado.");
            }
        }

        
        public void ExibirStatus()
        {
            Console.WriteLine($"\nMarca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Ano {Ano}");
            Console.WriteLine($"Velocidade Máxima: {VelocidadeMaxima}km/h");
            Console.WriteLine($"Velocidade Atual: {VelocidadeAtual}km/h\n");
        }
    }
}
