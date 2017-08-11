namespace Microwave
{
    public static class MicroondasAquecimentoRapido
    {
        /// <summary>
        /// Tempo padrao para o aquecimento rapido
        /// </summary>
        private const int Tempo = 30;


        /// <summary>
        /// Potencia padrão para o aquecimento rapido
        /// </summary>
        private const int Potencia = 8;


        /// <summary>
        /// Aquecimento rápido com tempo e potencia pré definidos
        /// </summary>
        /// <param name="microondas"></param>
        /// <returns>retorna a string "aquecida"</returns>
        public static string AquecimentoRapido(this IMicroondas microondas)
        {
            microondas.TempoCozimento = Tempo;
            microondas.Potencia = Potencia;
            return microondas.Aquecer();
        }
    }
}
