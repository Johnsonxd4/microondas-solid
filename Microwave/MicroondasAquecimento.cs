using System.Threading;

namespace Microwave
{

    public  class MicroondasAquecimento
    {
        /// <summary>
        /// Aquece a string informada ao aquecedor
        /// </summary>
        /// <param name="microondas"></param>
        /// <returns>a string "aquecida"</returns>
        public virtual string Aquecer(IAquecedorString microondas)
        {
            if (!microondas.IsValid())
                return microondas.Alimento;

            string pontos = new string(microondas.Caracter, microondas.Potencia);
            var tempo = microondas.TempoCozimento;

            while (tempo > 0)
            {
                Thread.Sleep(1000);
                microondas.Alimento += pontos;

                tempo--;
            }
            microondas.Alimento += "aquecido";
            return microondas.Alimento;
        }


        /// <summary>
        /// Aquece o arquivo texto informado
        /// </summary>
        /// <param name="microondas"></param>
        /// <returns>a string "aquecida"</returns>
        public virtual string Aquecer(IAquecedorArquivoTexto microondas)
        {
            if (!microondas.IsValid())
                return "";

            string pontos = new string(microondas.Caracter, microondas.Potencia);
            var tempo = microondas.TempoCozimento;

            while (tempo > 0)
            {
                Thread.Sleep(1000);
                MicroondasEscritorArquivo.Escrever(microondas.Alimento, pontos);

                tempo--;
            }

            MicroondasEscritorArquivo.Escrever(microondas.Alimento, "aquecido");
            return "";
        }
    }
}
