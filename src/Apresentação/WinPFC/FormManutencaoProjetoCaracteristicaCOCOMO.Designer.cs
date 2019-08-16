namespace WinPFC
{
    partial class FrmManutencaoProjetoCaracteristicaCOCOMO
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
            this.lblEscala = new System.Windows.Forms.Label();
            this.cmbxEscala = new System.Windows.Forms.ComboBox();
            this.pnlControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxCaracteristicas
            // 
            this.lstbxCaracteristicas.Size = new System.Drawing.Size(298, 342);
            // 
            // pnlControle
            // 
            this.pnlControle.Controls.Add(this.lblEscala);
            this.pnlControle.Controls.Add(this.cmbxEscala);
            this.pnlControle.Location = new System.Drawing.Point(298, 0);
            this.pnlControle.Size = new System.Drawing.Size(255, 352);
            this.pnlControle.Controls.SetChildIndex(this.cmbxEscala, 0);
            this.pnlControle.Controls.SetChildIndex(this.lblEscala, 0);
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Location = new System.Drawing.Point(10, 53);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(39, 13);
            this.lblEscala.TabIndex = 5;
            this.lblEscala.Text = "Escala";
            // 
            // cmbxEscala
            // 
            this.cmbxEscala.FormattingEnabled = true;
            this.cmbxEscala.Location = new System.Drawing.Point(55, 49);
            this.cmbxEscala.Name = "cmbxEscala";
            this.cmbxEscala.Size = new System.Drawing.Size(131, 21);
            this.cmbxEscala.TabIndex = 6;
            // 
            // FrmManutencaoProjetoCaracteristicaCOCOMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Name = "FrmManutencaoProjetoCaracteristicaCOCOMO";
            this.Text = "Manutenção de características do COCOMO";
            this.pnlControle.ResumeLayout(false);
            this.pnlControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.ComboBox cmbxEscala;
    }
}
