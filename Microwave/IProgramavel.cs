namespace Microwave
{
    public interface IProgramavel : IAquecedor
    {

        /// <summary>
        /// nome do programa pré definido
        /// </summary>
        string NomePrograma { get; set; }


        /// <summary>
        /// instruções de uso do programa
        /// </summary>
        string InstrucaoUso { get; set; }


        /// <summary>
        /// Verificar se o programa é compativel
        /// </summary>
        void Compativel();


        /// <summary>
        /// Verifica se o Programa satisfaz os requisitos minimos
        /// </summary>
        /// <returns></returns>
        bool ValidarPrograma();
    }
}
