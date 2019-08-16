namespace WinPFC
{
    partial class FrmCalculo_PF
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
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lblValorPF = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblValorSNI = new System.Windows.Forms.Label();
            this.lblSNI = new System.Windows.Forms.Label();
            this.lblValorSPFNA = new System.Windows.Forms.Label();
            this.lblSPFNA = new System.Windows.Forms.Label();
            this.pnlResultado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjeto
            // 
            this.pnlProjeto.Size = new System.Drawing.Size(335, 37);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.pnlResultados);
            this.pnlResultado.Controls.Add(this.panel1);
            this.pnlResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultado.Location = new System.Drawing.Point(0, 37);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(335, 79);
            this.pnlResultado.TabIndex = 5;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(10, 42);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(10, 13);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 79);
            this.panel1.TabIndex = 8;
            // 
            // pnlResultados
            // 
            this.pnlResultados.Controls.Add(this.lblValorPF);
            this.pnlResultados.Controls.Add(this.lblPF);
            this.pnlResultados.Controls.Add(this.lblValorSNI);
            this.pnlResultados.Controls.Add(this.lblSNI);
            this.pnlResultados.Controls.Add(this.lblValorSPFNA);
            this.pnlResultados.Controls.Add(this.lblSPFNA);
            this.pnlResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultados.Location = new System.Drawing.Point(0, 0);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(240, 79);
            this.pnlResultados.TabIndex = 9;
            // 
            // lblValorPF
            // 
            this.lblValorPF.AutoSize = true;
            this.lblValorPF.Location = new System.Drawing.Point(63, 53);
            this.lblValorPF.Name = "lblValorPF";
            this.lblValorPF.Size = new System.Drawing.Size(0, 13);
            this.lblValorPF.TabIndex = 11;
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(37, 53);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(22, 13);
            this.lblPF.TabIndex = 10;
            this.lblPF.Text = "PF";
            // 
            // lblValorSNI
            // 
            this.lblValorSNI.AutoSize = true;
            this.lblValorSNI.Location = new System.Drawing.Point(63, 33);
            this.lblValorSNI.Name = "lblValorSNI";
            this.lblValorSNI.Size = new System.Drawing.Size(0, 13);
            this.lblValorSNI.TabIndex = 9;
            // 
            // lblSNI
            // 
            this.lblSNI.AutoSize = true;
            this.lblSNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNI.Location = new System.Drawing.Point(31, 33);
            this.lblSNI.Name = "lblSNI";
            this.lblSNI.Size = new System.Drawing.Size(28, 13);
            this.lblSNI.TabIndex = 8;
            this.lblSNI.Text = "SNI";
            // 
            // lblValorSPFNA
            // 
            this.lblValorSPFNA.AutoSize = true;
            this.lblValorSPFNA.Location = new System.Drawing.Point(63, 13);
            this.lblValorSPFNA.Name = "lblValorSPFNA";
            this.lblValorSPFNA.Size = new System.Drawing.Size(0, 13);
            this.lblValorSPFNA.TabIndex = 7;
            // 
            // lblSPFNA
            // 
            this.lblSPFNA.AutoSize = true;
            this.lblSPFNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPFNA.Location = new System.Drawing.Point(12, 13);
            this.lblSPFNA.Name = "lblSPFNA";
            this.lblSPFNA.Size = new System.Drawing.Size(47, 13);
            this.lblSPFNA.TabIndex = 6;
            this.lblSPFNA.Text = "SPFNA";
            // 
            // FrmCalculo_PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(335, 116);
            this.Controls.Add(this.pnlResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCalculo_PF";
            this.Text = "Cálculo do tamanho em Pontos de Função";
            this.Controls.SetChildIndex(this.pnlProjeto, 0);
            this.Controls.SetChildIndex(this.pnlResultado, 0);
            this.pnlResultado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblValorPF;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblValorSNI;
        private System.Windows.Forms.Label lblSNI;
        private System.Windows.Forms.Label lblValorSPFNA;
        private System.Windows.Forms.Label lblSPFNA;
        private System.Windows.Forms.Panel panel1;
    }
}
