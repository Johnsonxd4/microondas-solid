namespace Microwave {
    partial class FrmMicroondas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAquecer = new System.Windows.Forms.Button();
            this.BtnAquecimentoRapido = new System.Windows.Forms.Button();
            this.TxtTempo = new System.Windows.Forms.NumericUpDown();
            this.TxtPotencia = new System.Windows.Forms.NumericUpDown();
            this.dgvProgramas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrucoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnAquecerSelecionado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtInstrucoes = new System.Windows.Forms.TextBox();
            this.txtTempoProgramacao = new System.Windows.Forms.TextBox();
            this.txtPotenciaProgramacao = new System.Windows.Forms.TextBox();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(12, 34);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(646, 20);
            this.txtAlimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Potencia";
            // 
            // BtnAquecer
            // 
            this.BtnAquecer.Location = new System.Drawing.Point(397, 71);
            this.BtnAquecer.Name = "BtnAquecer";
            this.BtnAquecer.Size = new System.Drawing.Size(122, 23);
            this.BtnAquecer.TabIndex = 6;
            this.BtnAquecer.Text = "Aquecer";
            this.BtnAquecer.UseVisualStyleBackColor = true;
            this.BtnAquecer.Click += new System.EventHandler(this.BtnAquecer_Click);
            // 
            // BtnAquecimentoRapido
            // 
            this.BtnAquecimentoRapido.Location = new System.Drawing.Point(536, 71);
            this.BtnAquecimentoRapido.Name = "BtnAquecimentoRapido";
            this.BtnAquecimentoRapido.Size = new System.Drawing.Size(122, 23);
            this.BtnAquecimentoRapido.TabIndex = 7;
            this.BtnAquecimentoRapido.Text = "Aquecimento Rapido";
            this.BtnAquecimentoRapido.UseVisualStyleBackColor = true;
            this.BtnAquecimentoRapido.Click += new System.EventHandler(this.BtnAquecimentoRapido_Click);
            // 
            // TxtTempo
            // 
            this.TxtTempo.Location = new System.Drawing.Point(58, 73);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(102, 20);
            this.TxtTempo.TabIndex = 8;
            // 
            // TxtPotencia
            // 
            this.TxtPotencia.Location = new System.Drawing.Point(230, 73);
            this.TxtPotencia.Name = "TxtPotencia";
            this.TxtPotencia.Size = new System.Drawing.Size(102, 20);
            this.TxtPotencia.TabIndex = 9;
            // 
            // dgvProgramas
            // 
            this.dgvProgramas.AllowUserToAddRows = false;
            this.dgvProgramas.AllowUserToDeleteRows = false;
            this.dgvProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.instrucoes,
            this.Tempo,
            this.Potencia});
            this.dgvProgramas.Location = new System.Drawing.Point(12, 174);
            this.dgvProgramas.Name = "dgvProgramas";
            this.dgvProgramas.ReadOnly = true;
            this.dgvProgramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgramas.Size = new System.Drawing.Size(646, 150);
            this.dgvProgramas.TabIndex = 10;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // instrucoes
            // 
            this.instrucoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instrucoes.HeaderText = "Instruções";
            this.instrucoes.Name = "instrucoes";
            this.instrucoes.ReadOnly = true;
            // 
            // Tempo
            // 
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.HeaderText = "Potência";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(12, 138);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(148, 20);
            this.TxtFiltro.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filtrar programas por nome";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(181, 136);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 13;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnAquecerSelecionado
            // 
            this.BtnAquecerSelecionado.Location = new System.Drawing.Point(434, 341);
            this.BtnAquecerSelecionado.Name = "BtnAquecerSelecionado";
            this.BtnAquecerSelecionado.Size = new System.Drawing.Size(224, 23);
            this.BtnAquecerSelecionado.TabIndex = 14;
            this.BtnAquecerSelecionado.Text = "Aquecer atravez do programa selecionado";
            this.BtnAquecerSelecionado.UseVisualStyleBackColor = true;
            this.BtnAquecerSelecionado.Click += new System.EventHandler(this.BtnAquecerSelecionado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdicionar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCaracter);
            this.groupBox1.Controls.Add(this.txtPotenciaProgramacao);
            this.groupBox1.Controls.Add(this.txtTempoProgramacao);
            this.groupBox1.Controls.Add(this.TxtInstrucoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(15, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 131);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Programacao";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "instruções";
            // 
            // TxtInstrucoes
            // 
            this.TxtInstrucoes.Location = new System.Drawing.Point(239, 24);
            this.TxtInstrucoes.Name = "TxtInstrucoes";
            this.TxtInstrucoes.Size = new System.Drawing.Size(398, 20);
            this.TxtInstrucoes.TabIndex = 3;
            // 
            // txtTempoProgramacao
            // 
            this.txtTempoProgramacao.Location = new System.Drawing.Point(50, 70);
            this.txtTempoProgramacao.Name = "txtTempoProgramacao";
            this.txtTempoProgramacao.Size = new System.Drawing.Size(100, 20);
            this.txtTempoProgramacao.TabIndex = 4;
            // 
            // txtPotenciaProgramacao
            // 
            this.txtPotenciaProgramacao.Location = new System.Drawing.Point(231, 70);
            this.txtPotenciaProgramacao.Name = "txtPotenciaProgramacao";
            this.txtPotenciaProgramacao.Size = new System.Drawing.Size(100, 20);
            this.txtPotenciaProgramacao.TabIndex = 5;
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(436, 70);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(100, 20);
            this.txtCaracter.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tempo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Potencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Caracter";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(562, 102);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 10;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // FrmMicroondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAquecerSelecionado);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.dgvProgramas);
            this.Controls.Add(this.TxtPotencia);
            this.Controls.Add(this.TxtTempo);
            this.Controls.Add(this.BtnAquecimentoRapido);
            this.Controls.Add(this.BtnAquecer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlimento);
            this.Name = "FrmMicroondas";
            this.Text = "Microondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAquecer;
        private System.Windows.Forms.Button BtnAquecimentoRapido;
        private System.Windows.Forms.NumericUpDown TxtTempo;
        private System.Windows.Forms.NumericUpDown TxtPotencia;
        private System.Windows.Forms.DataGridView dgvProgramas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrucoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnAquecerSelecionado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox TxtInstrucoes;
        private System.Windows.Forms.TextBox txtTempoProgramacao;
        private System.Windows.Forms.TextBox txtPotenciaProgramacao;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAdicionar;
    }
}

