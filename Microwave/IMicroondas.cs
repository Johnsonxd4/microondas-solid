using System.Collections.Generic;

namespace Microwave
{
    public interface IMicroondas : IAquecedor
    {
        /// <summary>
        /// Programas aquecimento pré definidos
        /// </summary>
        List<IProgramavel> Programas { get; }
    }
}
