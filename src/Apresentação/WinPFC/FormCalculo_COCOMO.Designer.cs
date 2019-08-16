namespace WinPFC
{
    partial class FrmCalculo_COCOMO
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
            this.lblHistorico = new System.Windows.Forms.Label();
            this.cmbxHistorico = new System.Windows.Forms.ComboBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.spltcntnrResultadoRayleigh = new System.Windows.Forms.SplitContainer();
            this.dtgrdvwEsforco = new System.Windows.Forms.DataGridView();
            this.dtgrdvwPrazo = new System.Windows.Forms.DataGridView();
            this.pnlResultadosCOCOMO = new System.Windows.Forms.Panel();
            this.lblValorEquipe = new System.Windows.Forms.Label();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblValorPrazo = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblValorEsforco = new System.Windows.Forms.Label();
            this.lblEsforco = new System.Windows.Forms.Label();
            this.lblValorKDSI = new System.Windows.Forms.Label();
            this.lblKDSI = new System.Windows.Forms.Label();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnlTituloEsforço = new System.Windows.Forms.Panel();
            this.lblGridEsforco = new System.Windows.Forms.Label();
            this.pnlTituloPrazo = new System.Windows.Forms.Panel();
            this.lblGridPrazo = new System.Windows.Forms.Label();
            this.pnlProjeto.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            this.spltcntnrResultadoRayleigh.Panel1.SuspendLayout();
            this.spltcntnrResultadoRayleigh.Panel2.SuspendLayout();
            this.spltcntnrResultadoRayleigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwEsforco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwPrazo)).BeginInit();
            this.pnlResultadosCOCOMO.SuspendLayout();
            this.pnlControle.SuspendLayout();
            this.pnlTituloEsforço.SuspendLayout();
            this.pnlTituloPrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjeto
            // 
            this.pnlProjeto.Controls.Add(this.lblHistorico);
            this.pnlProjeto.Controls.Add(this.cmbxHistorico);
            this.pnlProjeto.Size = new System.Drawing.Size(448, 68);
            this.pnlProjeto.Controls.SetChildIndex(this.cmbxHistorico, 0);
            this.pnlProjeto.Controls.SetChildIndex(this.lblHistorico, 0);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(4, 39);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(48, 13);
            this.lblHistorico.TabIndex = 2;
            this.lblHistorico.Text = "Histórico";
            // 
            // cmbxHistorico
            // 
            this.cmbxHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxHistorico.FormattingEnabled = true;
            this.cmbxHistorico.Location = new System.Drawing.Point(58, 35);
            this.cmbxHistorico.Name = "cmbxHistorico";
            this.cmbxHistorico.Size = new System.Drawing.Size(380, 21);
            this.cmbxHistorico.TabIndex = 3;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.pnlResultados);
            this.pnlInferior.Controls.Add(this.pnlControle);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInferior.Location = new System.Drawing.Point(0, 68);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(448, 280);
            this.pnlInferior.TabIndex = 5;
            // 
            // pnlResultados
            // 
            this.pnlResultados.Controls.Add(this.spltcntnrResultadoRayleigh);
            this.pnlResultados.Controls.Add(this.pnlResultadosCOCOMO);
            this.pnlResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultados.Location = new System.Drawing.Point(0, 0);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(354, 280);
            this.pnlResultados.TabIndex = 1;
            // 
            // spltcntnrResultadoRayleigh
            // 
            this.spltcntnrResultadoRayleigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcntnrResultadoRayleigh.Location = new System.Drawing.Point(0, 102);
            this.spltcntnrResultadoRayleigh.Name = "spltcntnrResultadoRayleigh";
            // 
            // spltcntnrResultadoRayleigh.Panel1
            // 
            this.spltcntnrResultadoRayleigh.Panel1.Controls.Add(this.dtgrdvwEsforco);
            this.spltcntnrResultadoRayleigh.Panel1.Controls.Add(this.pnlTituloEsforço);
            // 
            // spltcntnrResultadoRayleigh.Panel2
            // 
            this.spltcntnrResultadoRayleigh.Panel2.Controls.Add(this.dtgrdvwPrazo);
            this.spltcntnrResultadoRayleigh.Panel2.Controls.Add(this.pnlTituloPrazo);
            this.spltcntnrResultadoRayleigh.Size = new System.Drawing.Size(354, 178);
            this.spltcntnrResultadoRayleigh.SplitterDistance = 117;
            this.spltcntnrResultadoRayleigh.TabIndex = 6;
            // 
            // dtgrdvwEsforco
            // 
            this.dtgrdvwEsforco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwEsforco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvwEsforco.Location = new System.Drawing.Point(0, 24);
            this.dtgrdvwEsforco.Name = "dtgrdvwEsforco";
            this.dtgrdvwEsforco.Size = new System.Drawing.Size(117, 154);
            this.dtgrdvwEsforco.TabIndex = 0;
            // 
            // dtgrdvwPrazo
            // 
            this.dtgrdvwPrazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwPrazo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvwPrazo.Location = new System.Drawing.Point(0, 24);
            this.dtgrdvwPrazo.Name = "dtgrdvwPrazo";
            this.dtgrdvwPrazo.Size = new System.Drawing.Size(233, 154);
            this.dtgrdvwPrazo.TabIndex = 0;
            // 
            // pnlResultadosCOCOMO
            // 
            this.pnlResultadosCOCOMO.Controls.Add(this.lblValorEquipe);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblEquipe);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblValorPrazo);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblPrazo);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblValorEsforco);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblEsforco);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblValorKDSI);
            this.pnlResultadosCOCOMO.Controls.Add(this.lblKDSI);
            this.pnlResultadosCOCOMO.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultadosCOCOMO.Location = new System.Drawing.Point(0, 0);
            this.pnlResultadosCOCOMO.Name = "pnlResultadosCOCOMO";
            this.pnlResultadosCOCOMO.Size = new System.Drawing.Size(354, 102);
            this.pnlResultadosCOCOMO.TabIndex = 0;
            // 
            // lblValorEquipe
            // 
            this.lblValorEquipe.AutoSize = true;
            this.lblValorEquipe.Location = new System.Drawing.Point(71, 78);
            this.lblValorEquipe.Name = "lblValorEquipe";
            this.lblValorEquipe.Size = new System.Drawing.Size(0, 13);
            this.lblValorEquipe.TabIndex = 7;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.Location = new System.Drawing.Point(10, 78);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(46, 13);
            this.lblEquipe.TabIndex = 6;
            this.lblEquipe.Text = "Equipe";
            // 
            // lblValorPrazo
            // 
            this.lblValorPrazo.AutoSize = true;
            this.lblValorPrazo.Location = new System.Drawing.Point(71, 56);
            this.lblValorPrazo.Name = "lblValorPrazo";
            this.lblValorPrazo.Size = new System.Drawing.Size(0, 13);
            this.lblValorPrazo.TabIndex = 5;
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Location = new System.Drawing.Point(17, 56);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(39, 13);
            this.lblPrazo.TabIndex = 4;
            this.lblPrazo.Text = "Prazo";
            // 
            // lblValorEsforco
            // 
            this.lblValorEsforco.AutoSize = true;
            this.lblValorEsforco.Location = new System.Drawing.Point(71, 34);
            this.lblValorEsforco.Name = "lblValorEsforco";
            this.lblValorEsforco.Size = new System.Drawing.Size(0, 13);
            this.lblValorEsforco.TabIndex = 3;
            // 
            // lblEsforco
            // 
            this.lblEsforco.AutoSize = true;
            this.lblEsforco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsforco.Location = new System.Drawing.Point(6, 34);
            this.lblEsforco.Name = "lblEsforco";
            this.lblEsforco.Size = new System.Drawing.Size(50, 13);
            this.lblEsforco.TabIndex = 2;
            this.lblEsforco.Text = "Esforço";
            // 
            // lblValorKDSI
            // 
            this.lblValorKDSI.AutoSize = true;
            this.lblValorKDSI.Location = new System.Drawing.Point(71, 12);
            this.lblValorKDSI.Name = "lblValorKDSI";
            this.lblValorKDSI.Size = new System.Drawing.Size(0, 13);
            this.lblValorKDSI.TabIndex = 1;
            // 
            // lblKDSI
            // 
            this.lblKDSI.AutoSize = true;
            this.lblKDSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKDSI.Location = new System.Drawing.Point(20, 12);
            this.lblKDSI.Name = "lblKDSI";
            this.lblKDSI.Size = new System.Drawing.Size(36, 13);
            this.lblKDSI.TabIndex = 0;
            this.lblKDSI.Text = "KDSI";
            // 
            // pnlControle
            // 
            this.pnlControle.Controls.Add(this.btnCalcular);
            this.pnlControle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControle.Location = new System.Drawing.Point(354, 0);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(94, 280);
            this.pnlControle.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(7, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pnlTituloEsforço
            // 
            this.pnlTituloEsforço.Controls.Add(this.lblGridEsforco);
            this.pnlTituloEsforço.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEsforço.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloEsforço.Name = "pnlTituloEsforço";
            this.pnlTituloEsforço.Size = new System.Drawing.Size(117, 24);
            this.pnlTituloEsforço.TabIndex = 1;
            // 
            // lblGridEsforco
            // 
            this.lblGridEsforco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridEsforco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridEsforco.Location = new System.Drawing.Point(0, 0);
            this.lblGridEsforco.Name = "lblGridEsforco";
            this.lblGridEsforco.Size = new System.Drawing.Size(117, 24);
            this.lblGridEsforco.TabIndex = 0;
            this.lblGridEsforco.Text = "Esforço";
            this.lblGridEsforco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTituloPrazo
            // 
            this.pnlTituloPrazo.Controls.Add(this.lblGridPrazo);
            this.pnlTituloPrazo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloPrazo.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloPrazo.Name = "pnlTituloPrazo";
            this.pnlTituloPrazo.Size = new System.Drawing.Size(233, 24);
            this.pnlTituloPrazo.TabIndex = 2;
            // 
            // lblGridPrazo
            // 
            this.lblGridPrazo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridPrazo.Location = new System.Drawing.Point(0, 0);
            this.lblGridPrazo.Name = "lblGridPrazo";
            this.lblGridPrazo.Size = new System.Drawing.Size(233, 24);
            this.lblGridPrazo.TabIndex = 0;
            this.lblGridPrazo.Text = "Prazo";
            this.lblGridPrazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalculo_COCOMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(448, 348);
            this.Controls.Add(this.pnlInferior);
            this.Name = "FrmCalculo_COCOMO";
            this.Text = "Cálculo das estimativas do COCOMO";
            this.Controls.SetChildIndex(this.pnlProjeto, 0);
            this.Controls.SetChildIndex(this.pnlInferior, 0);
            this.pnlProjeto.ResumeLayout(false);
            this.pnlProjeto.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlResultados.ResumeLayout(false);
            this.spltcntnrResultadoRayleigh.Panel1.ResumeLayout(false);
            this.spltcntnrResultadoRayleigh.Panel2.ResumeLayout(false);
            this.spltcntnrResultadoRayleigh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwEsforco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwPrazo)).EndInit();
            this.pnlResultadosCOCOMO.ResumeLayout(false);
            this.pnlResultadosCOCOMO.PerformLayout();
            this.pnlControle.ResumeLayout(false);
            this.pnlTituloEsforço.ResumeLayout(false);
            this.pnlTituloPrazo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.ComboBox cmbxHistorico;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlControle;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Panel pnlResultadosCOCOMO;
        private System.Windows.Forms.Label lblValorPrazo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblValorEsforco;
        private System.Windows.Forms.Label lblEsforco;
        private System.Windows.Forms.Label lblValorKDSI;
        private System.Windows.Forms.Label lblKDSI;
        private System.Windows.Forms.SplitContainer spltcntnrResultadoRayleigh;
        private System.Windows.Forms.DataGridView dtgrdvwEsforco;
        private System.Windows.Forms.DataGridView dtgrdvwPrazo;
        private System.Windows.Forms.Label lblValorEquipe;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Panel pnlTituloEsforço;
        private System.Windows.Forms.Label lblGridEsforco;
        private System.Windows.Forms.Panel pnlTituloPrazo;
        private System.Windows.Forms.Label lblGridPrazo;
    }
}
