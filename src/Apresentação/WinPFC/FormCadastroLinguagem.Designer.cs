namespace WinPFC
{
    partial class FrmCadastroLinguagem
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
            this.lblEquivalente_PF = new System.Windows.Forms.Label();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.nmrcpdwnEquivalente = new System.Windows.Forms.NumericUpDown();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnEquivalente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.nmrcpdwnEquivalente);
            this.pnlCadastro.Controls.Add(this.txtbxNome);
            this.pnlCadastro.Controls.Add(this.lblEquivalente_PF);
            this.pnlCadastro.Controls.Add(this.lblNome);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(56, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquivalente_PF
            // 
            this.lblEquivalente_PF.AutoSize = true;
            this.lblEquivalente_PF.Location = new System.Drawing.Point(12, 40);
            this.lblEquivalente_PF.Name = "lblEquivalente_PF";
            this.lblEquivalente_PF.Size = new System.Drawing.Size(79, 13);
            this.lblEquivalente_PF.TabIndex = 1;
            this.lblEquivalente_PF.Text = "Equivalente PF";
            this.lblEquivalente_PF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxNome
            // 
            this.txtbxNome.Location = new System.Drawing.Point(97, 11);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(245, 20);
            this.txtbxNome.TabIndex = 2;
            // 
            // nmrcpdwnEquivalente
            // 
            this.nmrcpdwnEquivalente.Location = new System.Drawing.Point(97, 36);
            this.nmrcpdwnEquivalente.Name = "nmrcpdwnEquivalente";
            this.nmrcpdwnEquivalente.Size = new System.Drawing.Size(120, 20);
            this.nmrcpdwnEquivalente.TabIndex = 3;
            // 
            // FrmCadastroLinguagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroLinguagem";
            this.Text = "Cadastro de Linguagens";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnEquivalente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquivalente_PF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.NumericUpDown nmrcpdwnEquivalente;
    }
}
