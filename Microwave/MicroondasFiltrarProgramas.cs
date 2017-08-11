using System.Collections.Generic;
using System.Linq;

namespace Microwave
{
    public static class MicroondasFiltrarProgramas
    {
        /// <summary>
        /// retorna o programa compativel com a string fornecida
        /// </summary>
        /// <param name="microondas"></param>
        /// <param name="filtro">parametro para o filtro</param>
        /// <returns></returns>
        public static List<IProgramavel> Filtrar(this IMicroondas microondas, string filtro)
        {
            return microondas.Programas.Where(x => x.NomePrograma.ToUpper().Contains(filtro.ToUpper())).ToList();
        }
    }
}
