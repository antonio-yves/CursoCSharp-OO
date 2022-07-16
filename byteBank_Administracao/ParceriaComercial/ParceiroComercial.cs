using byteBank_Administracao.SistemaInterno;

namespace byteBank_Administracao.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        private string _usuario;
        private string _senha;
        
        public ParceiroComercial(string usuario, string senha)
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
