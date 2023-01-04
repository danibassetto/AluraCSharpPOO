namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Deposito(double valor)
        {
            this.saldo += valor;
        }

        public bool Saque(double valor)
        {

            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
                return false;
        }

        public bool Transferencia(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                // this.saldo -= valor; >> note que é o mesma operação que o método saque realiza
                //destino.saldo += valor; >> note que é a mesma operação que o depósito realiza
                this.Saque(valor);
                destino.Deposito(valor);
                return true;
            }
        }
    }
}