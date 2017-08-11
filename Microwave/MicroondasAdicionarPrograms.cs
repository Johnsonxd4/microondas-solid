namespace Microwave
{
    public static class MicroondasAdicionarPrograms
    {

        /// <summary>
        /// adiciona um programa customisavel
        /// </summary>
        /// <param name="microondas">objeto que o programa será adicionado</param>
        /// <param name="programa">programa a ser adicionado</param>
        public static void AdicionarPrograma(this IMicroondas microondas, IProgramavel programa)
        {
            if (programa.ValidarPrograma())
                microondas.Programas.Add(programa);
        }
    }
}
