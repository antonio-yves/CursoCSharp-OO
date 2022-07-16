namespace byteBank_Administracao.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string usuario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(usuario, senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine($"Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
