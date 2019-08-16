namespace WinPFC
{
    partial class FrmCadastroTipo_Distribuicao
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
            this.txtbxDescricao = new System.Windows.Forms.TextBox();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.pnlCadastro.Controls.Add(this.txtbxDescricao);
            this.pnlCadastro.Controls.Add(this.lblDescricao);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 8);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxDescricao
            // 
            this.txtbxDescricao.Location = new System.Drawing.Point(73, 4);
            this.txtbxDescricao.Name = "txtbxDescricao";
            this.txtbxDescricao.Size = new System.Drawing.Size(278, 20);
            this.txtbxDescricao.TabIndex = 1;
            // 
            // FrmCadastroTipo_Distribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroTipo_Distribuicao";
            this.Text = "Cadastro de Tipo de Distribuicao";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxDescricao;
        private System.Windows.Forms.Label lblDescricao;
    }
}
