namespace WinPFC
{
    partial class FrmCadastroTamanho
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
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblTamanhoA = new System.Windows.Forms.Label();
            this.txtbxDescricao = new System.Windows.Forms.TextBox();
            this.nmrcpdwnTamanho_Min = new System.Windows.Forms.NumericUpDown();
            this.nmrcpdwnTamanho_Max = new System.Windows.Forms.NumericUpDown();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnTamanho_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnTamanho_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.pnlCadastro.Controls.Add(this.nmrcpdwnTamanho_Max);
            this.pnlCadastro.Controls.Add(this.nmrcpdwnTamanho_Min);
            this.pnlCadastro.Controls.Add(this.txtbxDescricao);
            this.pnlCadastro.Controls.Add(this.lblTamanhoA);
            this.pnlCadastro.Controls.Add(this.lblTamanho);
            this.pnlCadastro.Controls.Add(this.lblDescricao);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 10);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(15, 36);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 1;
            this.lblTamanho.Text = "Tamanho";
            this.lblTamanho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTamanhoA
            // 
            this.lblTamanhoA.AutoSize = true;
            this.lblTamanhoA.Location = new System.Drawing.Point(179, 36);
            this.lblTamanhoA.Name = "lblTamanhoA";
            this.lblTamanhoA.Size = new System.Drawing.Size(13, 13);
            this.lblTamanhoA.TabIndex = 2;
            this.lblTamanhoA.Text = "a";
            this.lblTamanhoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxDescricao
            // 
            this.txtbxDescricao.Location = new System.Drawing.Point(73, 6);
            this.txtbxDescricao.Name = "txtbxDescricao";
            this.txtbxDescricao.Size = new System.Drawing.Size(269, 20);
            this.txtbxDescricao.TabIndex = 3;
            // 
            // nmrcpdwnTamanho_Min
            // 
            this.nmrcpdwnTamanho_Min.Location = new System.Drawing.Point(73, 32);
            this.nmrcpdwnTamanho_Min.Name = "nmrcpdwnTamanho_Min";
            this.nmrcpdwnTamanho_Min.Size = new System.Drawing.Size(100, 20);
            this.nmrcpdwnTamanho_Min.TabIndex = 4;
            // 
            // nmrcpdwnTamanho_Max
            // 
            this.nmrcpdwnTamanho_Max.Location = new System.Drawing.Point(198, 32);
            this.nmrcpdwnTamanho_Max.Name = "nmrcpdwnTamanho_Max";
            this.nmrcpdwnTamanho_Max.Size = new System.Drawing.Size(100, 20);
            this.nmrcpdwnTamanho_Max.TabIndex = 5;
            // 
            // FrmCadastroTamanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Name = "FrmCadastroTamanho";
            this.Text = "Cadastro de Tamanho";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnTamanho_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpdwnTamanho_Max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcpdwnTamanho_Max;
        private System.Windows.Forms.NumericUpDown nmrcpdwnTamanho_Min;
        private System.Windows.Forms.TextBox txtbxDescricao;
        private System.Windows.Forms.Label lblTamanhoA;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblDescricao;
    }
}
