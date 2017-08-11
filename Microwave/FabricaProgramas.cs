using System.Collections.Generic;

namespace Microwave
{
    public static class FabricaProgramas
    {


        public static List<IProgramavel> CriarProgramas()
        {
            List<IProgramavel> programas = new List<IProgramavel>();

            Programa programa1 = new Programa("Pipoca", "Colocar a pipoca e aguardar o tempo");
            programa1.Potencia = 5;
            programa1.TempoCozimento = 3;
            programa1.Caracter = '!';
            programas.Add(programa1);


            Programa programa2 = new Programa("Frango", "Colocar o frango e aguardar o tempo");
            programa2.Potencia = 6;
            programa2.TempoCozimento = 8;
            programa2.Caracter = '@';
            programas.Add(programa2);


            Programa programa3 = new Programa("Batata", "Colocar a batata e aguardar o tempo");
            programa3.Potencia = 2;
            programa3.TempoCozimento = 3;
            programa3.Caracter = '#';
            programas.Add(programa3);


            Programa programa4 = new Programa("Arroz", "Colocar o arroz e aguardar o tempo");
            programa4.Potencia = 8;
            programa4.TempoCozimento = 8;
            programa4.Caracter = '$';
            programas.Add(programa4);


            Programa programa5 = new Programa("feijao", "Colocar o feijao e aguardar o tempo");
            programa5.Potencia = 9;
            programa5.TempoCozimento = 5;
            programa5.Caracter = '%';
            programas.Add(programa5);

            return programas;
        }
    }
}

