namespace WinPFC
{
    partial class FrmAncestralProjetoLista
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lstbxCaracteristicas = new System.Windows.Forms.ListBox();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.tlstrpCadastro = new System.Windows.Forms.ToolStrip();
            this.tlstrpbtnInserir = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrpbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlDados.SuspendLayout();
            this.pnlControle.SuspendLayout();
            this.tlstrpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjeto
            // 
            this.pnlProjeto.Size = new System.Drawing.Size(509, 37);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lstbxCaracteristicas);
            this.pnlDados.Controls.Add(this.pnlControle);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 37);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(509, 352);
            this.pnlDados.TabIndex = 6;
            // 
            // lstbxCaracteristicas
            // 
            this.lstbxCaracteristicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxCaracteristicas.FormattingEnabled = true;
            this.lstbxCaracteristicas.Location = new System.Drawing.Point(0, 0);
            this.lstbxCaracteristicas.Name = "lstbxCaracteristicas";
            this.lstbxCaracteristicas.Size = new System.Drawing.Size(276, 342);
            this.lstbxCaracteristicas.TabIndex = 0;
            this.lstbxCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.lstbxCaracteristicas_SelectedIndexChanged);
            // 
            // pnlControle
            // 
            this.pnlControle.Controls.Add(this.tlstrpCadastro);
            this.pnlControle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControle.Location = new System.Drawing.Point(276, 0);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(233, 352);
            this.pnlControle.TabIndex = 1;
            // 
            // tlstrpCadastro
            // 
            this.tlstrpCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpbtnInserir,
            this.tlstrpbtnAlterar,
            this.tlstrpbtnExcluir,
            this.tlstrpbtnSeparador2,
            this.tlstrpbtnCancelar});
            this.tlstrpCadastro.Location = new System.Drawing.Point(0, 0);
            this.tlstrpCadastro.Name = "tlstrpCadastro";
            this.tlstrpCadastro.Size = new System.Drawing.Size(233, 36);
            this.tlstrpCadastro.TabIndex = 2;
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
            // FrmAncestralProjetoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(509, 389);
            this.Controls.Add(this.pnlDados);
            this.Name = "FrmAncestralProjetoLista";
            this.Controls.SetChildIndex(this.pnlProjeto, 0);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.pnlDados.ResumeLayout(false);
            this.pnlControle.ResumeLayout(false);
            this.pnlControle.PerformLayout();
            this.tlstrpCadastro.ResumeLayout(false);
            this.tlstrpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.ToolStrip tlstrpCadastro;
        private System.Windows.Forms.ToolStripButton tlstrpbtnInserir;
        private System.Windows.Forms.ToolStripButton tlstrpbtnAlterar;
        private System.Windows.Forms.ToolStripButton tlstrpbtnExcluir;
        private System.Windows.Forms.ToolStripSeparator tlstrpbtnSeparador2;
        private System.Windows.Forms.ToolStripButton tlstrpbtnCancelar;
        protected System.Windows.Forms.ListBox lstbxCaracteristicas;
        protected System.Windows.Forms.Panel pnlControle;
    }
}
