using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays para armazenar dados (máximo 50 alunos)
            string[] nomes = new string[50];
            double[] nota1 = new double[50];
            double[] nota2 = new double[50];
            double[] nota3 = new double[50];
            int totalAlunos = 0;

            double media;

            int opcao;
            do
            {
                Console.WriteLine("\n════════════════════════════════");
                Console.WriteLine("   SISTEMA DE GERENCIAMENTO");
                Console.WriteLine("         DE NOTAS");
                Console.WriteLine("════════════════════════════════");
                Console.WriteLine("1. Adicionar aluno");
                Console.WriteLine("2. Calcular médias");
                Console.WriteLine("3. Verificar aprovações");
                Console.WriteLine("4. Estatísticas da turma");
                Console.WriteLine("5. Sair");
                Console.WriteLine("════════════════════════════════");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if(totalAlunos < 50) { 
                            Console.WriteLine("\nDigite o nome do aluno: ");
                            nomes[totalAlunos] = Console.ReadLine();
                            
                            bool invalida = true;
                            while (invalida)
                            {
                                Console.WriteLine("\nDigite a nota 1 (0-10): ");
                                nota1[totalAlunos] = Convert.ToDouble(Console.ReadLine());

                                if(nota1[totalAlunos] > 0 && nota1[totalAlunos] < 10)
                                {
                                    invalida = false;
                                }
                                else 
                                {
                                    Console.WriteLine("Nota inválida!");

                                }
                                Console.WriteLine("\nDigite a nota 2 (0-10): ");
                                nota2[totalAlunos] = Convert.ToDouble(Console.ReadLine());

                                if (nota2[totalAlunos] > 0 && nota2[totalAlunos] < 10)
                                {
                                    invalida = false;
                                }
                                else
                                {
                                    Console.WriteLine("Nota inválida!");

                                }
                                Console.WriteLine("\nDigite a nota 3 (0-10): ");
                                nota3[totalAlunos] = Convert.ToDouble(Console.ReadLine());

                                if (nota3[totalAlunos] > 0 && nota3[totalAlunos] < 10)
                                {
                                    invalida = false;
                                }
                                else
                                {
                                    Console.WriteLine("Nota inválida!");

                                }
                            }
                            Console.WriteLine("\nAluno adicionado com sucesso!\n");
                            totalAlunos++;
                        }
                        else
                        {
                            Console.WriteLine("Limite de alunos atingido!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("MÉDIAS DOS ALUNOS: ");
                        Console.WriteLine("─────────────────────────────────");
                        for (int i = 0; i < totalAlunos; i++) 
                        {
                            media = (nota1[i] + nota2[i] + nota3[i]) / 3.0;
                            Console.WriteLine($"{nomes[i]}: {media:F2}");
                        }
                        Console.WriteLine("─────────────────────────────────");
                        break;

                    case 3:
                        bool reprovado = true;

                        while (reprovado)
                        {
                            for (int i = 0; i < totalAlunos; i++)
                            {
                                media = (nota1[i] + nota2[i] + nota3[i]) / 3.0;
                                if (media >= 7.0)
                                {
                                    Console.WriteLine($"{nomes[i]}: {media:F2} - APROVADO!");
                                    reprovado = false;
                                }
                                else
                                {
                                    Console.WriteLine($"{nomes[i]}: {media:F2} - REPROVADO!");
                                }
                            }
                        }
                        break;
                    case 4:
                        double maiorNota = -1;
                        double menorNota = 11;
                        int indiceMaiorNota = -1;
                        int indiceMenorNota = -1;
                        int aprovados = 0;
                        double somaMedias = 0;

                        for (int i = 0; i < totalAlunos; i++)
                        {
                            media = (nota1[i] + nota2[i] + nota3[i]) / 3.0;
                            somaMedias += media;

                            if (media >= 7.0)
                                aprovados++;

                            double maiorNotaAluno = Math.Max(nota1[i], Math.Max(nota2[i], nota3[i]));
                            double menorNotaAluno = Math.Min(nota1[i], Math.Min(nota2[i], nota3[i]));

                            if (maiorNotaAluno > maiorNota)
                            {
                                maiorNota = maiorNotaAluno;
                                indiceMaiorNota = i;
                            }

                            if (menorNotaAluno < menorNota)
                            {
                                menorNota = menorNotaAluno;
                                indiceMenorNota = i;
                            }
                        }

                        double mediaGeral = somaMedias / totalAlunos;
                        double taxaAprovacao = (double)aprovados / totalAlunos * 100;

                        Console.WriteLine("ESTATÍSTICAS DA TURMA:");
                        Console.WriteLine("═══════════════════════════════════");
                        Console.WriteLine($"Total de alunos: {totalAlunos}");
                        Console.WriteLine($"Média geral: {mediaGeral:F2}");
                        Console.WriteLine($"Maior nota: {maiorNota:F2} (Aluno: {nomes[indiceMaiorNota]})");
                        Console.WriteLine($"Menor nota: {menorNota:F2} (Aluno: {nomes[indiceMenorNota]})");
                        Console.WriteLine($"Taxa de aprovação: {taxaAprovacao:F2}%");
                        break;
                }

            } while (opcao != 5);
        }
    }
}
