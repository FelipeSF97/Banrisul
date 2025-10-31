using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_heranca_composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente cc = new ContaCorrente("Felipe Flores", "1909");
            Poupanca p = new Poupanca("Rosane Soutinho", "1968");
            ContaConjunta cj = new ContaConjunta("Eduarda Vitória", "2023", "Felipe Flores");

            cc.Depositar(1000);
            cc.Sacar(500);
            

            p.Depositar(2000);
            p.Sacar(300);

            cj.Depositar(4000);
            cj.Sacar(300);

            cc.Transferir(p, 100);

            List<Conta> contas = new List<Conta>() {cc, p, cj };

            
            foreach(var conta in contas)
            {
                
                conta.Resumo();
            }
            void listarMovimentacoes(string NumeroConta)
            {

                foreach (var conta in contas)
                {
                    if (NumeroConta == conta.NumeroConta)
                    {
                        Console.WriteLine($"Movimentações da conta {NumeroConta} em {DateTime.Now}:");
                        foreach (var mov in conta.Movimentacoes)
                        {
                            Console.WriteLine($"Operação: {mov.Descricao}");
                            Console.WriteLine($"Valor: R${mov.Valor}");
                            Console.WriteLine("===========================");
                        }
                    }
                }
            }
            listarMovimentacoes("1909");
        }
    }
    public class Conta
    {
        protected string Titular;
        public string NumeroConta;
        protected decimal Saldo;
        protected string Tipo;
        public List<Movimentacao> Movimentacoes;

        public Conta(string Titular, string NumeroConta)
        {
            this.Titular = Titular;
            this.NumeroConta = NumeroConta;
            this.Saldo = 0;
            this.Tipo = " ";
            this.Movimentacoes = new List<Movimentacao>();
        }
                
        public virtual void Depositar(decimal Valor)
        {
            Console.WriteLine($"Conta {Tipo} de: {Titular}\nNúmero: {NumeroConta}");
            if (Valor > 0)
            {
                Saldo += Valor;
                Console.WriteLine($"Valor depositado: R${Valor}\nNovo saldo da conta: R${Saldo}");
                Console.WriteLine("==============================================================");
                Movimentacoes.Add( new Movimentacao(NumeroConta, "Depósito", Valor));
            }
            else
            {
                throw new Exception("Valor inválido!");
            }
        }
        public virtual void Sacar(decimal Valor)
        {
            Console.WriteLine($"Conta {Tipo} de: {Titular}\nNúmero: {NumeroConta}");
            if (Saldo >= Valor && Valor > 0)
            {
                Saldo -= Valor;
                Console.WriteLine($"Valor sacado: R${Valor}\nNovo saldo da conta: R${Saldo}");
                Console.WriteLine("==============================================================");
                Movimentacoes.Add(new Movimentacao(NumeroConta, "Saque", -Valor));
            }
            else
            {
                throw new Exception("Valor inválido");
            }
        }
        public virtual void Resumo()
        {
            Console.WriteLine($"Número da conta {Tipo}: {NumeroConta}\nNome titular: {Titular}\nSaldo: {Saldo}");
            Console.WriteLine("==============================================================");
        }
        public virtual void Transferir(Conta Destino, decimal Valor)
        {
            Console.WriteLine($"Conta de: {Titular}\nNúmero: {NumeroConta}");
            if (Destino != null && Valor> 0)
            {
                Sacar(Valor);
                Destino.Depositar(Valor);
                Console.WriteLine($"Transferido R${Valor} para a conta {Tipo} de {Destino.Titular} - número: {Destino.NumeroConta}");
                Console.WriteLine("==============================================================");
                Movimentacoes.Add(new Movimentacao(NumeroConta, $"Transferência para a conta {Destino.NumeroConta} de {Destino.Titular}", -Valor));
                Destino.Movimentacoes.Add(new Movimentacao(Destino.NumeroConta, $"Transferência recebida de {NumeroConta}", Valor));

            }
            else
            {
                throw new Exception("Esta conta não existe!");
            }
        }
        

    }
    public class ContaCorrente : Conta
    {
        private const decimal TarifaSaque = 1; 

        public ContaCorrente(string Titular, string NumeroConta) : base(Titular, NumeroConta) { Tipo = "Corrente"; }


        public override void Sacar(decimal Valor)
        {

            if (Saldo >= Valor + TarifaSaque && Valor > 0)
            {
                Saldo -= Valor + TarifaSaque;
                Console.WriteLine($"Valor sacado: R${Valor}\nTarifa de R${TarifaSaque}\nNovo saldo da conta {Tipo}: R${Saldo}");
                Console.WriteLine("==============================================================");
                Movimentacoes.Add(new Movimentacao(NumeroConta, "Saque", -Valor));
            }
            else
            {
                throw new Exception("Valor inválido");
            }
        }
    }
    public class Poupanca : Conta
    {
        private const decimal TaxaRendimentoAnual = 0.08m;

        public Poupanca(string Titular, string NumeroConta) : base(Titular, NumeroConta) { Tipo = "Poupança"; }
        public void RenderJuros(int dias)
        {
            Console.WriteLine($"Conta {Tipo} de: {Titular}\nNúmero: {NumeroConta}");
            decimal Rendimento = Saldo * (TaxaRendimentoAnual * dias / 365);
            //Saldo += Rendimento;
            base.Depositar(Rendimento);
        }
    }
    public class ContaConjunta : ContaCorrente
    {
        private string SegundoTitular;

        public ContaConjunta(string Titular, string NumeroConta, string SegundoTitular) : base(Titular, NumeroConta) 
        {
            this.SegundoTitular = SegundoTitular;
            Tipo = "Conjunta";
        }
        public override void Depositar(decimal Valor)
        {
            Console.WriteLine($"Conta {Tipo} de: {Titular} e {SegundoTitular}\nNúmero: {NumeroConta}");
            if (Valor > 0)
            {
                Saldo += Valor;
                Console.WriteLine($"Valor depositado: R${Valor}\nNovo saldo da conta: R${Saldo}");
                Console.WriteLine("==============================================================");
                Movimentacoes.Add(new Movimentacao(NumeroConta, "Depósito", Valor));
            }
            else
            {
                throw new Exception("Valor inválido!");
            }
        }
        public override void Resumo()
        {
            Console.WriteLine($"Número da conta {Tipo}: {NumeroConta}\nNome do primeiro titular: {Titular}\nNome do segundo Titular: {SegundoTitular}\nSaldo: {Saldo:F2}");
            Console.WriteLine("==============================================================");
        }
    }
    public class Movimentacao
    {
        public DateTime Data;
        public string NumeroConta;
        public string Descricao;
        public decimal Valor;

        public Movimentacao(string NumeroConta, string descricao, decimal valor)
        {
            // this.Data = new DateTime(2025, 10, 30);
            this.Data = DateTime.Now;
            this.NumeroConta = NumeroConta;
            this.Descricao = descricao;
            this.Valor = valor;
        }
        

    }
}
