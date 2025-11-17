using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Funcionario_com_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario felipe = new Funcionario("Felipe Flores", "855.328.940-11", "Desenvolvedor Pleno", 4000);
            Funcionario natan = new Funcionario("Natan Muller", "855.328.940-22", "Desenvolvedor Júnior", 2500);

            felipe.CalcularIR();
            felipe.CalcularINSS();
            felipe.AumentarSalario(10);
            felipe.ExibirContracheque();

            natan.CalcularIR();
            natan.CalcularINSS();
            natan.AumentarSalario(10);
            natan.ExibirContracheque();
        }
    }
    public class Funcionario
    {
        public string Nome {get; set; }
        public string CPF {get; }
        public string Cargo {get; set; }
        public decimal SalarioBruto {get; private set; }
        public decimal SalarioLiquido;
        public decimal PercentualAumento { get; private set; }

        public Funcionario(string Nome, string CPF, string Cargo, decimal SalarioBruto)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Cargo = Cargo;
            this.SalarioBruto = SalarioBruto;
            this.SalarioLiquido = SalarioBruto;
        }

        public void AumentarSalario(decimal Percentual)
        {
            if(Percentual > 0 && Percentual < 100)
            {
                PercentualAumento = Percentual;
                Percentual = Percentual / 100;
                decimal Aumento = SalarioLiquido * Percentual;
                SalarioLiquido += Aumento;
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
        public decimal CalcularINSS()
        {
            return SalarioLiquido * 0.08m;
        }

        public decimal CalcularIR()
        {
            if(SalarioBruto > 3000)
            {
                return SalarioLiquido * 0.15m;
            }
            else
            {
                return 0;
            }
            
        }

        public decimal GetSalarioLiquido()
        {
            return SalarioLiquido - CalcularIR() - CalcularINSS();
        }

        public void ExibirContracheque()
        {
            Console.WriteLine($"\nFuncionário: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Bruto: R${SalarioBruto}");
            Console.WriteLine($"Aumento de %{PercentualAumento}");
            Console.WriteLine($"Desconto INSS: R${CalcularINSS()}");
            Console.WriteLine($"Desconto IR: {CalcularIR()}");
            Console.WriteLine($"Salário Liquido: R${GetSalarioLiquido()}\n");
        }
    }
}
