using byteBank.Titular;

namespace byteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private string _conta;
        private int _agencia;
        private string _nomeAgencia;
        private double _saldo;

        public double Saldo
        {
            get 
            { 
                return _saldo; 
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public bool Sacar(double valor)
        {
            if ((_saldo < valor) || (valor < 0))
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if ((_saldo < valor) || (valor < 0))
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                destino._saldo += valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + _titular.Nome);
            Console.WriteLine("Agência: " + _agencia);
            Console.WriteLine("Conta: " + _conta);
            Console.WriteLine("Nome da Agência: " + _nomeAgencia);
            Console.WriteLine("Saldo: R$ " + _saldo);
        }
    }
}