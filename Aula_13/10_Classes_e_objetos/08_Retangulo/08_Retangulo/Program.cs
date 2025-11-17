using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(5, 5);
            Retangulo r2 = new Retangulo(7, 6);

            r1.ExibirDimensoes();
            r2.ExibirDimensoes();

            r1.Redimensionar(8, 9);
            r1.ExibirDimensoes();
            r1.Comparar(r2);

        }
    }
    public class Retangulo
    {
        public double Largura {get; set; }
        public double Altura { get; set; }
        public double Area;
        public double Perimetro;
        public bool EhQuadrado {get; private set; }

        public Retangulo(double Largura, double Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
            GetEhQuadrado();
        }

        public double GetArea()
        {
            return Area = Largura * Altura;
        }

        public double getPerimetro()
        {
            return 2*(Largura + Altura);
        }
        
        public void GetEhQuadrado()
        {
            if(Largura == Altura)
            {
                EhQuadrado = true;
            }
            else
            {
                EhQuadrado = false;
            }
        }
        public void ExibirDimensoes()
        {
            Console.WriteLine($"\nLargura: {Largura}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Área: {GetArea()}");
            Console.WriteLine($"Perímetro: {getPerimetro()}");
            Console.WriteLine($"É um quadrado? {EhQuadrado}\n");
        }
        public void Redimensionar(double NovaLargura, double NovaAltura)
        {
            Largura = NovaLargura;
            Altura = NovaAltura;
            GetEhQuadrado();
        }
        public void Comparar(Retangulo outro)
        {

            if(GetArea() > outro.GetArea()) { Console.WriteLine("Este retângulo é maior que o outro."); }
            else if (GetArea() < outro.GetArea()){ Console.WriteLine("Este retângulo é menor que o outro."); }
            else { Console.WriteLine("Os dois retângulos têm a mesma área.");  }
        }
    }
}
