namespace Microwave
{
    class ProgramaTempoValidador : ProgramaValidador
    {
        /// <summary>
        /// tempo máximo de cozimento permitido
        /// </summary>
        private const int TempoMaximoCozimento = 120;


        /// <summary>
        /// tempo minimo de cozimento permitido
        /// </summary>
        private const int TempoMinimoCozimento = 1;


        /// <summary>
        /// Verifica se o tempo informado é valido
        /// </summary>
        /// <param name="programa"></param>
        public override bool Validar(IProgramavel programa)
        {
            if (programa.TempoCozimento < TempoMinimoCozimento || programa.TempoCozimento > TempoMaximoCozimento)
            {
                Excecao.Instance.ExcecaoDeArgumentos("O tempo de cozimento inválido. informe um valor entre 1 segundo e 2 minutos");
                return false;
            }
            return true;

        }
    }
}
