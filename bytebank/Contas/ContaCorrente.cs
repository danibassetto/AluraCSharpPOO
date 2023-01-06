using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_angencia
        {
            get
            {
                return this.numero_agencia;
            }
            set
            {
                if (value > 0)
                    this.numero_agencia = value;
            }
        } // propriedade implementada com condição
        public string Conta { get; set; } // propriedade autoimplementada

        private double saldo; // utiliza método público
        public Cliente Titular { get; set; } // propriedade autoimplementada

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
                return false;
        }

        public bool Transferencia(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
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