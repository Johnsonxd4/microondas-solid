using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microwave;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace MicrowaveTest
{

    [TestClass]
    public class ProgramaTest
    {

        static IMicroondas microondas = new Microondas();
        static List<string> feedback = new List<string>();
        string retornoExcecao;
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            microondas = new Microondas();
        }
        public ProgramaTest()
        {
            microondas = new Microondas();
        }

        [TestMethod]
        public void Verificar_quantidade_programas_fornecidos_microondas()
        {
            Assert.AreEqual(5, microondas.Programas.Count);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "alimento incompatível com o programa")]
        public void Verifica_tipo_string_fornecida_compativel_programa()
        {
            string alimento = "frango";
            IProgramavel predefinido = microondas.Filtrar(alimento).First();
            predefinido.Alimento = "BATATA";

            predefinido.Aquecer();
        }


        [TestMethod]
        public void Disparar_metodo_aquecer_atravez_objeto_programa()
        {
            string alimento = "feijao";
            IProgramavel predefinido = microondas.Filtrar(alimento).First();
            predefinido.Alimento = alimento;
            string retornoEsperado = "feijao%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%aquecido";
            Assert.AreEqual(retornoEsperado, predefinido.Aquecer());
        }

        [TestMethod]
        public void Verificar_instrucoes_uso()
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(microondas.Programas.First().InstrucaoUso));
        }


        [TestMethod]
        public void Adicionar_novas_programacoes_microondas()
        {

            Programa programa = new Programa("programa teste", "teste para adicionar uma nova programacao microondasDigital");
            programa.Caracter = '&';
            programa.TempoCozimento = 10;
            programa.Potencia = 3;
            microondas.AdicionarPrograma(programa);
            Assert.AreEqual(6, microondas.Programas.Count);
        }


        [TestMethod]
        public void Verificar_evento_acionado_ao_Termino_aquecimento()
        {

            feedback.Clear();
            var programa = microondas.Filtrar("frango").First();

            programa.OnAquecida += new OnAquecida(TesteFeedBackAquecimento);
            programa.Alimento = "frango";
            programa.Aquecer();
            programa.Aquecer();

            Assert.AreEqual(2, feedback.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Informe o Alimento")]
        public void Verificar_se_as_excecoes_sao_lancadas_se_nao_possuir_evento_tratamento()
        {
            IProgramavel programa = microondas.Filtrar("Frango").First();
            programa.Aquecer();
        }

        [TestMethod]
        public void Verificar_se_nao_sao_lancadas_as_excecoes_se_houver_evento_tratamento()
        {
            Excecao.Instance.OnLancarHandler += Instance_OnLancarHandler;
            string retorno = microondas.Aquecer();
            string retornoEsperado = "O tempo de cozimento inválido. informe um valor entre 1 segundo e 2 minutos";
            Assert.AreEqual(retornoEsperado, retornoExcecao);
        }

        private void Instance_OnLancarHandler(string descricao)
        {
            retornoExcecao = descricao;
        }


        private void TesteFeedBackAquecimento(string aquecida)
        {
            feedback.Add(aquecida);
        }

        [TestMethod]
        public void Verificar_gravacao_arquivo_texto()
        {
            string caminho = @"D:\teste.txt";
            File.WriteAllText(caminho, "arroz");
            microondas.Alimento = caminho;

            microondas.TempoCozimento = 5;
            microondas.Potencia = 10;
            microondas.Aquecer();
            string alimento = File.ReadAllText(microondas.Alimento);
            Assert.IsTrue(alimento.ToCharArray().Where(x => x.Equals('.')).ToList().Count == microondas.TempoCozimento * microondas.Potencia && alimento.EndsWith("aquecido"));
        }

    }
}
