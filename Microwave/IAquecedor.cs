namespace Microwave
{
    public interface IAquecedor
    {

        string Alimento { get; set; }

        /// <summary>
        /// Potência utilizada para o cozimento
        /// </summary>
        int Potencia { get; set; }


        /// <summary>
        /// Tempo de cozimento 
        /// </summary>
        int TempoCozimento { get; set; }


        /// <summary>
        /// Caracter de aquecimento
        /// </summary>
        char Caracter { get; set; }


        /// <summary>
        /// Verificar se o Aquecedor é valido
        /// </summary>
        bool IsValid();

        /// <summary>
        /// "Aquecer a string informada"
        /// </summary>
        /// <returns>a string "aquecida"</returns>
        string Aquecer();


        /// <summary>
        /// Evento de notificação quando a string estiver "Aquecida"
        /// </summary>
        event OnAquecida OnAquecida;
    }
}
