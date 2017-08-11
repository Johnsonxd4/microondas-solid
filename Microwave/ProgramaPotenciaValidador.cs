namespace Microwave
{
    class ProgramaPotenciaValidador : ProgramaValidador
    {

        /// <summary>
        /// Potencia maxima permitida de cozimento
        /// </summary>
        private const int PotenciaMaxima = 10;


        /// <summary>
        /// Potencia minima permitida de cozimento
        /// </summary>
        private const int PotenciaMinima = 1;


        /// <summary>
        /// Verifica se a potencia informada é valida
        /// </summary>
        /// <param name="programa"></param>
        public override bool Validar(IProgramavel programa)
        {
            if (programa.Potencia > PotenciaMaxima || programa.Potencia < PotenciaMinima)
            {
                Excecao.Instance.ExcecaoDeArgumentos($"A potencia deve ser no minimo {PotenciaMinima} e no maximo {PotenciaMaxima}");
                return false;
            }
            return true;

        }
    }
}

