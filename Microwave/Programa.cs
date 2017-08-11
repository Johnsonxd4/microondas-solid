using System.Collections.Generic;

namespace Microwave
{
    public class Programa : IProgramavel, IValidavel, INotificadorAquecimento, IAquecedorString, IAquecedorArquivoTexto
    {

        /// <summary>
        /// nome do programa pré definido
        /// </summary>
        public string NomePrograma { get; set; }


        /// <summary>
        /// instruções de uso do programa pré definido
        /// </summary>
        public string InstrucaoUso { get; set; }


        /// <summary>
        /// Potencia Programada
        /// </summary>
        public int Potencia { get; set; }


        /// <summary>
        /// Tempo Cozimento Programado
        /// </summary>
        public int TempoCozimento { get; set; }


        /// <summary>
        /// Caracter de aquecimento
        /// </summary>
        public char Caracter { get; set; }


        public string Alimento { get; set; }


        public Programa() { }


        public Programa(string NomePrograma, string InstrucaoUso)
        {
            this.NomePrograma = NomePrograma;
            this.InstrucaoUso = InstrucaoUso;
        }

        public event OnAquecida OnAquecida;


        /// <summary>
        /// Realiza as validações necessárias no programa
        /// </summary>
        public bool IsValid()
        {
            List<ProgramaValidador> validador = new List<ProgramaValidador>();

            validador.Add(new ProgramaValidadorAlimento());
            validador.Add(new ProgramaTempoValidador());
            validador.Add(new ProgramaPotenciaValidador());

            return validador.TrueForAll(x => x.Validar(this));
        }


        /// <summary>
        /// Verifica se o objeto possui as inforções necessárias para ser considerado um programa
        /// </summary>
        /// <returns></returns>
        public bool ValidarPrograma()
        {
            List<ProgramaValidador> validador = new List<ProgramaValidador>();

            validador.Add(new ProgramaTempoValidador());
            validador.Add(new ProgramaPotenciaValidador());
            validador.Add(new ProgramaValidadorNome());

            return validador.TrueForAll(x => x.Validar(this));
        }


        /// <summary>
        /// Verifica se a string informada é compativel com o programa
        /// </summary>
        public virtual void Compativel()
        {
            List<ProgramaValidador> validador = new List<ProgramaValidador>();

            validador.Add(new ProgramaValidadorAlimento());
            validador.ForEach(x => x.Validar(this));
        }


        private bool IsArquivo()
        {
            List<ProgramaValidador> validador = new List<ProgramaValidador>();
            validador.Add(new ProgramaArquivoValidador());
            return validador.TrueForAll(x => x.Validar(this));

        }

        public string Aquecer()
        {
            string retorno = "";
            MicroondasAquecimento microondas = new MicroondasAquecimento();
            if (IsArquivo())
            {
                retorno = microondas.Aquecer((IAquecedorArquivoTexto)this);
            }
            else
            {
                retorno = microondas.Aquecer((IAquecedorString)this);
            }
                
            if (OnAquecida != null)
                OnAquecida(this.Alimento);
            return retorno;
        }
    }
}
