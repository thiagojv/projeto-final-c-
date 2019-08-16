namespace WinPFC
{
    partial class FrmManutencaoProjetoAtributos
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
            this.lblAtributo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuantidadeParametro1 = new System.Windows.Forms.Label();
            this.lblQuantidadeParametro2 = new System.Windows.Forms.Label();
            this.lblQuantidadeParametro3 = new System.Windows.Forms.Label();
            this.lblQuantidadeParametro4 = new System.Windows.Forms.Label();
            this.cmbxAtributo = new System.Windows.Forms.ComboBox();
            this.txtbxDescricao = new System.Windows.Forms.TextBox();
            this.nmrcpdwnQuantidadeParametro1 = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnQuantidadeParametro2 = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnQuantidadeParametro3 = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnQuantidadeParametro4 = new System.Windows.Forms.NumericUpDown();
            this.pnlDados.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.nmrcpdwnQuantidadeParametro4);
            this.pnlDados.Controls.Add(this.nmrcpdwnQuantidadeParametro3);
            this.pnlDados.Controls.Add(this.nmrcpdwnQuantidadeParametro2);
            this.pnlDados.Controls.Add(this.nmrcpdwnQuantidadeParametro1);
            this.pnlDados.Controls.Add(this.txtbxDescricao);
            this.pnlDados.Controls.Add(this.cmbxAtributo);
            this.pnlDados.Controls.Add(this.lblQuantidadeParametro4);
            this.pnlDados.Controls.Add(this.lblQuantidadeParametro3);
            this.pnlDados.Controls.Add(this.lblQuantidadeParametro2);
            this.pnlDados.Controls.Add(this.lblQuantidadeParametro1);
            this.pnlDados.Controls.Add(this.lblDescricao);
            this.pnlDados.Controls.Add(this.lblAtributo);
            this.pnlDados.Size = new System.Drawing.Size(447, 259);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Size = new System.Drawing.Size(447, 296);
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Location = new System.Drawing.Point(91, 11);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(43, 13);
            this.lblAtributo.TabIndex = 0;
            this.lblAtributo.Text = "Atributo";
            this.lblAtributo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(79, 38);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidadeParametro1
            // 
            this.lblQuantidadeParametro1.AutoSize = true;
            this.lblQuantidadeParametro1.Location = new System.Drawing.Point(12, 64);
            this.lblQuantidadeParametro1.Name = "lblQuantidadeParametro1";
            this.lblQuantidadeParametro1.Size = new System.Drawing.Size(122, 13);
            this.lblQuantidadeParametro1.TabIndex = 2;
            this.lblQuantidadeParametro1.Text = "Quantidade Parâmetro 1";
            this.lblQuantidadeParametro1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidadeParametro2
            // 
            this.lblQuantidadeParametro2.AutoSize = true;
            this.lblQuantidadeParametro2.Location = new System.Drawing.Point(12, 90);
            this.lblQuantidadeParametro2.Name = "lblQuantidadeParametro2";
            this.lblQuantidadeParametro2.Size = new System.Drawing.Size(122, 13);
            this.lblQuantidadeParametro2.TabIndex = 3;
            this.lblQuantidadeParametro2.Text = "Quantidade Parâmetro 2";
            this.lblQuantidadeParametro2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidadeParametro3
            // 
            this.lblQuantidadeParametro3.AutoSize = true;
            this.lblQuantidadeParametro3.Location = new System.Drawing.Point(12, 116);
            this.lblQuantidadeParametro3.Name = "lblQuantidadeParametro3";
            this.lblQuantidadeParametro3.Size = new System.Drawing.Size(122, 13);
            this.lblQuantidadeParametro3.TabIndex = 4;
            this.lblQuantidadeParametro3.Text = "Quantidade Parâmetro 3";
            this.lblQuantidadeParametro3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidadeParametro4
            // 
            this.lblQuantidadeParametro4.AutoSize = true;
            this.lblQuantidadeParametro4.Location = new System.Drawing.Point(12, 142);
            this.lblQuantidadeParametro4.Name = "lblQuantidadeParametro4";
            this.lblQuantidadeParametro4.Size = new System.Drawing.Size(122, 13);
            this.lblQuantidadeParametro4.TabIndex = 5;
            this.lblQuantidadeParametro4.Text = "Quantidade Parâmetro 4";
            this.lblQuantidadeParametro4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbxAtributo
            // 
            this.cmbxAtributo.FormattingEnabled = true;
            this.cmbxAtributo.Location = new System.Drawing.Point(140, 7);
            this.cmbxAtributo.Name = "cmbxAtributo";
            this.cmbxAtributo.Size = new System.Drawing.Size(295, 21);
            this.cmbxAtributo.TabIndex = 6;
            this.cmbxAtributo.SelectedIndexChanged += new System.EventHandler(this.cmbxAtributo_SelectedIndexChanged);
            // 
            // txtbxDescricao
            // 
            this.txtbxDescricao.Location = new System.Drawing.Point(140, 34);
            this.txtbxDescricao.Name = "txtbxDescricao";
            this.txtbxDescricao.Size = new System.Drawing.Size(295, 20);
            this.txtbxDescricao.TabIndex = 7;
            // 
            // nmrcpdwnQuantidadeParametro1
            // 
            this.nmrcpdwnQuantidadeParametro1.Location = new System.Drawing.Point(140, 60);
            this.nmrcpdwnQuantidadeParametro1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnQuantidadeParametro1.Name = "nmrcpdwnQuantidadeParametro1";
            this.nmrcpdwnQuantidadeParametro1.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnQuantidadeParametro1.TabIndex = 8;
            // 
            // nmrcpdwnQuantidadeParametro2
            // 
            this.nmrcpdwnQuantidadeParametro2.Location = new System.Drawing.Point(140, 86);
            this.nmrcpdwnQuantidadeParametro2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnQuantidadeParametro2.Name = "nmrcpdwnQuantidadeParametro2";
            this.nmrcpdwnQuantidadeParametro2.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnQuantidadeParametro2.TabIndex = 9;
            // 
            // nmrcpdwnQuantidadeParametro3
            // 
            this.nmrcpdwnQuantidadeParametro3.Location = new System.Drawing.Point(140, 112);
            this.nmrcpdwnQuantidadeParametro3.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnQuantidadeParametro3.Name = "nmrcpdwnQuantidadeParametro3";
            this.nmrcpdwnQuantidadeParametro3.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnQuantidadeParametro3.TabIndex = 10;
            // 
            // nmrcpdwnQuantidadeParametro4
            // 
            this.nmrcpdwnQuantidadeParametro4.Location = new System.Drawing.Point(140, 138);
            this.nmrcpdwnQuantidadeParametro4.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrcpdwnQuantidadeParametro4.Name = "nmrcpdwnQuantidadeParametro4";
            this.nmrcpdwnQuantidadeParametro4.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnQuantidadeParametro4.TabIndex = 11;
            // 
            // FrmManutencaoProjetoAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(447, 332);
            this.Name = "FrmManutencaoProjetoAtributos";
            this.Text = "Manutenção de atributos do projeto";
            this.Load += new System.EventHandler(this.FrmCadastroProjetoAtributos_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnQuantidadeParametro4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcpdwnQuantidadeParametro4;
        private System.Windows.Forms.NumericUpDown nmrcpdwnQuantidadeParametro3;
        private System.Windows.Forms.NumericUpDown nmrcpdwnQuantidadeParametro2;
        private System.Windows.Forms.NumericUpDown nmrcpdwnQuantidadeParametro1;
        private System.Windows.Forms.TextBox txtbxDescricao;
        private System.Windows.Forms.ComboBox cmbxAtributo;
        private System.Windows.Forms.Label lblQuantidadeParametro4;
        private System.Windows.Forms.Label lblQuantidadeParametro3;
        private System.Windows.Forms.Label lblQuantidadeParametro2;
        private System.Windows.Forms.Label lblQuantidadeParametro1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAtributo;

    }
}
