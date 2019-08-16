namespace WinPFC
{
    partial class FrmAncestralProcuraIndice
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
            this.pnlProcura = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.cmbxIndice = new System.Windows.Forms.ComboBox();
            this.pnlProcura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProcura
            // 
            this.pnlProcura.Controls.Add(this.btnProcurar);
            this.pnlProcura.Controls.Add(this.cmbxIndice);
            this.pnlProcura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcura.Location = new System.Drawing.Point(0, 0);
            this.pnlProcura.Name = "pnlProcura";
            this.pnlProcura.Size = new System.Drawing.Size(292, 31);
            this.pnlProcura.TabIndex = 9;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(214, 4);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // cmbxIndice
            // 
            this.cmbxIndice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxIndice.FormattingEnabled = true;
            this.cmbxIndice.Location = new System.Drawing.Point(3, 5);
            this.cmbxIndice.Name = "cmbxIndice";
            this.cmbxIndice.Size = new System.Drawing.Size(205, 21);
            this.cmbxIndice.TabIndex = 0;
            // 
            // FrmAncestralProcuraIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.pnlProcura);
            this.Name = "FrmAncestralProcuraIndice";
            this.Text = "FormAncestralProcuraIndice";
            this.Controls.SetChildIndex(this.pnlProcura, 0);
            this.pnlProcura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        protected System.Windows.Forms.ComboBox cmbxIndice;
        protected System.Windows.Forms.Panel pnlProcura;

    }
}
