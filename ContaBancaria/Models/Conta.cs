using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria.Models
{
    internal class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; private set; } //AEEEEEEEEE
        public double Saldo { get; private set; }

        public Conta(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "\nDados da Conta:\nConta: " + NumConta + " , Titular: " + Nome + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
