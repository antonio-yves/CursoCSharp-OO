using byteBank_Administracao.Funcionarios;
using byteBank_Administracao.SistemaInterno;
using byteBank_Administracao.Utilitarios;

class Program
{
    static void Main(string[] agrs)
    {
        void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor paula = new Diretor("159.753.398-04", "paula", "0123");
            paula.Nome = "Paula";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("326.985.628-89", "camila", "1234");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao());
        }

        void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor paula = new Diretor("159.753.398-04", "paula", "0123");
            paula.Nome = "Paula";

            GerenteDeContas camila = new GerenteDeContas("326.985.628-89", "camila", "1234");
            camila.Nome = "Camila";

            sistema.Logar(paula, "paula", "0123");
            sistema.Logar(camila, "camilaa", "1234");
        }

        CalcularBonificacao();
        UsarSistema();
    }
}