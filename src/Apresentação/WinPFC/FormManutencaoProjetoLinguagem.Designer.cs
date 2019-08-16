namespace WinPFC
{
    partial class FrmManutencaoProjetoLinguagem
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
            this.pnlLinguagem = new System.Windows.Forms.Panel();
            this.lstbxAssociados = new System.Windows.Forms.ListBox();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAdicionarTodos = new System.Windows.Forms.Button();
            this.lstbxDisponivel = new System.Windows.Forms.ListBox();
            this.pnlProjeto = new System.Windows.Forms.Panel();
            this.cmbxProjeto = new System.Windows.Forms.ComboBox();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.pnlLinguagem.SuspendLayout();
            this.pnlControle.SuspendLayout();
            this.pnlProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLinguagem
            // 
            this.pnlLinguagem.Controls.Add(this.lstbxAssociados);
            this.pnlLinguagem.Controls.Add(this.pnlControle);
            this.pnlLinguagem.Controls.Add(this.lstbxDisponivel);
            this.pnlLinguagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLinguagem.Location = new System.Drawing.Point(0, 31);
            this.pnlLinguagem.Name = "pnlLinguagem";
            this.pnlLinguagem.Size = new System.Drawing.Size(550, 237);
            this.pnlLinguagem.TabIndex = 2;
            // 
            // lstbxAssociados
            // 
            this.lstbxAssociados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxAssociados.FormattingEnabled = true;
            this.lstbxAssociados.Location = new System.Drawing.Point(295, 0);
            this.lstbxAssociados.Name = "lstbxAssociados";
            this.lstbxAssociados.Size = new System.Drawing.Size(255, 225);
            this.lstbxAssociados.TabIndex = 3;
            // 
            // pnlControle
            // 
            this.pnlControle.Controls.Add(this.btnRemoverTodos);
            this.pnlControle.Controls.Add(this.btnRemover);
            this.pnlControle.Controls.Add(this.btnAdicionar);
            this.pnlControle.Controls.Add(this.btnAdicionarTodos);
            this.pnlControle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControle.Location = new System.Drawing.Point(255, 0);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(40, 237);
            this.pnlControle.TabIndex = 4;
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Location = new System.Drawing.Point(6, 165);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(28, 23);
            this.btnRemoverTodos.TabIndex = 3;
            this.btnRemoverTodos.Text = "<<";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(6, 136);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(28, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 107);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(28, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = ">";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAdicionarTodos
            // 
            this.btnAdicionarTodos.Location = new System.Drawing.Point(6, 78);
            this.btnAdicionarTodos.Name = "btnAdicionarTodos";
            this.btnAdicionarTodos.Size = new System.Drawing.Size(28, 23);
            this.btnAdicionarTodos.TabIndex = 0;
            this.btnAdicionarTodos.Text = ">>";
            this.btnAdicionarTodos.UseVisualStyleBackColor = true;
            this.btnAdicionarTodos.Click += new System.EventHandler(this.btnAdicionarTodos_Click);
            // 
            // lstbxDisponivel
            // 
            this.lstbxDisponivel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstbxDisponivel.FormattingEnabled = true;
            this.lstbxDisponivel.Location = new System.Drawing.Point(0, 0);
            this.lstbxDisponivel.Name = "lstbxDisponivel";
            this.lstbxDisponivel.Size = new System.Drawing.Size(255, 225);
            this.lstbxDisponivel.TabIndex = 2;
            // 
            // pnlProjeto
            // 
            this.pnlProjeto.Controls.Add(this.cmbxProjeto);
            this.pnlProjeto.Controls.Add(this.lblProjeto);
            this.pnlProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjeto.Location = new System.Drawing.Point(0, 0);
            this.pnlProjeto.Name = "pnlProjeto";
            this.pnlProjeto.Size = new System.Drawing.Size(550, 31);
            this.pnlProjeto.TabIndex = 3;
            // 
            // cmbxProjeto
            // 
            this.cmbxProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxProjeto.FormattingEnabled = true;
            this.cmbxProjeto.Location = new System.Drawing.Point(58, 5);
            this.cmbxProjeto.Name = "cmbxProjeto";
            this.cmbxProjeto.Size = new System.Drawing.Size(480, 21);
            this.cmbxProjeto.TabIndex = 1;
            this.cmbxProjeto.SelectedIndexChanged += new System.EventHandler(this.cmbxProjeto_SelectedIndexChanged);
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(12, 9);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(40, 13);
            this.lblProjeto.TabIndex = 0;
            this.lblProjeto.Text = "Projeto";
            // 
            // FrmManutencaoProjetoLinguagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 268);
            this.Controls.Add(this.pnlLinguagem);
            this.Controls.Add(this.pnlProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmManutencaoProjetoLinguagem";
            this.Text = "Manutenção das linguagens no projeto";
            this.Load += new System.EventHandler(this.FrmCadastroProjetoLinguagem_Load);
            this.pnlLinguagem.ResumeLayout(false);
            this.pnlControle.ResumeLayout(false);
            this.pnlProjeto.ResumeLayout(false);
            this.pnlProjeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLinguagem;
        private System.Windows.Forms.ListBox lstbxAssociados;
        private System.Windows.Forms.Panel pnlControle;
        private System.Windows.Forms.Button btnRemoverTodos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAdicionarTodos;
        private System.Windows.Forms.ListBox lstbxDisponivel;
        private System.Windows.Forms.Panel pnlProjeto;
        private System.Windows.Forms.ComboBox cmbxProjeto;
        private System.Windows.Forms.Label lblProjeto;
    }
}
