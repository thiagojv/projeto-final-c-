namespace WinPFC
{
    partial class FrmAncestralProjeto
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
            this.pnlProjeto = new System.Windows.Forms.Panel();
            this.cmbxProjeto = new System.Windows.Forms.ComboBox();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.pnlProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjeto
            // 
            this.pnlProjeto.Controls.Add(this.cmbxProjeto);
            this.pnlProjeto.Controls.Add(this.lblProjeto);
            this.pnlProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjeto.Location = new System.Drawing.Point(0, 0);
            this.pnlProjeto.Name = "pnlProjeto";
            this.pnlProjeto.Size = new System.Drawing.Size(292, 37);
            this.pnlProjeto.TabIndex = 4;
            // 
            // cmbxProjeto
            // 
            this.cmbxProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxProjeto.FormattingEnabled = true;
            this.cmbxProjeto.Location = new System.Drawing.Point(58, 8);
            this.cmbxProjeto.Name = "cmbxProjeto";
            this.cmbxProjeto.Size = new System.Drawing.Size(222, 21);
            this.cmbxProjeto.TabIndex = 1;
            this.cmbxProjeto.SelectedIndexChanged += new System.EventHandler(this.cmbxProjeto_SelectedIndexChanged);
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(12, 12);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(40, 13);
            this.lblProjeto.TabIndex = 0;
            this.lblProjeto.Text = "Projeto";
            // 
            // FrmAncestralProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.pnlProjeto);
            this.Name = "FrmAncestralProjeto";
            this.Load += new System.EventHandler(this.FormAncestralProjeto_Load);
            this.pnlProjeto.ResumeLayout(false);
            this.pnlProjeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.ComboBox cmbxProjeto;
        protected System.Windows.Forms.Panel pnlProjeto;
    }
}
