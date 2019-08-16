namespace WinPFC
{
    partial class FrmAncestralProcuraNome
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
            this.tbcntrlProcura = new System.Windows.Forms.TabControl();
            this.tbpgNomeCompleto = new System.Windows.Forms.TabPage();
            this.btnNomeCompleto = new System.Windows.Forms.Button();
            this.txtbxNomeCompleto = new System.Windows.Forms.TextBox();
            this.tbpgNomeParcial = new System.Windows.Forms.TabPage();
            this.btnProcurarParcial = new System.Windows.Forms.Button();
            this.txtbxNomeParcial = new System.Windows.Forms.TextBox();
            this.tbcntrlProcura.SuspendLayout();
            this.tbpgNomeCompleto.SuspendLayout();
            this.tbpgNomeParcial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntrlProcura
            // 
            this.tbcntrlProcura.Controls.Add(this.tbpgNomeCompleto);
            this.tbcntrlProcura.Controls.Add(this.tbpgNomeParcial);
            this.tbcntrlProcura.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcntrlProcura.Location = new System.Drawing.Point(0, 0);
            this.tbcntrlProcura.Name = "tbcntrlProcura";
            this.tbcntrlProcura.SelectedIndex = 0;
            this.tbcntrlProcura.Size = new System.Drawing.Size(289, 60);
            this.tbcntrlProcura.TabIndex = 5;
            // 
            // tbpgNomeCompleto
            // 
            this.tbpgNomeCompleto.Controls.Add(this.btnNomeCompleto);
            this.tbpgNomeCompleto.Controls.Add(this.txtbxNomeCompleto);
            this.tbpgNomeCompleto.Location = new System.Drawing.Point(4, 22);
            this.tbpgNomeCompleto.Name = "tbpgNomeCompleto";
            this.tbpgNomeCompleto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgNomeCompleto.Size = new System.Drawing.Size(281, 34);
            this.tbpgNomeCompleto.TabIndex = 0;
            this.tbpgNomeCompleto.Text = "Nome Completo";
            this.tbpgNomeCompleto.UseVisualStyleBackColor = true;
            // 
            // btnNomeCompleto
            // 
            this.btnNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNomeCompleto.Location = new System.Drawing.Point(200, 6);
            this.btnNomeCompleto.Name = "btnNomeCompleto";
            this.btnNomeCompleto.Size = new System.Drawing.Size(75, 23);
            this.btnNomeCompleto.TabIndex = 3;
            this.btnNomeCompleto.Text = "Procurar";
            this.btnNomeCompleto.UseVisualStyleBackColor = true;
            this.btnNomeCompleto.Click += new System.EventHandler(this.btnNomeCompleto_Click);
            // 
            // txtbxNomeCompleto
            // 
            this.txtbxNomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxNomeCompleto.Location = new System.Drawing.Point(7, 7);
            this.txtbxNomeCompleto.Name = "txtbxNomeCompleto";
            this.txtbxNomeCompleto.Size = new System.Drawing.Size(186, 20);
            this.txtbxNomeCompleto.TabIndex = 2;
            // 
            // tbpgNomeParcial
            // 
            this.tbpgNomeParcial.Controls.Add(this.btnProcurarParcial);
            this.tbpgNomeParcial.Controls.Add(this.txtbxNomeParcial);
            this.tbpgNomeParcial.Location = new System.Drawing.Point(4, 22);
            this.tbpgNomeParcial.Name = "tbpgNomeParcial";
            this.tbpgNomeParcial.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgNomeParcial.Size = new System.Drawing.Size(281, 34);
            this.tbpgNomeParcial.TabIndex = 1;
            this.tbpgNomeParcial.Text = "Nome Parcial";
            this.tbpgNomeParcial.UseVisualStyleBackColor = true;
            // 
            // btnProcurarParcial
            // 
            this.btnProcurarParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarParcial.Location = new System.Drawing.Point(200, 6);
            this.btnProcurarParcial.Name = "btnProcurarParcial";
            this.btnProcurarParcial.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarParcial.TabIndex = 1;
            this.btnProcurarParcial.Text = "Procurar";
            this.btnProcurarParcial.UseVisualStyleBackColor = true;
            this.btnProcurarParcial.Click += new System.EventHandler(this.btnProcurarParcial_Click);
            // 
            // txtbxNomeParcial
            // 
            this.txtbxNomeParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxNomeParcial.Location = new System.Drawing.Point(7, 7);
            this.txtbxNomeParcial.Name = "txtbxNomeParcial";
            this.txtbxNomeParcial.Size = new System.Drawing.Size(186, 20);
            this.txtbxNomeParcial.TabIndex = 0;
            // 
            // FrmAncestralProcuraNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 266);
            this.Controls.Add(this.tbcntrlProcura);
            this.Name = "FrmAncestralProcuraNome";
            this.Text = "FormAncestralProcura";
            this.tbcntrlProcura.ResumeLayout(false);
            this.tbpgNomeCompleto.ResumeLayout(false);
            this.tbpgNomeCompleto.PerformLayout();
            this.tbpgNomeParcial.ResumeLayout(false);
            this.tbpgNomeParcial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntrlProcura;
        private System.Windows.Forms.TabPage tbpgNomeCompleto;
        private System.Windows.Forms.TabPage tbpgNomeParcial;
        private System.Windows.Forms.Button btnProcurarParcial;
        private System.Windows.Forms.Button btnNomeCompleto;
        protected System.Windows.Forms.TextBox txtbxNomeParcial;
        protected System.Windows.Forms.TextBox txtbxNomeCompleto;
    }
}