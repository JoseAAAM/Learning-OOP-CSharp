using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente();


            // gabriela.nome = "Gabriela";
            // gabriela.profissao = "Desenvolvedora C#";
            // gabriela.CPF = "434.562.878-20";

            ContaCorrente Conta = new ContaCorrente();

            // Conta.titular = gabriela;
            Conta.titular = new Cliente();
            Conta.titular.nome = "Gabriela Costa";
            Conta.titular.CPF = "434.562.878-20";
            Conta.titular.profissao = "Desenvolvedora C#";


            Conta.saldo = 500;
            Conta.agencia = 563;
            Conta.numero = 5634527;

            // Console.WriteLine(gabriela.nome);
            Console.WriteLine(Conta.titular.nome);
            Console.WriteLine(Conta.titular.CPF);
            Console.WriteLine(Conta.titular.profissao);



            Console.ReadLine();
        }
    }
}
