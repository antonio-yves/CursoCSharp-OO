namespace byteBank.Titular
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _profissao;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("O nome do cliente deve ter mais de três caracteres...");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length < 11)
                {
                    Console.WriteLine("O CPF informado não é válido...");
                }
                else
                {
                    _cpf = value;
                }
            }
        }

        public string Profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }
    }
}
