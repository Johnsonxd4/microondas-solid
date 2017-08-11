using System.IO;

namespace Microwave
{
    public static class MicroondasEscritorArquivo
    {
        /// <summary>
        /// Escreve um conteudo em um arquivo
        /// </summary>
        /// <param name="caminho">arquivo a ser escrito</param>
        /// <param name="conteudo">conteudo a ser inserido</param>
        public static void Escrever(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
    }
}
