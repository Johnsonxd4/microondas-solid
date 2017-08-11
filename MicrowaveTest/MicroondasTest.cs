using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microwave;
using System.Linq;

namespace MicrowaveTest
{

    [TestClass]
    public class MicroondasTest
    {
        static IMicroondas microondas;
        

        public MicroondasTest()
        {
            MyClassCleanup();
        }


        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            microondas = new Microondas();      
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Informe o tempo de cozimento")]
        public void Verifica_se_o_tempo_foi_informado()
        {
            microondas.Alimento = "Frango";
            microondas.Aquecer();

        }


        [TestMethod]
        public void Verifica_potencia_padrao_microondas()
        {
            Assert.AreEqual(10, microondas.Potencia);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A potencia deve ser no minimo 1 e no maximo 10")]
        public void Verifica_valor_maximo_Potencia_permitida()
        {
            microondas.Potencia = 11;
            microondas.Aquecer();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A potencia deve ser no minimo 1 e no maximo 10")]
        public void Verifica_valor_minimo_Potencia_permitida()
        {
            microondas.Potencia = 0;
            microondas.Aquecer();
        }


        [TestMethod]
        public void Verificar_Atrubuicao_potencia_dentro_valor_permitido()
        {
            microondas.Potencia = 5;
            microondas.Alimento= "Frango";
            Assert.AreEqual(5, microondas.Potencia);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "O tempo informado é inválido. informe um valor entre 1 segundo e 2 minutos")]
        public void Verificar_tempo_maximo_cozimento_microondas()
        {
            microondas.TempoCozimento = 121;
            microondas.Aquecer();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "O tempo informado é inválido. informe um valor entre 1 segundo e 2 minutos")]
        public void Verificar_tempo_minimo_cozimento_microondas()
        {
            microondas.TempoCozimento = 0;
            microondas.Aquecer();
        }


        [TestMethod]
        public void Verificar_tempo_valido_cozimento()
        {
            microondas.TempoCozimento = 18;
            microondas.Alimento = "alimento QUalquer";
            Assert.AreEqual(18, microondas.TempoCozimento);
            microondas.Aquecer();
        }


        [TestMethod]
        public void Verificar_string_retorno_aquecer()
        {
            string alimento = "frango";
            microondas.Alimento = alimento;
            int potencia = 6;
            int tempo = 4;
            microondas.Potencia = potencia;
            microondas.TempoCozimento = tempo;
            string retorno = microondas.Aquecer();

            Assert.IsTrue(
                retorno.Contains(alimento) &&

                retorno.Contains("aquecido") &&

                retorno
                .ToCharArray()
                .ToList()
                .Where(x => x.Equals(microondas.Caracter)).Count() == (potencia * tempo));
        }

    }
}