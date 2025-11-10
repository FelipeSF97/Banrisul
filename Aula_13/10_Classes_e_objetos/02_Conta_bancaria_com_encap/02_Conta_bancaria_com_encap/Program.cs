using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Conta_bancaria_com_encap
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria felipe = new ContaBancaria("1909", "Felipe Flores", 250);
            ContaBancaria duda = new ContaBancaria("2005", "Eduarda Vitória", 600);

            List<ContaBancaria> contas = new List<ContaBancaria> { felipe, duda };

            felipe.ExibirMenu(contas);

        }

    }

    public class ContaBancaria
    {
        public string NumeroConta {get; }
        public string Titular {get; set; }
        public decimal Saldo;

        public ContaBancaria(string NumeroConta, string Titular, decimal Saldo)
        {
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }
        public void ExibirMenu(List<ContaBancaria> Contas)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine($"Olá, {Titular}!");
                Console.WriteLine("BEM VINDO(A) AO BANRISUL");
                Console.WriteLine("=============================");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Transferir");
                Console.WriteLine("4 - Exibir extrato");
                Console.WriteLine("5 - Sair\n");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor a ser depositado: ");
                        decimal ValorDeposito = Convert.ToDecimal(Console.ReadLine());
                        Depositar(ValorDeposito);
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor a ser sacado: ");
                        decimal ValorSaque = Convert.ToDecimal(Console.ReadLine());
                        Sacar(ValorSaque);
                        break;

                    case 3:
                        Console.WriteLine("Contas disponíveis:");
                        foreach (ContaBancaria conta in Contas)
                        {
                            Console.WriteLine($"- {conta.NumeroConta} ({conta.Titular})");
                        }

                        Console.WriteLine("Digite o número da conta de destino: ");
                        string NumeroDestino = Console.ReadLine().Trim();

                        ContaBancaria ContaDestino = null;

                        foreach (ContaBancaria Conta in Contas)
                        {
                            if (Conta.NumeroConta == NumeroDestino && Conta != this)
                            {
                                ContaDestino = Conta;
                                break;
                            }
                        }

                        if (ContaDestino != null)
                        {
                            Console.WriteLine("Digite o valor a ser transferido: ");
                            decimal ValorTransferencia = Convert.ToDecimal(Console.ReadLine());
                            if (ValorTransferencia > 0 && ValorTransferencia <= Saldo)
                            {
                                Transferir(ContaDestino, ValorTransferencia);
                                Console.WriteLine("Transferência realizada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Conta de destino inválida ou não encontrada.");
                        }
                        break;

                    case 4:
                        ExibirExtrato();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o atendimento. Obrigado por usar o BANRISUL!");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
            }
        }
        public void Depositar(decimal Valor)
        {
            if (Valor > 0)
            {
                Saldo += Valor;
                Console.WriteLine("Depósito realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido! Deposite um valor maior que R$0");
            }
        }

        public void Sacar(decimal Valor)
        {
            if (Valor > 0 && Saldo >= Valor)
            {
                Saldo -= Valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido ou saldo insuficiente!");
            }
        }

        public void Transferir(ContaBancaria Destino, decimal Valor)
        {
            if (Valor > 0 && Saldo >= Valor)
            {
                Sacar(Valor);
                Destino.Depositar(Valor);
            }
            else
            {
                Console.WriteLine("Transferência inválida!");
            }
        }

        public void ExibirExtrato()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: R${Saldo:F2}");
        }
    }
}
