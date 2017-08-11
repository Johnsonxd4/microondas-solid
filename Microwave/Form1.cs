using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Microwave
{
    public partial class FrmMicroondas : Form
    {
        Microondas microondas;

        public FrmMicroondas()
        {
            InitializeComponent();
            microondas = new Microondas();
            microondas.OnAquecida += new OnAquecida(Notificar_OnAquecida);
            Excecao.Instance.OnLancarHandler += Instance_OnLancarHandler;
        }

        private void Instance_OnLancarHandler(string descricao)
        {
            MessageBox.Show(descricao);
        }

        private void Notificar_OnAquecida(string aquecida)
        {
            MessageBox.Show(aquecida);
        }


        private void BtnAquecer_Click(object sender, EventArgs e)
        {

            microondas.Alimento = txtAlimento.Text;
            microondas.TempoCozimento = (int)TxtTempo.Value;
            microondas.Potencia = (int)TxtPotencia.Value;
            txtAlimento.Text = microondas.Aquecer();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            microondas = new Microondas();

        }


        private void BtnAquecimentoRapido_Click(object sender, EventArgs e)
        {

            microondas.Alimento = txtAlimento.Text;
            microondas.AquecimentoRapido();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

            dgvProgramas.Rows.Clear();
            List<IProgramavel> programas;

            if (string.IsNullOrWhiteSpace(TxtFiltro.Text))
                programas = microondas.Programas;
            else
                programas = microondas.Filtrar(TxtFiltro.Text);

            programas.ForEach(item =>
            {
                dgvProgramas.Rows.Add(
                    item.NomePrograma,
                    item.InstrucaoUso,
                    item.TempoCozimento,
                    item.Potencia
                        );
            });
        }

        private void BtnAquecerSelecionado_Click(object sender, EventArgs e)
        {

            string selecionado = "";
            foreach (DataGridViewRow item in dgvProgramas.Rows)
            {
                if (item.Selected)
                    selecionado = item.Cells[0].Value.ToString();

            }

            IProgramavel programa = microondas.Filtrar(selecionado).First();
            programa.Alimento = txtAlimento.Text;
            txtAlimento.Text = programa.Aquecer();
        }

        private void Microondas_OnAquecidoHandler(string alimento)
        {
            MessageBox.Show(alimento);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Programa programa = new Programa();
            programa.NomePrograma = txtNome.Text;
            programa.Caracter = txtCaracter.Text.ToCharArray().First();
            programa.InstrucaoUso = TxtInstrucoes.Text;
            programa.Potencia = int.Parse(txtPotenciaProgramacao.Text);
            programa.TempoCozimento = int.Parse(txtTempoProgramacao.Text);
            microondas.AdicionarPrograma(programa);
        }
    }
}
