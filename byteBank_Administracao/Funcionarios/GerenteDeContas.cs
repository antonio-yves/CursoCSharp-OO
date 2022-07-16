using byteBank_Administracao.SistemaInterno;

namespace byteBank_Administracao.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, string usuario, string senha) : base(cpf, usuario, senha)
        {
            this.Salario = 4000;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
