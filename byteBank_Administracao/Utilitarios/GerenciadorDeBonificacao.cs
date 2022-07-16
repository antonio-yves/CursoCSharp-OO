using byteBank_Administracao.Funcionarios;

namespace byteBank_Administracao.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao()
        {
            return this._totalBonificacao;
        }
    }
}
