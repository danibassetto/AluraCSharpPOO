using bytebank.Exceções;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return this.numero_agencia;
            }
            private set
            {
                if (value > 0)
                    this.numero_agencia = value;
            }
        } // propriedade implementada com condição

        public string Conta { get; set; } // propriedade autoimplementada

        private string nome_agencia;
        public string Nome_agencia
        {
            get
            {
                return this.nome_agencia;
            }
            private set
            {
                this.nome_agencia = value;
            }
        }
        private double saldo = 100; // utiliza método público

        public Cliente Titular { get; set; } // propriedade autoimplementada

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;
        } 

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;

            if(numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero.", nameof(numero_agencia));
            }
            //try
            //{
            //    TaxaOperacao = 30 / TotalDeContasCriadas;
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Não é possível dividir por zero.");
            //}
            
            TotalDeContasCriadas++;
        }

        public void Deposito(double valor)
        {
            saldo += valor;
        }

        public bool Saque(double valor)
        {

            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
                throw new SaldoInsuficienteException("Saldo insuficiente para a operação.");
        }

        public bool Transferencia(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            else
            {
                // this.saldo -= valor; >> note que é o mesma operação que o método saque realiza
                //destino.saldo += valor; >> note que é a mesma operação que o depósito realiza
                Saque(valor);
                destino.Deposito(valor);
                return true;
            }
        }

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
                return;
            else
                this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}