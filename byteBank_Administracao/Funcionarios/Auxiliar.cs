namespace byteBank_Administracao.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf)
        {
            this.Salario = 2000;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }
    }
}
