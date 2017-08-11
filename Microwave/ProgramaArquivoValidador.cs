using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave
{
    class ProgramaArquivoValidador : ProgramaValidador
    {
        public override bool Validar(IProgramavel programa)
        {
            if (File.Exists(programa.Alimento))
                return true;
            return false;
        }
    }
}
