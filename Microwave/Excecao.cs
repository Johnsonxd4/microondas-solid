using System;

namespace Microwave
{

    public class Excecao : IExcecao
    {

        private static IExcecao instance { get; set; }


        /// <summary>
        /// Instancia do tratador de Exceções
        /// </summary>
        public static IExcecao Instance
        {
            get
            {
                if (instance == null)
                    instance = new Excecao();
                return instance;
            }
        }


        public event OnLancado OnLancarHandler;


        public void ExcecaoDeArgumentos(string descricao)
        {
            if (OnLancarHandler == null)
                throw new ArgumentException(descricao);
            OnLancarHandler(descricao);
        }


        /// <summary>
        /// contrutor privado para o singleton da classe de tratamento de exceção
        /// </summary>
        private Excecao() { }
    }
}
