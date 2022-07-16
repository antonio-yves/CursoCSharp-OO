using byteBank_Administracao.SistemaInterno;

namespace byteBank_Administracao.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, string usuario, string senha) : base(cpf, usuario, senha)
        {
            this.Salario = 5000;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
