namespace byteBank_Administracao.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionário
        // 1 - diretor
        // 2 - designer
        // N - ...
        // private int _tipo;

        private string nome;
        private string cpf;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; private set => cpf = value; }
        public double Salario { get => salario; protected set => salario = value; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
