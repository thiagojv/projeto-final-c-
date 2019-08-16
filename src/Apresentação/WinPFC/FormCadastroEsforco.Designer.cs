namespace WinPFC
{
    partial class FrmCadastroEsforco
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipoFundamental = new System.Windows.Forms.Label();
            this.lblFatorMultiplicacao = new System.Windows.Forms.Label();
            this.lblExponencial = new System.Windows.Forms.Label();
            this.cmbxModelo = new System.Windows.Forms.ComboBox();
            this.cmbxTipoFundamental = new System.Windows.Forms.ComboBox();
            this.nmrcpwnFatorMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnExponencial = new System.Windows.Forms.NumericUpDown();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpwnFatorMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnExponencial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.nmrcpdwnExponencial);
            this.pnlCadastro.Controls.Add(this.nmrcpwnFatorMultiplicacao);
            this.pnlCadastro.Controls.Add(this.cmbxTipoFundamental);
            this.pnlCadastro.Controls.Add(this.cmbxModelo);
            this.pnlCadastro.Controls.Add(this.lblExponencial);
            this.pnlCadastro.Controls.Add(this.lblFatorMultiplicacao);
            this.pnlCadastro.Controls.Add(this.lblTipoFundamental);
            this.pnlCadastro.Controls.Add(this.lblModelo);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(63, 6);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipoFundamental
            // 
            this.lblTipoFundamental.AutoSize = true;
            this.lblTipoFundamental.Location = new System.Drawing.Point(13, 33);
            this.lblTipoFundamental.Name = "lblTipoFundamental";
            this.lblTipoFundamental.Size = new System.Drawing.Size(92, 13);
            this.lblTipoFundamental.TabIndex = 1;
            this.lblTipoFundamental.Text = "Tipo Fundamental";
            // 
            // lblFatorMultiplicacao
            // 
            this.lblFatorMultiplicacao.AutoSize = true;
            this.lblFatorMultiplicacao.Location = new System.Drawing.Point(9, 59);
            this.lblFatorMultiplicacao.Name = "lblFatorMultiplicacao";
            this.lblFatorMultiplicacao.Size = new System.Drawing.Size(96, 13);
            this.lblFatorMultiplicacao.TabIndex = 2;
            this.lblFatorMultiplicacao.Text = "Fator Multiplicação";
            // 
            // lblExponencial
            // 
            this.lblExponencial.AutoSize = true;
            this.lblExponencial.Location = new System.Drawing.Point(40, 88);
            this.lblExponencial.Name = "lblExponencial";
            this.lblExponencial.Size = new System.Drawing.Size(65, 13);
            this.lblExponencial.TabIndex = 3;
            this.lblExponencial.Text = "Exponencial";
            // 
            // cmbxModelo
            // 
            this.cmbxModelo.FormattingEnabled = true;
            this.cmbxModelo.Location = new System.Drawing.Point(111, 3);
            this.cmbxModelo.Name = "cmbxModelo";
            this.cmbxModelo.Size = new System.Drawing.Size(231, 21);
            this.cmbxModelo.TabIndex = 4;
            // 
            // cmbxTipoFundamental
            // 
            this.cmbxTipoFundamental.FormattingEnabled = true;
            this.cmbxTipoFundamental.Location = new System.Drawing.Point(111, 30);
            this.cmbxTipoFundamental.Name = "cmbxTipoFundamental";
            this.cmbxTipoFundamental.Size = new System.Drawing.Size(231, 21);
            this.cmbxTipoFundamental.TabIndex = 5;
            // 
            // nmrcpwnFatorMultiplicacao
            // 
            this.nmrcpwnFatorMultiplicacao.Location = new System.Drawing.Point(111, 57);
            this.nmrcpwnFatorMultiplicacao.Name = "nmrcpwnFatorMultiplicacao";
            this.nmrcpwnFatorMultiplicacao.Size = new System.Drawing.Size(120, 20);
            this.nmrcpwnFatorMultiplicacao.TabIndex = 6;
            // 
            // nmrcpdwnExponencial
            // 
            this.nmrcpdwnExponencial.Location = new System.Drawing.Point(111, 86);
            this.nmrcpdwnExponencial.Name = "nmrcpdwnExponencial";
            this.nmrcpdwnExponencial.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnExponencial.TabIndex = 7;
            // 
            // FrmCadastroEsforco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroEsforco";
            this.Text = "Cadastro do cálculo do Esforço";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpwnFatorMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnExponencial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcpdwnExponencial;
        private System.Windows.Forms.NumericUpDown nmrcpwnFatorMultiplicacao;
        private System.Windows.Forms.ComboBox cmbxTipoFundamental;
        private System.Windows.Forms.ComboBox cmbxModelo;
        private System.Windows.Forms.Label lblExponencial;
        private System.Windows.Forms.Label lblFatorMultiplicacao;
        private System.Windows.Forms.Label lblTipoFundamental;
        private System.Windows.Forms.Label lblModelo;
    }
}
