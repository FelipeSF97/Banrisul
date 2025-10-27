using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_desafio_sistema_bancario
{
    class Banco
    {   // Dicionário de clientes e suas contas
        // CPF → Nome
        static Dictionary<string, string> clientes = new Dictionary<string, string>();

         // CPF → Lista de contas
        static Dictionary<string, List<string>> contas = new Dictionary<string, List<string>>();

          //new Dictionary<string, Cliente>();
        static void Main(string[] args)
        {
            while (true)
            {
                Banco.mostrarMenu();

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                switch (opcao)
                {
                    case "1":
                        //criar cliente
                        break;
                    case "2":
                        //Criar Conta Bancária
                        break;
                    case "3":
                        //Depositar

                        break;
                    case "4":
                        //Sacar

                        break;
                    case "5":
                        //Criar uma nova conta bancária
                        break;
                    case "6":
                        //tranferir
                        break;
                    case "7":
                        //Consultar saldo
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
            Console.WriteLine("\nEncerrando o menu...");
        }
        public static void mostrarMenu()
        {
            Console.WriteLine("\n1 - Criar Cliente");
            Console.WriteLine("2 - Abrir Conta Bancária");
            Console.WriteLine("3 - Realizar Depósito");
            Console.WriteLine("4 - Realizar saque");
            Console.WriteLine("5 - Abrir Segunda Conta");
            Console.WriteLine("6 - Realizar Transferência");
            Console.WriteLine("7 - Consultar Saldo");
            Console.WriteLine("S - Sair");
        }
        //Responsável por gerenciar as operações de clientes e contas.
        //Banco deve permitir a criação de clientes e contas para clientes
        static void criarCliente()
        {
            
            Console.WriteLine("Digite o Nome Completo do cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            string cpfCliente = Console.ReadLine();

             if (!clientes.ContainsKey(cpfCliente))
            {
                clientes.Add(cpfCliente, nomeCliente);
                contas.Add(cpfCliente, new List<string>()); // cria lista de contas vazia para o cliente
                Console.WriteLine($"Cliente {nomeCliente} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente já cadastrado!");
            }
        }
        
        static void criarConta()
        {
            //int numContaCorrente = 1;
            //int numContaPoupanca = 1;
            Console.WriteLine("Digite o CPF do cliente.");
            string cpfCliente = Console.ReadLine();

            if (clientes.ContainsKey(cpfCliente))
            {
                Console.WriteLine("Digite o tipo de conta a ser criada\n(CORRENTE/POUPANÇA): ");
                string tipoConta = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite o número da conta: ");
                string numeroConta = Console.ReadLine();
                
                contas[cpfCliente].Add($"{numeroConta} ({tipoConta})");
                Console.WriteLine($"Conta {tipoConta} criada com sucesso! Número: {numeroConta}");
            }   
                // if (conta == "corrente")
                // {
                //     Console.WriteLine("Você está criando CONTA CORRENTE.");
                //     numContaCorrente++;
                // }
                // else if (conta == "POUPANÇA")
                // {
                //     Console.WriteLine("Você está criando uma CONTA POUPANÇA.");
                //     numContaPoupanca++;
                // }
                // else
                // {
                //     Console.WriteLine("Cliente não cadastrado!");
                // }
            
            else
            {
                Console.WriteLine("CPF inválido!");
            }
            
            
        }

        //Banco deve permitir a listagem de clientes e suas respectivas contas;
        static void listarCliente()
        {
            Console.WriteLine("\nLista de clientes:\n");
            if(clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }
            //var cpfClientes = new List<string>(Cliente.clientes.Count);
            List<string> cpfs = new List<string>(clientes.Keys);
            //List<string> nomes = new List<string>(Cliente.clien  tes.Values);
            //for (int i = 0; i < Cliente.clientes.Count; i++)
            for (int i = 0; i < cpfs.Count; i++)
            {
                //string nome = nomes[i];
                string cpf = cpfs[i];
                Console.WriteLine($"\nCliente: {clientes[cpf]} | CPF: {cpf}");
                if (!contas.ContainsKey(cpf) || contas[cpf].Count == 0)
                {
                    Console.WriteLine("  - Nenhuma conta cadastrada.");
                }else
                {
                    List<string> listaContas = contas[cpf];

                    for (int j = 0; j < listaContas.Count; j++)
                    {
                        string conta = listaContas[j];
                        Console.WriteLine($"  - Conta: {conta}");
                    }
                }
            }
        }

        static void consultarSaldo()
        {

        }

        //Banco deve permitir que um Cliente possa depositar um valor positivo em uma ContaBancaria
        static void depositar()
        {

        }

        //Banco deve permitir que um Cliente possa sacar um valor que não seja maior que o saldo disponível de uma ContaBancaria
        static void sacar()
        {

        }

        //Banco deve permitir que um Cliente possa transferir um valor que não seja maior que o saldo disponível de uma ContaBancaria de origem, para uma ContaBancaria de destino. Essa conta pode ser
        //Uma outra ContaBancaria sua;
        //Uma ContaBancaria de outro Cliente.
        static void transferir()
        {

        }

        
    }

    class Cliente
    {
        //Contém informações do cliente, como nome, CPF, e uma lista de contas associadas;
        public static Dictionary<string, string> clientes;
        static Dictionary<int, Cliente> contas;
        static Dictionary<string, contaBancaria> ContaBancaria = new Dictionary<string, contaBancaria>();
    }
    class contaBancaria
    {
        //Representa uma conta bancária, com informações como número da conta, tipo ("Corrente" ou "Poupança") e saldo;
        public static Dictionary<string, int> Contas;

    }
}

/*using System;
using System.Collections.Generic;

class Biblioteca
{
    static Dictionary<int, string> obras;
    static Dictionary<int, string> leitores;
    static int TotalObrasEmEmprestimo;
    static Dictionary<int, int> quantidades;
    static Dictionary<int, string> autores;

    static void Main()
    {
        Console.WriteLine("Iniciando a biblioteca...");

        obras = new Dictionary<int, string>();
        autores = new Dictionary<int, string>();
        quantidades = new Dictionary<int, int>();

        leitores = new Dictionary<int, string>();
        int idLeitor = 1;

        TotalObrasEmEmprestimo = 0;

        CadastrarObras();

        while (true)
        {
            Console.WriteLine($"\nDigite o nome do leitor {idLeitor} (ou 'S' para sair do cadastro de leitores):");
            string inputNome = Console.ReadLine();

            if (inputNome.ToUpper() == "S")
                break;

            leitores.Add(idLeitor, inputNome);

            idLeitor++;
        }

        if (obras.Count == 0 || leitores.Count == 0)
        {
            Console.WriteLine("\nEncerrando a biblioteca por falta de obras ou leitores cadastrados...");

            return;
        }

        while (true)
        {
            ImprimirMenu();
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
                break;

            switch (opcao)
            {
                case "1":
                    {
                        EmprestarObra();
                        break;
                    }
                case "2":
                    {
                        DevolverObra();
                        break;
                    }
                case "3":
                    {
                        ListarObras();
                        break;
                    }
                case "4":
                    {
                        ListarLeitores();
                        break;
                    }
                case "5":
                    {
                        MostrarEstatisticas();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nOpção inválida.");
                        break;
                    }
            }
        }

        Console.WriteLine("\nEncerrando a biblioteca...");
    }
    static void EmprestarObra()
    {
        Console.Write("\nDigite o ID da obra a emprestar: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out idObra))
        {
            Console.WriteLine("Obra inválida.");

            break;
        }

        if (!obras.ContainsKey(idObra))
        {
            Console.WriteLine("Obra não encontrada.");

            break;
        }

        if (quantidades[idObra] <= 0)
        {
            Console.WriteLine("Obra indisponível no momento.");

            break;
        }

        Console.Write("Digite o ID do leitor: ");
        string inputIdLeitor = Console.ReadLine();

        if (!int.TryParse(inputIdLeitor, out idLeitor))
        {
            Console.WriteLine("Leitor inválido.");

            break;
        }

        if (!leitores.ContainsKey(idLeitor))
        {
            Console.WriteLine("Leitor não encontrado.");

            break;
        }

        quantidades[idObra]--;

        Console.WriteLine($"{leitores[idLeitor]} pegou emprestada a obra '{obras[idObra]}'.");

        TotalObrasEmEmprestimo++;
    }

    static void DevolverObra()
    {
        Console.Write("\nDigite o ID da obra a devolver: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out idObra))
        {
            Console.WriteLine("Obra inválida.");

            break;
        }

        if (!obras.ContainsKey(idObra))
        {
            Console.WriteLine("Obra não encontrada.");

            break;
        }

        quantidades[idObra]++;

        Console.WriteLine($"Obra '{obras[idObra]}' devolvida.");

        TotalObrasEmEmprestimo--;
    }

    static void ListarObras()
    {
        Console.WriteLine("\nLista de obras:");
        var idsObras = new List<int>(obras.Keys);
        for (int i = 0; i < idsObras.Count; i++)
        {
            int id = idsObras[i];

            Console.WriteLine($"Obra: ({id}) {obras[id]} - Autor: {autores[id]} - Quantidade: {quantidades[id]} unidade(s)");
        }
    }

    static void ListarLeitores()
    {
        Console.WriteLine("\nLista de leitores:");

        var idsLeitores = new List<int>(leitores.Keys);
        for (int i = 0; i < idsLeitores.Count; i++)
        {
            int id = idsLeitores[i];

            Console.WriteLine($"Leitor: ({id}) {leitores[id]}");
        }
    }

    static void MostrarEstatisticas()
    {
        Console.WriteLine("\nEstatísticas:");

        int totalObrasDisponiveis = 0;

        var idsObras = new List<int>(obras.Keys);
        for (int i = 0; i < idsObras.Count; i++)
        {
            int id = idsObras[i];

            totalObrasDisponiveis += quantidades[id];
        }

        Console.WriteLine($"Total de obras disponíveis: {totalObrasDisponiveis}");
        Console.WriteLine($"Total de obras em empréstimo: {TotalObrasEmEmprestimo}");
    }

    static void ImprimirMenu()
    {
        Console.WriteLine("\n1 - Emprestar obra");
        Console.WriteLine("2 - Devolver obra");
        Console.WriteLine("3 - Listar obras");
        Console.WriteLine("4 - Listar leitores");
        Console.WriteLine("5 - Estatísticas");
        Console.WriteLine("S - Sair");
        Console.Write("Selecione a ação: ");
    }
    
    static void CadastrarObras()
    {
        int idObra = 1;
        while (true)
        {
            Console.WriteLine($"\nDigite o título da obra {idObra} (ou 'S' para sair do cadastro de obras):");
            string inputTitulo = Console.ReadLine();

            if (inputTitulo.ToUpper() == "S")
                break;

            obras.Add(idObra, inputTitulo);

            Console.WriteLine($"Digite o nome do autor da obra '{inputTitulo}':");

            autores.Add(idObra, Console.ReadLine());

            Console.WriteLine($"Digite a quantidade inicial disponível da obra '{inputTitulo}':");
            string inputQuantidade = Console.ReadLine();

            if (!int.TryParse(inputQuantidade, out int quantidade))
                quantidade = 0; // valor padrão caso não seja informada uma quantidade válida

            quantidades.Add(idObra, quantidade);

            idObra++;
        }
    }
}
 
*/