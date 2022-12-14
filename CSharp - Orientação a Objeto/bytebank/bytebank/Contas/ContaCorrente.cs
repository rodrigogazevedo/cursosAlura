using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set { 
                    if (value > 0)
                    {
                        this.numero_agencia = value; 
                    }
                }
        }
      
        public string Conta
        {
            get; set;
        }
        private double saldo = 0;
        //public string nome_agencia;
        //private double saldo = 100;
        //public double saldo;

        public Cliente Titular { get; set; }

        //public ContaCorrente(int numero_agencia, string conta, string titular, string nome_agencia, double saldo)
        //{
        //    this.numero_agencia = numero_agencia;
        //    this.conta = conta;
        //    this.titular = titular;
        //    this.nome_agencia = nome_agencia;
        //    this.saldo = saldo;  
        //}

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo + valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        public ContaCorrente(Cliente Titular, int numero_agencia, string conta)
        {
            Titular = Titular;
            Numero_agencia = numero_agencia;
            Conta = conta;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + Titular);
            //Console.WriteLine("Conta: " + nome_agencia);
            Console.WriteLine("Número Agência: " + numero_agencia);
            //Console.WriteLine("Conta: " + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}
