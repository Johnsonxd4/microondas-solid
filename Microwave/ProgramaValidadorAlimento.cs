namespace Microwave
{
    class ProgramaValidadorAlimento : ProgramaValidador
    {

        /// <summary>
        /// Verifica se o alimento foi informado ou é compativel
        /// </summary>
        /// <param name="programa"></param>
        public override bool Validar(IProgramavel programa)
        {

            if (string.IsNullOrWhiteSpace(programa.Alimento))
            {
                Excecao.Instance.ExcecaoDeArgumentos("Informe o Alimento");
                return false;
            }

            if (!programa.Alimento.ToUpper().Contains(programa.NomePrograma.ToUpper()))
            {
                Excecao.Instance.ExcecaoDeArgumentos("alimento incompatível com o programa");
                return false;
            }

            return true;
        }
    }
}
