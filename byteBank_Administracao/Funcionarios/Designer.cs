namespace byteBank_Administracao.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf)
        {
            this.Salario = 3000;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
    }
}
