using System;
using System.Globalization;

namespace Banco
{
    public class ProblemDepositary
    {
        private string _titular;
        public double Deposito { get; private set; }
        public int Conta { get; private set; }
        public string _tipoDeposito { get; private set; }

        public ProblemDepositary()
        {

        }


        public string Nome
        {
            get { return _titular; }
            set
            {
                if (value.Length >= 3 && value != null)
                {
                    _titular = value;
                }
            }
        }

        public double ValorTotalDeposito()
        {
            return Deposito;
        }

        public void CalculaValorDepostio(double deposito)
        {
            Deposito += deposito;
        }


        public void CalculaValorSaque(double deposito)
        {
            Deposito -= deposito;
        }

        public override string ToString()
        {
            return "Conta " + Conta + "Titular: " + _titular + ", Saldo: $" + Deposito;
        }
    }
}
