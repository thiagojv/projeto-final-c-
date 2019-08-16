namespace WinPFC
{
    partial class FrmManutencaoProjeto
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
            this.chckbxAtivo = new System.Windows.Forms.CheckBox();
            this.cmbxTipoFundamental = new System.Windows.Forms.ComboBox();
            this.cmbxModelo = new System.Windows.Forms.ComboBox();
            this.dtmrpckrPeriodoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtmrpckrPeriodoInicial = new System.Windows.Forms.DateTimePicker();
            this.lblTipoFundamental = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPeriodoA = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.txtbxNome);
            this.pnlCadastro.Controls.Add(this.lblNome);
            this.pnlCadastro.Controls.Add(this.chckbxAtivo);
            this.pnlCadastro.Controls.Add(this.cmbxTipoFundamental);
            this.pnlCadastro.Controls.Add(this.cmbxModelo);
            this.pnlCadastro.Controls.Add(this.dtmrpckrPeriodoFinal);
            this.pnlCadastro.Controls.Add(this.dtmrpckrPeriodoInicial);
            this.pnlCadastro.Controls.Add(this.lblTipoFundamental);
            this.pnlCadastro.Controls.Add(this.lblModelo);
            this.pnlCadastro.Controls.Add(this.lblPeriodoA);
            this.pnlCadastro.Controls.Add(this.lblPeriodo);
            this.pnlCadastro.Size = new System.Drawing.Size(404, 202);
            // 
            // chckbxAtivo
            // 
            this.chckbxAtivo.AutoSize = true;
            this.chckbxAtivo.Location = new System.Drawing.Point(107, 110);
            this.chckbxAtivo.Name = "chckbxAtivo";
            this.chckbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chckbxAtivo.TabIndex = 17;
            this.chckbxAtivo.Text = "Ativo";
            this.chckbxAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbxTipoFundamental
            // 
            this.cmbxTipoFundamental.FormattingEnabled = true;
            this.cmbxTipoFundamental.Location = new System.Drawing.Point(107, 83);
            this.cmbxTipoFundamental.Name = "cmbxTipoFundamental";
            this.cmbxTipoFundamental.Size = new System.Drawing.Size(247, 21);
            this.cmbxTipoFundamental.TabIndex = 16;
            // 
            // cmbxModelo
            // 
            this.cmbxModelo.FormattingEnabled = true;
            this.cmbxModelo.Location = new System.Drawing.Point(107, 55);
            this.cmbxModelo.Name = "cmbxModelo";
            this.cmbxModelo.Size = new System.Drawing.Size(247, 21);
            this.cmbxModelo.TabIndex = 15;
            // 
            // dtmrpckrPeriodoFinal
            // 
            this.dtmrpckrPeriodoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmrpckrPeriodoFinal.Location = new System.Drawing.Point(220, 29);
            this.dtmrpckrPeriodoFinal.Name = "dtmrpckrPeriodoFinal";
            this.dtmrpckrPeriodoFinal.Size = new System.Drawing.Size(88, 20);
            this.dtmrpckrPeriodoFinal.TabIndex = 14;
            // 
            // dtmrpckrPeriodoInicial
            // 
            this.dtmrpckrPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmrpckrPeriodoInicial.Location = new System.Drawing.Point(107, 29);
            this.dtmrpckrPeriodoInicial.Name = "dtmrpckrPeriodoInicial";
            this.dtmrpckrPeriodoInicial.Size = new System.Drawing.Size(88, 20);
            this.dtmrpckrPeriodoInicial.TabIndex = 13;
            // 
            // lblTipoFundamental
            // 
            this.lblTipoFundamental.AutoSize = true;
            this.lblTipoFundamental.Location = new System.Drawing.Point(9, 87);
            this.lblTipoFundamental.Name = "lblTipoFundamental";
            this.lblTipoFundamental.Size = new System.Drawing.Size(92, 13);
            this.lblTipoFundamental.TabIndex = 12;
            this.lblTipoFundamental.Text = "Tipo Fundamental";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(59, 59);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPeriodoA
            // 
            this.lblPeriodoA.AutoSize = true;
            this.lblPeriodoA.Location = new System.Drawing.Point(201, 33);
            this.lblPeriodoA.Name = "lblPeriodoA";
            this.lblPeriodoA.Size = new System.Drawing.Size(13, 13);
            this.lblPeriodoA.TabIndex = 10;
            this.lblPeriodoA.Text = "a";
            this.lblPeriodoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(56, 33);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Período";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(107, 3);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(247, 20);
            this.txtbxNome.TabIndex = 19;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(66, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // FrmManutencaoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(404, 238);
            this.Name = "FrmManutencaoProjeto";
            this.Text = "Manutenção de Projetos";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox chckbxAtivo;
        private System.Windows.Forms.ComboBox cmbxTipoFundamental;
        private System.Windows.Forms.ComboBox cmbxModelo;
        private System.Windows.Forms.DateTimePicker dtmrpckrPeriodoFinal;
        private System.Windows.Forms.DateTimePicker dtmrpckrPeriodoInicial;
        private System.Windows.Forms.Label lblTipoFundamental;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPeriodoA;
        private System.Windows.Forms.Label lblPeriodo;

    }
}
