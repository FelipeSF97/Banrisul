using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_abstracao
{
    class Program
    {
        /*static void Main(string[] args)
        { 
            PixPessoaFisica pfPf = new PixPessoaFisica("123.456.789-00", "987.654.321-00", 150.0);
            Console.WriteLine(pfPf.Executar());
            pfPf.ImprimirComprovante();

            PixPessoaJuridica pjPj = new PixPessoaJuridica("12.345.678/0001-00", "98.765.432/0001-00", 500.0);
            Console.WriteLine(pjPj.Executar());
            pjPj.ImprimirComprovante();
            }
        }

        public abstract class Pix
        {
            protected string _idOriginador;
            protected string _idDestinatario;
            protected double _valor;

            public abstract string Executar();

            public void ImprimirComprovante()
            {
                Console.WriteLine($"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.");
            }
        }

        public class PixPessoaFisica : Pix
        {
            public PixPessoaFisica(string cpfOriginador, string cpfDestinatario, double valor)
            {
                _idOriginador = cpfOriginador;
                _idDestinatario = cpfDestinatario;
                _valor = valor;
            }

            public override string Executar()
            {
                if (!ValidadorCPF.IsValid(_idOriginador))
                    return "Originador inválido!";
                if (!ValidadorCPF.IsValid(_idDestinatario))
                    return "Destinatário inválido!";
                if (_valor <= 0)
                    return "Valor do pix deve ser positivo!";

                return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
            }
        }

        public class PixPessoaJuridica : Pix
        {
            public PixPessoaJuridica(string cnpjOriginador, string cnpjDestinatario, double valor)
            {
                _idOriginador = cnpjOriginador;
                _idDestinatario = cnpjDestinatario;
                _valor = valor;
            }

            public override string Executar()
            {
                if (!ValidadorCNPJ.IsValid(_idOriginador))
                    return "Originador inválido!";
                if (!ValidadorCNPJ.IsValid(_idDestinatario))
                    return "Destinatário inválido!";
                if (_valor <= 0)
                    return "Valor do pix deve ser positivo!";

                return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
            }
        }

        public class PixCPFParaCNPJ : Pix
        {
            public PixCPFParaCNPJ(string cpfOriginador, string cnpjDestinatario, double valor)
            {
            _idOriginador = cpfOriginador;
            _idDestinatario = cnpjDestinatario;
            _valor = valor;
            }

            public override string Executar()
            {
            if (!ValidadorCNPJ.IsValid(_idOriginador))
            {
                return "Originador inválido";
            }
            if (!ValidadorCNPJ.IsValid(_idDestinatario))
            {
                return "Destinador inválido";
            }
            if (_valor <= 0)
            {
                return "Valor do pix deve ser positivo!";
            }
            return $"Pix de R${_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";

            }
        }

        public class PixCNPJParaCPF : Pix
        {
        public PixCNPJParaCPF(string cnpjOriginador, string cpfDestinatario, double valor)
        {
            _idOriginador = cnpjOriginador;
            _idDestinatario = cpfDestinatario;
            _valor = valor;
        }

        public override string Executar()
        {
            if (!ValidadorCNPJ.IsValid(_idOriginador))
            {
                return "Originador inválido";
            }
            if (!ValidadorCNPJ.IsValid(_idDestinatario))
            {
                return "Destinador inválido";
            }
            if (_valor <= 0)
            {
                return "Valor do pix deve ser positivo!";
            }
            return $"Pix de R${_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";

            }
    }
        public class ValidadorCPF
        {
            public static bool IsValid(string cpf)
            {
                // Não é necessário implementar essa validação
                return true;
            }
        }

        public class ValidadorCNPJ
        {
            public static bool IsValid(string cnpj)
            {
                // Não é necessário implementar essa validação
                return true;
            }
        */

        /*static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(10.0, 5.0);
            Console.WriteLine(r1.CalcularArea());
            Console.WriteLine(r1.CalcularPerimetro());

            Quadrado q1 = new Quadrado(10.0);
            Console.WriteLine(q1.CalcularArea());
            Console.WriteLine(q1.CalcularPerimetro());

            Circulo c1 = new Circulo(10.0);
            Console.WriteLine(c1.CalcularArea());
            Console.WriteLine(c1.CalcularPerimetro());
        }
        public abstract class FormasGeometricas
        {
            protected double _area;
            protected double _perimetro;
            public abstract string CalcularArea();
            public abstract string CalcularPerimetro();

        }
        public class Retangulo : FormasGeometricas
        {
            protected double _base;
            protected double _altura;

            public Retangulo(double _base, double _altura)
            {
                this._base = _base;
                this._altura = _altura;
            }
            public override string CalcularArea()
            {
                _area = _base * _altura;
                return $"\nA área do retângulo é: {_area}";
            }
            public override string CalcularPerimetro()
            {
                _perimetro = 2 * (_base + _altura);
                return $"\nO perímetro do retênagulo é: {_perimetro}";
            }
        }
        public class Quadrado : FormasGeometricas
        {
            protected double _lado;
            public Quadrado(double _lado)
            {
                this._lado = _lado;
            }
            public override string CalcularArea()
            {
                _area = _lado * _lado;
                return $"\nA área do quadrado é: {_area}";
            }
            public override string CalcularPerimetro()
            {
                _perimetro = 2 * (_lado + _lado);
                return $"\nO perímetro do quadrado é: {_perimetro}";
            }
        }
        public class Circulo : FormasGeometricas
        {
            protected double _raio;

            public Circulo(double _raio)
            {
                this._raio = _raio;
            }
            public override string CalcularArea()
            {
                _area = Math.PI * (_raio * _raio);
                return $"\nA área do circulo é: {_area}";
            }
            public override string CalcularPerimetro()
            {
                _perimetro = 2 * Math.PI * _raio;
                return $"\nO perímetro do circulo é: {_perimetro}";
            }
        }*/
        static void Main(string[] args)
        {
            Email e = new Email();
            Console.WriteLine(e.EnviarMensagem("Pedido confirmado!\n"));
            SMS s = new SMS();
            Console.WriteLine(s.EnviarMensagem("Pedido confirmado!\n"));
            Push p = new Push();
            Console.WriteLine(p.EnviarMensagem("Pedido confirmado!\n"));
        }
        public interface INotificacoes
        {
            string EnviarMensagem(string mensagem);
        }
        public class Email : INotificacoes
        {
            public Email() { }
    
            public string EnviarMensagem(string mensagem)
            {
                return $"Enviando E-mail: {mensagem}";
            }
        }
        public class SMS : INotificacoes
        {
            public SMS() { }

            public string EnviarMensagem(string mensagem)
            {
                return $"Enviando sms: {mensagem}";
            }
        }
        public class Push : INotificacoes
        {
            public Push() { }

            public string EnviarMensagem(string mensagem)
            {
                return $"Enviando push: {mensagem}";
            }
        }
    }
}