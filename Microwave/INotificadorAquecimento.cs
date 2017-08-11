namespace Microwave
{
    public interface INotificadorAquecimento
    {
        /// <summary>
        /// Evento executado ao termino do aquecimento
        /// </summary>
        event OnAquecida OnAquecida;
    }
}
