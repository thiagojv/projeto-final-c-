namespace WinPFC
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnstrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.tlstrpmntmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosDistribuicao = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosDistribuicaoTamanhos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMO = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMOEscalas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMOEsforco = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMOLinguagens = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMOModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosPontosFuncao = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosPontosFuncaoAtributos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosDados = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosLinguagens = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosAtributos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosCaracteristicas = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosCaracteristicasCOCOMO = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosCaracteristicasPF = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmProjetosHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.ststrpPrincipal = new System.Windows.Forms.StatusStrip();
            this.tlstrpmntmCalculoMedicao = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmntmCalculoEstimativas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstrpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstrpPrincipal
            // 
            this.mnstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCadastros,
            this.tlstrpmntmProjetos,
            this.tlstrpmntmCalculo});
            this.mnstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnstrpPrincipal.Name = "mnstrpPrincipal";
            this.mnstrpPrincipal.Size = new System.Drawing.Size(292, 24);
            this.mnstrpPrincipal.TabIndex = 0;
            this.mnstrpPrincipal.Text = "menuStrip1";
            // 
            // tlstrpmntmCadastros
            // 
            this.tlstrpmntmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCadastrosDistribuicao,
            this.tlstrpmntmCadastrosCOCOMO,
            this.tlstrpmntmCadastrosPontosFuncao});
            this.tlstrpmntmCadastros.Name = "tlstrpmntmCadastros";
            this.tlstrpmntmCadastros.Size = new System.Drawing.Size(68, 20);
            this.tlstrpmntmCadastros.Text = "Cadastros";
            // 
            // tlstrpmntmCadastrosDistribuicao
            // 
            this.tlstrpmntmCadastrosDistribuicao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCadastrosDistribuicaoTamanhos,
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao});
            this.tlstrpmntmCadastrosDistribuicao.Name = "tlstrpmntmCadastrosDistribuicao";
            this.tlstrpmntmCadastrosDistribuicao.Size = new System.Drawing.Size(171, 22);
            this.tlstrpmntmCadastrosDistribuicao.Text = "Distribuição";
            // 
            // tlstrpmntmCadastrosDistribuicaoTamanhos
            // 
            this.tlstrpmntmCadastrosDistribuicaoTamanhos.Name = "tlstrpmntmCadastrosDistribuicaoTamanhos";
            this.tlstrpmntmCadastrosDistribuicaoTamanhos.Size = new System.Drawing.Size(183, 22);
            this.tlstrpmntmCadastrosDistribuicaoTamanhos.Text = "Tamanhos";
            this.tlstrpmntmCadastrosDistribuicaoTamanhos.Click += new System.EventHandler(this.tlstrpmntmCadastrosDistribuicaoTamanhos_Click);
            // 
            // tlstrpmntmCadastrosDistribuicaoTiposDistribuicao
            // 
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao.Name = "tlstrpmntmCadastrosDistribuicaoTiposDistribuicao";
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao.Size = new System.Drawing.Size(183, 22);
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao.Text = "Tipos de Distribuição";
            this.tlstrpmntmCadastrosDistribuicaoTiposDistribuicao.Click += new System.EventHandler(this.tlstrpmntmCadastrosDistribuicaoTipoDistribuicao_Click);
            // 
            // tlstrpmntmCadastrosCOCOMO
            // 
            this.tlstrpmntmCadastrosCOCOMO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCadastrosCOCOMOEscalas,
            this.tlstrpmntmCadastrosCOCOMOEsforco,
            this.tlstrpmntmCadastrosCOCOMOLinguagens,
            this.tlstrpmntmCadastrosCOCOMOModelos,
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais});
            this.tlstrpmntmCadastrosCOCOMO.Name = "tlstrpmntmCadastrosCOCOMO";
            this.tlstrpmntmCadastrosCOCOMO.Size = new System.Drawing.Size(171, 22);
            this.tlstrpmntmCadastrosCOCOMO.Text = "COCOMO";
            // 
            // tlstrpmntmCadastrosCOCOMOEscalas
            // 
            this.tlstrpmntmCadastrosCOCOMOEscalas.Name = "tlstrpmntmCadastrosCOCOMOEscalas";
            this.tlstrpmntmCadastrosCOCOMOEscalas.Size = new System.Drawing.Size(180, 22);
            this.tlstrpmntmCadastrosCOCOMOEscalas.Text = "Escalas";
            this.tlstrpmntmCadastrosCOCOMOEscalas.Click += new System.EventHandler(this.tlstrpmntmCadastrosCOCOMOEscalas_Click);
            // 
            // tlstrpmntmCadastrosCOCOMOEsforco
            // 
            this.tlstrpmntmCadastrosCOCOMOEsforco.Name = "tlstrpmntmCadastrosCOCOMOEsforco";
            this.tlstrpmntmCadastrosCOCOMOEsforco.Size = new System.Drawing.Size(180, 22);
            this.tlstrpmntmCadastrosCOCOMOEsforco.Text = "Esforço";
            this.tlstrpmntmCadastrosCOCOMOEsforco.Click += new System.EventHandler(this.tlstrpmntmCadastroEsforco_Click);
            // 
            // tlstrpmntmCadastrosCOCOMOLinguagens
            // 
            this.tlstrpmntmCadastrosCOCOMOLinguagens.Name = "tlstrpmntmCadastrosCOCOMOLinguagens";
            this.tlstrpmntmCadastrosCOCOMOLinguagens.Size = new System.Drawing.Size(180, 22);
            this.tlstrpmntmCadastrosCOCOMOLinguagens.Text = "Linguagens";
            this.tlstrpmntmCadastrosCOCOMOLinguagens.Click += new System.EventHandler(this.tlstrpmntmCadastrosCOCOMOLinguagem_Click);
            // 
            // tlstrpmntmCadastrosCOCOMOModelos
            // 
            this.tlstrpmntmCadastrosCOCOMOModelos.Name = "tlstrpmntmCadastrosCOCOMOModelos";
            this.tlstrpmntmCadastrosCOCOMOModelos.Size = new System.Drawing.Size(180, 22);
            this.tlstrpmntmCadastrosCOCOMOModelos.Text = "Modelos";
            this.tlstrpmntmCadastrosCOCOMOModelos.Click += new System.EventHandler(this.tlstrpmntmCadastrosCOCOMOModelos_Click);
            // 
            // tlstrpmntmCadastrosCOCOMOTipos_Fundamentais
            // 
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais.Name = "tlstrpmntmCadastrosCOCOMOTipos_Fundamentais";
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais.Size = new System.Drawing.Size(180, 22);
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais.Text = "Tipos Fundamentais";
            this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais.Click += new System.EventHandler(this.tlstrpmntmCadastrosCOCOMOTipos_Fundamentais_Click);
            // 
            // tlstrpmntmCadastrosPontosFuncao
            // 
            this.tlstrpmntmCadastrosPontosFuncao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCadastrosPontosFuncaoAtributos,
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas,
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades,
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia});
            this.tlstrpmntmCadastrosPontosFuncao.Name = "tlstrpmntmCadastrosPontosFuncao";
            this.tlstrpmntmCadastrosPontosFuncao.Size = new System.Drawing.Size(171, 22);
            this.tlstrpmntmCadastrosPontosFuncao.Text = "Pontos de Função";
            // 
            // tlstrpmntmCadastrosPontosFuncaoAtributos
            // 
            this.tlstrpmntmCadastrosPontosFuncaoAtributos.Name = "tlstrpmntmCadastrosPontosFuncaoAtributos";
            this.tlstrpmntmCadastrosPontosFuncaoAtributos.Size = new System.Drawing.Size(178, 22);
            this.tlstrpmntmCadastrosPontosFuncaoAtributos.Text = "Atributos";
            this.tlstrpmntmCadastrosPontosFuncaoAtributos.Click += new System.EventHandler(this.tlstrpmntmCadastrosPontosFuncaoAtributos_Click);
            // 
            // tlstrpmntmCadastrosPontosFuncaoCaracteristicas
            // 
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas.Name = "tlstrpmntmCadastrosPontosFuncaoCaracteristicas";
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas.Size = new System.Drawing.Size(178, 22);
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas.Text = "Características";
            this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas.Click += new System.EventHandler(this.tlstrpmntmCadastrosPontosFuncaoCaracteristicas_Click);
            // 
            // tlstrpmntmCadastrosPontosFuncaoComplexidades
            // 
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades.Name = "tlstrpmntmCadastrosPontosFuncaoComplexidades";
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades.Size = new System.Drawing.Size(178, 22);
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades.Text = "Complexidades";
            this.tlstrpmntmCadastrosPontosFuncaoComplexidades.Click += new System.EventHandler(this.tlstrpmntmCadastrosPontosFuncaoComplexidades_Click);
            // 
            // tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia
            // 
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia.Name = "tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia";
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia.Size = new System.Drawing.Size(178, 22);
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia.Text = "Níveis de Influência";
            this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia.Click += new System.EventHandler(this.tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia_Click);
            // 
            // tlstrpmntmProjetos
            // 
            this.tlstrpmntmProjetos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmProjetosDados,
            this.tlstrpmntmProjetosLinguagens,
            this.tlstrpmntmProjetosAtributos,
            this.tlstrpmntmProjetosCaracteristicas,
            this.tlstrpmntmProjetosHistorico});
            this.tlstrpmntmProjetos.Name = "tlstrpmntmProjetos";
            this.tlstrpmntmProjetos.Size = new System.Drawing.Size(59, 20);
            this.tlstrpmntmProjetos.Text = "Projetos";
            // 
            // tlstrpmntmProjetosDados
            // 
            this.tlstrpmntmProjetosDados.Name = "tlstrpmntmProjetosDados";
            this.tlstrpmntmProjetosDados.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmntmProjetosDados.Text = "Dados";
            this.tlstrpmntmProjetosDados.Click += new System.EventHandler(this.tlstrpmntmProjetosDados_Click);
            // 
            // tlstrpmntmProjetosLinguagens
            // 
            this.tlstrpmntmProjetosLinguagens.Name = "tlstrpmntmProjetosLinguagens";
            this.tlstrpmntmProjetosLinguagens.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmntmProjetosLinguagens.Text = "Linguagens";
            this.tlstrpmntmProjetosLinguagens.Click += new System.EventHandler(this.tlstrpmntmProjetosLinguagens_Click);
            // 
            // tlstrpmntmProjetosAtributos
            // 
            this.tlstrpmntmProjetosAtributos.Name = "tlstrpmntmProjetosAtributos";
            this.tlstrpmntmProjetosAtributos.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmntmProjetosAtributos.Text = "Atributos";
            this.tlstrpmntmProjetosAtributos.Click += new System.EventHandler(this.tlstrpmntmProjetosAtributos_Click);
            // 
            // tlstrpmntmProjetosCaracteristicas
            // 
            this.tlstrpmntmProjetosCaracteristicas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmProjetosCaracteristicasCOCOMO,
            this.tlstrpmntmProjetosCaracteristicasPF});
            this.tlstrpmntmProjetosCaracteristicas.Name = "tlstrpmntmProjetosCaracteristicas";
            this.tlstrpmntmProjetosCaracteristicas.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmntmProjetosCaracteristicas.Text = "Características";
            // 
            // tlstrpmntmProjetosCaracteristicasCOCOMO
            // 
            this.tlstrpmntmProjetosCaracteristicasCOCOMO.Name = "tlstrpmntmProjetosCaracteristicasCOCOMO";
            this.tlstrpmntmProjetosCaracteristicasCOCOMO.Size = new System.Drawing.Size(171, 22);
            this.tlstrpmntmProjetosCaracteristicasCOCOMO.Text = "COCOMO";
            this.tlstrpmntmProjetosCaracteristicasCOCOMO.Click += new System.EventHandler(this.tlstrpmntmProjetosCaracteristicasCOCOMO_Click);
            // 
            // tlstrpmntmProjetosCaracteristicasPF
            // 
            this.tlstrpmntmProjetosCaracteristicasPF.Name = "tlstrpmntmProjetosCaracteristicasPF";
            this.tlstrpmntmProjetosCaracteristicasPF.Size = new System.Drawing.Size(171, 22);
            this.tlstrpmntmProjetosCaracteristicasPF.Text = "Pontos de Função";
            this.tlstrpmntmProjetosCaracteristicasPF.Click += new System.EventHandler(this.tlstrpmntmProjetosCaracteristicasPF_Click);
            // 
            // tlstrpmntmProjetosHistorico
            // 
            this.tlstrpmntmProjetosHistorico.Name = "tlstrpmntmProjetosHistorico";
            this.tlstrpmntmProjetosHistorico.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmntmProjetosHistorico.Text = "Histórico";
            this.tlstrpmntmProjetosHistorico.Click += new System.EventHandler(this.tlstrpmntmProjetosHistorico_Click);
            // 
            // tlstrpmntmCalculo
            // 
            this.tlstrpmntmCalculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmntmCalculoMedicao,
            this.tlstrpmntmCalculoEstimativas});
            this.tlstrpmntmCalculo.Name = "tlstrpmntmCalculo";
            this.tlstrpmntmCalculo.Size = new System.Drawing.Size(53, 20);
            this.tlstrpmntmCalculo.Text = "Cálculo";
            // 
            // ststrpPrincipal
            // 
            this.ststrpPrincipal.Location = new System.Drawing.Point(0, 244);
            this.ststrpPrincipal.Name = "ststrpPrincipal";
            this.ststrpPrincipal.Size = new System.Drawing.Size(292, 22);
            this.ststrpPrincipal.TabIndex = 2;
            this.ststrpPrincipal.Text = "statusStrip1";
            // 
            // tlstrpmntmCalculoMedicao
            // 
            this.tlstrpmntmCalculoMedicao.Name = "tlstrpmntmCalculoMedicao";
            this.tlstrpmntmCalculoMedicao.Size = new System.Drawing.Size(152, 22);
            this.tlstrpmntmCalculoMedicao.Text = "Medição";
            this.tlstrpmntmCalculoMedicao.Click += new System.EventHandler(this.tlstrpmntmCalculoMedicao_Click);
            // 
            // tlstrpmntmCalculoEstimativas
            // 
            this.tlstrpmntmCalculoEstimativas.Name = "tlstrpmntmCalculoEstimativas";
            this.tlstrpmntmCalculoEstimativas.Size = new System.Drawing.Size(152, 22);
            this.tlstrpmntmCalculoEstimativas.Text = "Estimativas";
            this.tlstrpmntmCalculoEstimativas.Click += new System.EventHandler(this.tlstrpmntmCalculoEstimativas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.ststrpPrincipal);
            this.Controls.Add(this.mnstrpPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnstrpPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Projeto Final de Curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnstrpPrincipal.ResumeLayout(false);
            this.mnstrpPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastros;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosDistribuicao;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosDistribuicaoTiposDistribuicao;
        private System.Windows.Forms.StatusStrip ststrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMO;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMOLinguagens;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMOEscalas;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMOModelos;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMOTipos_Fundamentais;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosPontosFuncao;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosPontosFuncaoAtributos;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosPontosFuncaoCaracteristicas;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosDistribuicaoTamanhos;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosPontosFuncaoComplexidades;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCadastrosCOCOMOEsforco;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetos;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosDados;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosLinguagens;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosAtributos;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosCaracteristicas;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosCaracteristicasCOCOMO;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosCaracteristicasPF;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmProjetosHistorico;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCalculo;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCalculoMedicao;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmntmCalculoEstimativas;
    }
}

