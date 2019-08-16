namespace WinPFC
{
    partial class FrmAncestralProcura
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
            this.dtgrdvwProcura = new System.Windows.Forms.DataGridView();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProcura)).BeginInit();
            this.pnlComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdvwProcura
            // 
            this.dtgrdvwProcura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwProcura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvwProcura.Location = new System.Drawing.Point(0, 0);
            this.dtgrdvwProcura.Name = "dtgrdvwProcura";
            this.dtgrdvwProcura.Size = new System.Drawing.Size(292, 227);
            this.dtgrdvwProcura.TabIndex = 8;
            // 
            // pnlComandos
            // 
            this.pnlComandos.Controls.Add(this.btnCancelar);
            this.pnlComandos.Controls.Add(this.btnSelecionar);
            this.pnlComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComandos.Location = new System.Drawing.Point(0, 227);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(292, 39);
            this.pnlComandos.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.Location = new System.Drawing.Point(149, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSelecionar.Location = new System.Drawing.Point(68, 8);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FrmAncestralProcura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dtgrdvwProcura);
            this.Controls.Add(this.pnlComandos);
            this.Name = "FrmAncestralProcura";
            this.Load += new System.EventHandler(this.FormAncestralProcura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProcura)).EndInit();
            this.pnlComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionar;
        protected System.Windows.Forms.DataGridView dtgrdvwProcura;
    }
}
