using byteBank_Administracao.Funcionarios;

namespace byteBank_Administracao.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string usuario, string senha);
    }
}
