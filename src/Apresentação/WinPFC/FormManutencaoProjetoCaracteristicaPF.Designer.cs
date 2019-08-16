namespace WinPFC
{
    partial class FrmManutencaoProjetoCaracteristicaPF
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblNivelInfluencia = new System.Windows.Forms.Label();
            this.cmbxNivelInfluencia = new System.Windows.Forms.ComboBox();
            this.pnlControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxCaracteristicas
            // 
            this.lstbxCaracteristicas.Size = new System.Drawing.Size(267, 238);
            // 
            // pnlControle
            // 
            this.pnlControle.Controls.Add(this.lblNivelInfluencia);
            this.pnlControle.Controls.Add(this.cmbxNivelInfluencia);
            this.pnlControle.Size = new System.Drawing.Size(252, 238);
            this.pnlControle.Controls.SetChildIndex(this.cmbxNivelInfluencia, 0);
            this.pnlControle.Controls.SetChildIndex(this.lblNivelInfluencia, 0);
            // 
            // lblNivelInfluencia
            // 
            this.lblNivelInfluencia.AutoSize = true;
            this.lblNivelInfluencia.Location = new System.Drawing.Point(6, 47);
            this.lblNivelInfluencia.Name = "lblNivelInfluencia";
            this.lblNivelInfluencia.Size = new System.Drawing.Size(97, 13);
            this.lblNivelInfluencia.TabIndex = 3;
            this.lblNivelInfluencia.Text = "Nível de Influência";
            // 
            // cmbxNivelInfluencia
            // 
            this.cmbxNivelInfluencia.FormattingEnabled = true;
            this.cmbxNivelInfluencia.Location = new System.Drawing.Point(109, 43);
            this.cmbxNivelInfluencia.Name = "cmbxNivelInfluencia";
            this.cmbxNivelInfluencia.Size = new System.Drawing.Size(131, 21);
            this.cmbxNivelInfluencia.TabIndex = 4;
            // 
            // FrmManutencaoProjetoCaracteristicaPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(519, 275);
            this.Name = "FrmManutencaoProjetoCaracteristicaPF";
            this.Text = "Manutenção de características de Pontos de Função";
            this.pnlControle.ResumeLayout(false);
            this.pnlControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNivelInfluencia;
        private System.Windows.Forms.ComboBox cmbxNivelInfluencia;

    }
}
