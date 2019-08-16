namespace WinPFC
{
    partial class FrmAncestralCadastro
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
            this.tlstrpCadastro = new System.Windows.Forms.ToolStrip();
            this.tlstrpbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnProcurar = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrpbtnInserir = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrpbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.tlstrpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlstrpCadastro
            // 
            this.tlstrpCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpbtnNovo,
            this.tlstrpbtnProcurar,
            this.tlstrpbtnSeparador1,
            this.tlstrpbtnInserir,
            this.tlstrpbtnAlterar,
            this.tlstrpbtnExcluir,
            this.tlstrpbtnSeparador2,
            this.tlstrpbtnCancelar});
            this.tlstrpCadastro.Location = new System.Drawing.Point(0, 0);
            this.tlstrpCadastro.Name = "tlstrpCadastro";
            this.tlstrpCadastro.Size = new System.Drawing.Size(354, 36);
            this.tlstrpCadastro.TabIndex = 0;
            // 
            // tlstrpbtnNovo
            // 
            this.tlstrpbtnNovo.Image = global::WinPFC.Properties.Resources.DocumentHS;
            this.tlstrpbtnNovo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnNovo.Name = "tlstrpbtnNovo";
            this.tlstrpbtnNovo.Size = new System.Drawing.Size(36, 33);
            this.tlstrpbtnNovo.Text = "Novo";
            this.tlstrpbtnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnNovo.Click += new System.EventHandler(this.tlstrpbtnNovo_Click);
            // 
            // tlstrpbtnProcurar
            // 
            this.tlstrpbtnProcurar.Image = global::WinPFC.Properties.Resources.FindHS;
            this.tlstrpbtnProcurar.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnProcurar.Name = "tlstrpbtnProcurar";
            this.tlstrpbtnProcurar.Size = new System.Drawing.Size(52, 33);
            this.tlstrpbtnProcurar.Text = "Procurar";
            this.tlstrpbtnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnProcurar.Click += new System.EventHandler(this.tlstrpbtnProcurar_Click);
            // 
            // tlstrpbtnSeparador1
            // 
            this.tlstrpbtnSeparador1.Name = "tlstrpbtnSeparador1";
            this.tlstrpbtnSeparador1.Size = new System.Drawing.Size(6, 36);
            // 
            // tlstrpbtnInserir
            // 
            this.tlstrpbtnInserir.Image = global::WinPFC.Properties.Resources.saveHS;
            this.tlstrpbtnInserir.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnInserir.Name = "tlstrpbtnInserir";
            this.tlstrpbtnInserir.Size = new System.Drawing.Size(42, 33);
            this.tlstrpbtnInserir.Text = "Inserir";
            this.tlstrpbtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnInserir.Click += new System.EventHandler(this.tlstrpbtnInserir_Click);
            // 
            // tlstrpbtnAlterar
            // 
            this.tlstrpbtnAlterar.Image = global::WinPFC.Properties.Resources.EditInformationHS;
            this.tlstrpbtnAlterar.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnAlterar.Name = "tlstrpbtnAlterar";
            this.tlstrpbtnAlterar.Size = new System.Drawing.Size(44, 33);
            this.tlstrpbtnAlterar.Text = "Alterar";
            this.tlstrpbtnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnAlterar.Click += new System.EventHandler(this.tlstrpbtnAlterar_Click);
            // 
            // tlstrpbtnExcluir
            // 
            this.tlstrpbtnExcluir.Image = global::WinPFC.Properties.Resources.DeleteHS;
            this.tlstrpbtnExcluir.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnExcluir.Name = "tlstrpbtnExcluir";
            this.tlstrpbtnExcluir.Size = new System.Drawing.Size(42, 33);
            this.tlstrpbtnExcluir.Text = "Excluir";
            this.tlstrpbtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnExcluir.Click += new System.EventHandler(this.tlstrpbtnExcluir_Click);
            // 
            // tlstrpbtnSeparador2
            // 
            this.tlstrpbtnSeparador2.Name = "tlstrpbtnSeparador2";
            this.tlstrpbtnSeparador2.Size = new System.Drawing.Size(6, 36);
            // 
            // tlstrpbtnCancelar
            // 
            this.tlstrpbtnCancelar.Image = global::WinPFC.Properties.Resources.Edit_UndoHS;
            this.tlstrpbtnCancelar.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrpbtnCancelar.Name = "tlstrpbtnCancelar";
            this.tlstrpbtnCancelar.Size = new System.Drawing.Size(53, 33);
            this.tlstrpbtnCancelar.Text = "Cancelar";
            this.tlstrpbtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlstrpbtnCancelar.Click += new System.EventHandler(this.tlstrpbtnCancelar_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastro.Location = new System.Drawing.Point(0, 36);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(354, 230);
            this.pnlCadastro.TabIndex = 1;
            // 
            // FrmAncestralCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.tlstrpCadastro);
            this.Name = "FrmAncestralCadastro";
            this.Text = "FormAncestralCadastro";
            this.Load += new System.EventHandler(this.FrmAncestralCadastro_Load);
            this.tlstrpCadastro.ResumeLayout(false);
            this.tlstrpCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlstrpCadastro;
        private System.Windows.Forms.ToolStripButton tlstrpbtnNovo;
        private System.Windows.Forms.ToolStripButton tlstrpbtnProcurar;
        private System.Windows.Forms.ToolStripSeparator tlstrpbtnSeparador1;
        private System.Windows.Forms.ToolStripButton tlstrpbtnInserir;
        private System.Windows.Forms.ToolStripButton tlstrpbtnAlterar;
        private System.Windows.Forms.ToolStripButton tlstrpbtnExcluir;
        private System.Windows.Forms.ToolStripSeparator tlstrpbtnSeparador2;
        private System.Windows.Forms.ToolStripButton tlstrpbtnCancelar;
        public System.Windows.Forms.Panel pnlCadastro;
    }
}