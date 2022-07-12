namespace byteBank
{
    public class ContaCorrente
    {
        public string Titular;
        public string Conta;
        public int Agencia;
        public string NomeAgencia;
        public double Saldo;

        public bool Sacar(double valor)
        {
            if ((Saldo < valor) || (valor < 0))
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if ((Saldo < valor) || (valor < 0))
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Agência: " + Agencia);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Nome da Agência: " + NomeAgencia);
            Console.WriteLine("Saldo: R$ " + Saldo);
        }
    }
}