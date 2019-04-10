using System;
using System.Globalization;

namespace Banco
{
    public class ContaBancaria
    {
        public int Numero { get; private set; } //nao pode ser alterado
        public string Titular { get; set; }
        public double Saldo { get; private set; } //so pode ser alterado por deposito ou saque

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0; // ou Saldo -= quantia; Saldo -= 5.0
        }

        public override string ToString()
        {
            return 
                "Conta " + Numero + 
                ", Titular: " + Titular + 
                ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
