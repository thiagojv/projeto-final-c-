namespace WinPFC
{
    partial class FrmCadastroTipos_FundamentaisCOCOMO
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFatorMultiplicacao = new System.Windows.Forms.Label();
            this.lblExponencial = new System.Windows.Forms.Label();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.nmrcpdwnFatorMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnExponencial = new System.Windows.Forms.NumericUpDown();
            this.grpbxPrazo = new System.Windows.Forms.GroupBox();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnFatorMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnExponencial)).BeginInit();
            this.grpbxPrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.grpbxPrazo);
            this.pnlCadastro.Controls.Add(this.txtbxNome);
            this.pnlCadastro.Controls.Add(this.lblNome);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblFatorMultiplicacao
            // 
            this.lblFatorMultiplicacao.AutoSize = true;
            this.lblFatorMultiplicacao.Location = new System.Drawing.Point(28, 25);
            this.lblFatorMultiplicacao.Name = "lblFatorMultiplicacao";
            this.lblFatorMultiplicacao.Size = new System.Drawing.Size(96, 13);
            this.lblFatorMultiplicacao.TabIndex = 1;
            this.lblFatorMultiplicacao.Text = "Fator Multiplicação";
            // 
            // lblExponencial
            // 
            this.lblExponencial.AutoSize = true;
            this.lblExponencial.Location = new System.Drawing.Point(59, 51);
            this.lblExponencial.Name = "lblExponencial";
            this.lblExponencial.Size = new System.Drawing.Size(65, 13);
            this.lblExponencial.TabIndex = 2;
            this.lblExponencial.Text = "Exponencial";
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(53, 10);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(237, 20);
            this.txtbxNome.TabIndex = 3;
            // 
            // nmrcpdwnFatorMultiplicacao
            // 
            this.nmrcpdwnFatorMultiplicacao.DecimalPlaces = 2;
            this.nmrcpdwnFatorMultiplicacao.Location = new System.Drawing.Point(130, 21);
            this.nmrcpdwnFatorMultiplicacao.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnFatorMultiplicacao.Name = "nmrcpdwnFatorMultiplicacao";
            this.nmrcpdwnFatorMultiplicacao.Size = new System.Drawing.Size(90, 20);
            this.nmrcpdwnFatorMultiplicacao.TabIndex = 6;
            // 
            // nmrcpdwnExponencial
            // 
            this.nmrcpdwnExponencial.DecimalPlaces = 2;
            this.nmrcpdwnExponencial.Location = new System.Drawing.Point(130, 47);
            this.nmrcpdwnExponencial.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnExponencial.Name = "nmrcpdwnExponencial";
            this.nmrcpdwnExponencial.Size = new System.Drawing.Size(90, 20);
            this.nmrcpdwnExponencial.TabIndex = 7;
            // 
            // grpbxPrazo
            // 
            this.grpbxPrazo.Controls.Add(this.nmrcpdwnExponencial);
            this.grpbxPrazo.Controls.Add(this.lblFatorMultiplicacao);
            this.grpbxPrazo.Controls.Add(this.lblExponencial);
            this.grpbxPrazo.Controls.Add(this.nmrcpdwnFatorMultiplicacao);
            this.grpbxPrazo.Location = new System.Drawing.Point(12, 36);
            this.grpbxPrazo.Name = "grpbxPrazo";
            this.grpbxPrazo.Size = new System.Drawing.Size(270, 86);
            this.grpbxPrazo.TabIndex = 9;
            this.grpbxPrazo.TabStop = false;
            this.grpbxPrazo.Text = "Prazo";
            // 
            // FrmCadastroTipos_FundamentaisCOCOMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroTipos_FundamentaisCOCOMO";
            this.Text = "Cadastro de Tipos Fundamentais";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnFatorMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnExponencial)).EndInit();
            this.grpbxPrazo.ResumeLayout(false);
            this.grpbxPrazo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.Label lblExponencial;
        private System.Windows.Forms.Label lblFatorMultiplicacao;
        private System.Windows.Forms.NumericUpDown nmrcpdwnExponencial;
        private System.Windows.Forms.NumericUpDown nmrcpdwnFatorMultiplicacao;
        private System.Windows.Forms.GroupBox grpbxPrazo;
    }
}
