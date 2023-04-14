using ContaBancaria.Models;
using System;

namespace ContaBancaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double valor;

            //Console.Write("Bom dia!\nDigite o número da conta: ");
            int numCon = rnd.Next(0,100);

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Conta c = new Conta(numCon,nome);
            Console.WriteLine(c);

            Console.WriteLine("Deseja fazer um depósito inicial? (S/N)");
            string opcao = Console.ReadLine().ToUpper();

            //Duas variaveis não podem ter o mesmo nome, mesmo que sejam de outro escolpo
            if (opcao.Equals("S"))
            {
                Console.Write("Digite o valor do depósito: ");
                c.Depositar(double.Parse(Console.ReadLine()));
                Console.WriteLine(c);
            }

            Console.Write("Entre com um valor para o depósito: ");
            c.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);

            Console.Write("Entre um valor para o saque: ");
            c.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(c);
        }
    }
}