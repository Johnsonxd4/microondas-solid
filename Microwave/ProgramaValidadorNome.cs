namespace Microwave
{
    class ProgramaValidadorNome : ProgramaValidador
    {

        public override bool Validar(IProgramavel programa)
        {
            if (string.IsNullOrWhiteSpace(programa.NomePrograma))
            {
                Excecao.Instance.ExcecaoDeArgumentos("Informe o nome do programa");
                return false;
            }
            return true;
        }
    }
}
