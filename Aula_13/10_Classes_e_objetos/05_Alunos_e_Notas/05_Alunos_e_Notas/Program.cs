using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Alunos_e_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno felipe = new Aluno("Felipe Flores", "175528");
            felipe.AlterarNota(1, 10);
            felipe.AlterarNota(2, 9);
            felipe.AlterarNota(3, 8);
            felipe.ExibirBoletim();

            Aluno eduarda = new Aluno("Eduarda Vitória", "175529");
            eduarda.AlterarNota(1, 7);
            eduarda.AlterarNota(2, 6);
            eduarda.AlterarNota(3, 5);
            eduarda.ExibirBoletim();

            Aluno rosane = new Aluno("Rosane Soutinho", "175530");
            rosane.AlterarNota(1, 5);
            rosane.AlterarNota(2, 4);
            rosane.AlterarNota(3, 3);
            rosane.ExibirBoletim();
        }
    }
    public class Aluno
    {
        public string Nome {get; set; }
        public string Matricula {get; }
        public decimal nota1;
        public decimal nota2;
        public decimal nota3;
        public decimal media;
        public string situacao;

        public Aluno(string Nome, string Matricula)
        {
            this.Nome =  Nome;
            this.Matricula = Matricula;
        }
        public decimal GetNota1()
        {
            if(nota1 < 0 || nota1 >10) { return 0; }
            else { return nota1; }
        }
        public decimal GetNota2()
        {
            if (nota2 < 0 || nota2 > 10) { return 0; }
            else { return nota2; }
        }
        public decimal GetNota3()
        {
            if (nota3 < 0 || nota3 > 10) { return 0; }
            else { return nota3; }
        }
        public decimal GetMedia(){ return media = (nota1 + nota2 + nota3) / 3.00m; }
        public string getSituacao()
        {
            if(media >= 7){ return "APROVADO(A)"; }
            else if(media >= 5 && media <= 7){ return "RECUPERAÇÃO"; }
            else { return "REPROVADO(A)"; }
        }
        public void AlterarNota(int numeroNota, decimal novoValor)
        {            
            switch (numeroNota)
            {
                case 1:
                    nota1 = novoValor;
                    break;
                case 2:
                    nota2 = novoValor;
                    break;
                case 3:
                    nota3 = novoValor;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;  
            }
        }
        public void ExibirBoletim()
        {
            Console.WriteLine($"\nAluno: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Nota 1: {GetNota1()}");
            Console.WriteLine($"Nota 2: {GetNota2()}");
            Console.WriteLine($"Nota 3: {GetNota3()}");
            Console.WriteLine($"Média: {GetMedia()}");
            Console.WriteLine($"Situação: {getSituacao()}\n");
        }
    }
}
