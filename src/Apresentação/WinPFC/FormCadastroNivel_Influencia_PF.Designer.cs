namespace WinPFC
{
    partial class FrmCadastroNivel_Influencia_PF
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtbxDescricao = new System.Windows.Forms.TextBox();
            this.nmrcpdwnNota = new System.Windows.Forms.NumericUpDown();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnNota)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.pnlCadastro.Controls.Add(this.nmrcpdwnNota);
            this.pnlCadastro.Controls.Add(this.txtbxDescricao);
            this.pnlCadastro.Controls.Add(this.lblNota);
            this.pnlCadastro.Controls.Add(this.lblDescricao);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 7);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(28, 33);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "Nota";
            // 
            // txtbxDescricao
            // 
            this.txtbxDescricao.Location = new System.Drawing.Point(64, 3);
            this.txtbxDescricao.Name = "txtbxDescricao";
            this.txtbxDescricao.Size = new System.Drawing.Size(278, 20);
            this.txtbxDescricao.TabIndex = 2;
            // 
            // nmrcpdwnNota
            // 
            this.nmrcpdwnNota.Location = new System.Drawing.Point(64, 29);
            this.nmrcpdwnNota.Name = "nmrcpdwnNota";
            this.nmrcpdwnNota.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnNota.TabIndex = 3;
            // 
            // FrmCadastroNivel_Influencia_PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroNivel_Influencia_PF";
            this.Text = "Cadastro de Níveis de Influência";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcpdwnNota;
        private System.Windows.Forms.TextBox txtbxDescricao;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblDescricao;
    }
}
