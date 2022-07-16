using byteBank_Administracao.SistemaInterno;

namespace byteBank_Administracao.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private string _usuario;
        private string _senha;

        public FuncionarioAutenticavel(string cpf, string usuario, string senha):base(cpf)
        {
            this._usuario = usuario;
            this._senha = senha;
        }

        public bool Autenticar(string usuario, string senha)
        {
            return ((this._usuario == usuario) && (this._senha == senha));
        }
    }
}
