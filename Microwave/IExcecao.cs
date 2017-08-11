namespace Microwave
{
    public delegate void OnLancado(string descricao);

    public interface IExcecao
    {

        /// <summary>
        /// evento acionado quando uma excecao é lancada
        /// </summary>
        event OnLancado OnLancarHandler;


        /// <summary>
        /// Lança exceções do tipo ArgumentException
        /// </summary>
        /// <param name="descricao">descrição da exceção a ser lançada</param>
        void ExcecaoDeArgumentos(string descricao);

    }
}
