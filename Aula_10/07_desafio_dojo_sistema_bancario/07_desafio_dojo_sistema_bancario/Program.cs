using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_desafio_dojo_sistema_bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o sistema bancário...");

            // menu de operações
            while (true)
            {
                Console.WriteLine("\n1 - cadastrar novo cliente");
                Console.WriteLine("2 - cadastrar conta para cliente");
                Console.WriteLine("3 - listar clientes");
                Console.WriteLine("4 - consultar saldo de conta");
                Console.WriteLine("5 - efetuar depósito");
                Console.WriteLine("6 - efetuar saque");
                Console.WriteLine("7 - efetuar transferência");
                Console.WriteLine("s - sair");
                Console.WriteLine("selecione a ação: ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "s")
                    break;

                switch (opcao)
                {
                    case "1":
                        Banco.cadastrarnovocliente();

                        break;
                    case "2":
                        Banco.cadastrarnovacontabancaria();

                        break;
                    case "3":
                        Banco.listarclientesecontas();

                        break;
                    case "4":
                        Banco.consultarsaldocontabancaria();

                        break;
                    case "5":
                        Banco.realizardeposito();

                        break;
                    case "6":
                        Banco.realizarsaque();

                        break;
                    case "7":
                        Banco.realizartransferencia();

                        break;
                    default:
                        Console.WriteLine("\nopção inválida.");

                        break;
                }
            }

            Console.WriteLine("\nencerrando o sistema bancário...");
        }
    }
    public class Cliente
    {
        public string cpf { get; set;}
        public string nome { get; set; }
        public List<ContaBancaria> contas { get; set; }
        //static Dictionary<string, string> nomes = new Dictionary<string, string>(); // chave: cpf, valor: nome
        //static Dictionary<string, List<int>> contas = new Dictionary<string, List<int>>(); // chave: cpf, valor: lista de números de contas

        public Cliente(string cpf, string nome)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.contas = new List<ContaBancaria>();
        }
    }
    public class ContaBancaria
    {
        public string tipo { get; set; }
        public string numeroConta { get; set; }
        public decimal saldo { get; set; }

        public ContaBancaria(Cliente nome, Cliente cpf, string numeroConta)
        {
            this.tipo = "";
            this.numeroConta = numeroConta;
            this.saldo = 0;
        }
    }
    public class ContaCorrente : ContaBancaria
    {
        public const decimal TarifaSaque = 1;

        public ContaCorrente(Cliente nome, Cliente cpf, string numeroConta) : base(nome, cpf, numeroConta) { tipo = "Corrente"; }


        
    }
    public class Poupanca : ContaBancaria
    {
        private const decimal TaxaRendimentoAnual = 0.08m;

        public Poupanca(Cliente nome, Cliente cpf, string numeroConta) : base(nome, cpf, numeroConta) { tipo = "Poupança"; }
    }
    public class Banco
    {
        public int clientesCadastrados { get; set; }
        public List<Cliente> nomes { get; set; }
        public List<ContaBancaria> contas { get; set; }
        public ContaBancaria tipo;
        public Cliente nome;
        public decimal saldo { get; set; }
        public ContaBancaria numeroConta;

        public Banco() 
        { 
            this.clientesCadastrados = 0;
        }

        public void cadastrarCliente(string cpf, string nome)
        {
            if (cpf != null)
            {
                new Cliente(cpf, nome);
                clientesCadastrados++;
            }
            else
            {
                throw new Exception("Cliente já cadastrado!");
            }

        }
        public static void cadastrarNovaContaBancaria(Cliente nome, Cliente cpf, string numeroConta)
        {
            if (cpf != null)
            {
                throw new Exception("Cliente não cadastrado!");
            }
            else if (numeroConta != null)
            {
                throw new Exception("Esta conta já existe!");
            }
            else
            {
                new ContaBancaria(nome, cpf, numeroConta);
            }
        }
        public virtual void Depositar(ContaBancaria numeroConta, decimal valor)
        {

            Console.WriteLine($"Conta {tipo} de: {nome}\nNúmero: {numeroConta}");
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Valor depositado: R${valor}\nNovo saldo da conta: R${saldo}");
                Console.WriteLine("==============================================================");
            }
            else
            {
                throw new Exception("Valor inválido!");
            }
        }
        public virtual void Sacar(decimal Valor)
        {
            Console.WriteLine($"Conta {tipo} de: {nome}\nNúmero: {numeroConta}");
            if (saldo >= Valor && Valor > 0)
            {
                saldo -= Valor;
                Console.WriteLine($"Valor sacado: R${Valor}\nNovo saldo da conta: R${saldo}");
                Console.WriteLine("==============================================================");
            }
            else
            {
                throw new Exception("Valor inválido");
            }
        }
        public override void SacarComTarifa(decimal Valor)
        {
            if (saldo >= Valor + TarifaSaque && Valor > 0)
            {
                saldo -= Valor + TarifaSaque;
                Console.WriteLine($"Valor sacado: R${Valor}\nTarifa de R${TarifaSaque}\nNovo saldo da conta {tipo}: R${saldo}");
                Console.WriteLine("==============================================================");
            }
            else
            {
                throw new Exception("Valor inválido");
            }
        }
        public void RenderJuros(int dias)
        {
            Console.WriteLine($"Conta {tipo} de: {nome}\nNúmero: {numeroConta}");
            decimal Rendimento = saldo * (TaxaRendimentoAnual * dias / 365);
            //Saldo += Rendimento;
            Banco.Depositar(Rendimento);
        }
    }
}



//class Banco
//{
//    static int NumeroConta = 1;

//    public static void CadastrarNovoCliente()
//    {
//        Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
//        string inputCPF = Console.ReadLine();

//        if (inputCPF.ToUpper() == "S")
//            return;

//        if (Cliente.Cadastrado(inputCPF))
//        {
//            Console.WriteLine("Cliente com esse CPF já está cadastrado.");

//            return;
//        }

//        Console.WriteLine($"Digite o nome do cliente (ou 'S' para sair):");
//        string inputNome = Console.ReadLine();

//        if (inputNome.ToUpper() == "S")
//            return;

//        Cliente.Cadastrar(inputCPF, inputNome);

//        Console.WriteLine($"Cliente '{Cliente.ObterNome(inputCPF)}' cadastrado com sucesso!");
//    }

//    public static void CadastrarNovaContaBancaria()
//    {
//        Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
//        string inputCPF = Console.ReadLine();

//        if (inputCPF.ToUpper() == "S")
//            return;

//        if (!Cliente.Cadastrado(inputCPF))
//        {
//            Console.WriteLine("Cliente não encontrado.");

//            return;
//        }

//        Console.WriteLine("Digite o número respectivo ao tipo de conta, sendo 1 para 'Poupança' e 2 para 'Corrente' (ou 'S' para sair):");
//        string inputTipo = Console.ReadLine();

//        if (inputTipo.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputTipo, out int tipo))
//        {
//            Console.WriteLine("Tipo de conta inválido.");

//            return;
//        }

//        if (!ContaBancaria.TipoValido(tipo))
//        {
//            Console.WriteLine("Tipo de conta inválido.");

//            return;
//        }

//        Console.WriteLine("Digite o saldo inicial (R$):");
//        string inputSaldo = Console.ReadLine();

//        if (!double.TryParse(inputSaldo, out double saldo))
//        {
//            Console.WriteLine("Saldo inválido. Conta iniciará com saldo R$ 0,00.");

//            saldo = 0;
//        }

//        ContaBancaria.Cadastrar(NumeroConta, inputCPF, tipo, saldo);

//        Console.WriteLine($"Conta {NumeroConta} criada para o cliente {Cliente.ObterNome(inputCPF)} com sucesso! Saldo de {ContaBancaria.ObterSaldo(NumeroConta)}.");

//        NumeroConta++;
//    }

//    public static void ListarClientesEContas()
//    {
//        if (Cliente.ObterQuantidadeClientesCadastrados() == 0)
//        {
//            Console.WriteLine("Não há clientes cadastrados.");

//            return;
//        }

//        Console.WriteLine("\nLista de clientes:");

//        List<string> cpfs = Cliente.ObterCpfsClientesCadastrados();
//        for (int i = 0; i < cpfs.Count; i++)
//        {
//            string cpf = cpfs[i];

//            Console.WriteLine($"\n{Cliente.ObterNome(cpf)} ({cpf}):");

//            List<int> contas = Cliente.ObterContas(cpf);

//            if (contas.Count == 0)
//            {
//                Console.WriteLine($">>> Nenhuma conta cadastrada.");

//                continue;
//            }

//            for (int j = 0; j < contas.Count; j++)
//            {
//                int numeroConta = contas[j];

//                Console.WriteLine($">>> Conta {ContaBancaria.ObterTipo(numeroConta).ToLower()} número {numeroConta}: {ContaBancaria.ObterSaldo(numeroConta)}.");
//            }
//        }
//    }

//    public static void ConsultarSaldoContaBancaria()
//    {
//        Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
//        string inputNumeroConta = Console.ReadLine();

//        if (inputNumeroConta.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputNumeroConta, out int numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        if (!ContaBancaria.Cadastrada(numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        Console.WriteLine($"Saldo da conta número {numeroConta}: {ContaBancaria.ObterSaldo(numeroConta)}.");

//        // Um desafio adicional pra instigar caso haja tempo para tal: E se precisar descobrir o cliente dono da conta pra imprimir junto na mensagem?

//        /*
//         *   string cpfDono = null;
//         *
//         *   List<string> cpfs = Cliente.ObterCpfsClientesCadastrados();
//         *
//         *   for (int i = 0; i < cpfs.Count; i++) // Percorre linearmente todos os CPFs e respectivas contas até achar (ou não) - Algoritmo O(n)
//         *   {
//         *       string cpf = cpfs[i];
//         *       
//         *       List<int> contas = Cliente.ObterContas(cpf);
//         *
//         *       for (int j = 0; j < contas.Count; j++)
//         *       {
//         *           if (contas[j] == numeroConta)
//         *           {
//         *               cpfDono = cpf;
//         *
//         *               break;
//         *           }
//         *       }
//         *       
//         *       if (cpfDono != null)
//         *           break;
//         *   }
//        */
//    }

//    public static void RealizarDeposito()
//    {
//        Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
//        string inputNumeroConta = Console.ReadLine();

//        if (inputNumeroConta.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputNumeroConta, out int numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        if (!ContaBancaria.Cadastrada(numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        Console.WriteLine("Digite o valor do depósito (R$):");
//        string inputDeposito = Console.ReadLine();

//        if (!double.TryParse(inputDeposito, out double deposito))
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        if (deposito <= 0)
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        ContaBancaria.Depositar(numeroConta, deposito);

//        Console.WriteLine($"Depósito de R$ {deposito:F2} realizado com sucesso na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");
//    }

//    public static void RealizarSaque()
//    {
//        Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
//        string inputNumeroConta = Console.ReadLine();

//        if (inputNumeroConta.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputNumeroConta, out int numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        if (!ContaBancaria.Cadastrada(numeroConta))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        Console.WriteLine("Digite o valor do saque (R$):");
//        string inputSaque = Console.ReadLine();

//        if (!double.TryParse(inputSaque, out double saque))
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        if (saque <= 0)
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        bool saqueBemSucedido = ContaBancaria.Sacar(numeroConta, saque);

//        if (!saqueBemSucedido)
//        {
//            Console.WriteLine($"Saque de R$ {saque:F2} NÃO foi realizado devido a saldo insuficiente na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");

//            return;
//        }

//        Console.WriteLine($"Saque de R$ {saque:F2} realizado com sucesso na conta {numeroConta}! Saldo de {ContaBancaria.ObterSaldo(numeroConta)}.");
//    }

//    public static void RealizarTransferencia()
//    {
//        Console.WriteLine("\nDigite o número da conta originária (ou 'S' para sair):");
//        string inputNumeroContaOriginaria = Console.ReadLine();

//        if (inputNumeroContaOriginaria.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputNumeroContaOriginaria, out int numeroContaOriginaria))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        if (!ContaBancaria.Cadastrada(numeroContaOriginaria))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        Console.WriteLine("\nDigite o número da conta destinatária (ou 'S' para sair):");
//        string inputNumeroContaDestinataria = Console.ReadLine();

//        if (inputNumeroContaDestinataria.ToUpper() == "S")
//            return;

//        if (!int.TryParse(inputNumeroContaDestinataria, out int numeroContaDestinataria))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        if (!ContaBancaria.Cadastrada(numeroContaDestinataria))
//        {
//            Console.WriteLine("Conta não encontrada.");

//            return;
//        }

//        Console.WriteLine("Digite o valor da transferência (R$):");
//        string inputTransferencia = Console.ReadLine();

//        if (!double.TryParse(inputTransferencia, out double transferencia))
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        if (transferencia <= 0)
//        {
//            Console.WriteLine("Valor inválido.");

//            return;
//        }

//        bool saqueBemSucedido = ContaBancaria.Sacar(numeroContaOriginaria, transferencia);

//        if (!saqueBemSucedido)
//        {
//            Console.WriteLine($"Transferência de R$ {transferencia:F2} NÃO foi realizada devido a saldo insuficiente na conta originária {numeroContaOriginaria}! Saldo de {ContaBancaria.ObterSaldo(numeroContaOriginaria)}.");

//            return;
//        }

//        ContaBancaria.Depositar(numeroContaDestinataria, transferencia);

//        Console.WriteLine($"Transferência de R$ {transferencia:F2} realizada com sucesso da conta originária {numeroContaOriginaria} para a conta destinatária {numeroContaDestinataria}!");
//    }
//}

