using System.Collections.Generic;

namespace Microwave
{
    public delegate void OnAquecida(string aquecida);

    public class Microondas : IMicroondas, IValidavel, INotificadorAquecimento, IAquecedorString, IAquecedorArquivoTexto
    {

        /// <summary>
        /// Evento executado quando o aquecimento é finalizado
        /// </summary>
        public event OnAquecida OnAquecida;


        /// <summary>
        /// Potência utilizada para o cozimento
        /// </summary>
        public int Potencia { get; set; }


        /// <summary>
        /// Tempo de cozimento 
        /// </summary>
        public int TempoCozimento { get; set; }


        /// <summary>
        /// Caracter de aquecimento
        /// </summary>
        public char Caracter { get; set; }


        /// <summary>
        /// Alimento a ser aquecido
        /// </summary>
        public string Alimento { get; set; }


        private List<IProgramavel> programas { get; set; }


        public List<IProgramavel> Programas
        {
            get {
                if (programas == null)
                    programas = FabricaProgramas.CriarProgramas();
                return programas; ;
            }
        }


        public string Aquecer()
        {
            string retorno = "";
            MicroondasAquecimento microondas = new MicroondasAquecimento();
            retorno = IsArquivo() ? microondas.Aquecer((IAquecedorArquivoTexto)this) : microondas.Aquecer((IAquecedorString)this);

            if (OnAquecida != null)
                OnAquecida(this.Alimento);
            return retorno;
        }


        /// <summary>
        /// Verifica se o a string a ser aquecida é um caminho
        /// </summary>
        /// <returns></returns>
        private bool IsArquivo()
        {
            MicroondasCaminhoValidador validador = new MicroondasCaminhoValidador();
            return validador.Validar(this);
        }


        public bool IsValid()
        {
            List<MicroondasValidador> validador = new List<MicroondasValidador>();
            validador.Add(new MicroondasTempoValidador());
            validador.Add(new MicroondasPotenciaValidador());

            return validador.TrueForAll(x => x.Validar(this));
        }


        public Microondas()
        {
            Potencia = 10;
            Caracter = '.';
        }
    }
}
