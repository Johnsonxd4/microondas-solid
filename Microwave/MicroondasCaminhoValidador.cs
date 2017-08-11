using System.IO;

namespace Microwave
{
    class MicroondasCaminhoValidador : MicroondasValidador
    {
        public override bool Validar(IMicroondas validavel)
        {
            if (File.Exists(validavel.Alimento))
                return true;
            return false;
        }
    }
}
