namespace WinPFC
{
    partial class FrmManutencaoProjetoHistorico
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
            this.dtgrdvwHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvwHistorico
            // 
            this.dtgrdvwHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdvwHistorico.Location = new System.Drawing.Point(0, 37);
            this.dtgrdvwHistorico.Name = "dtgrdvwHistorico";
            this.dtgrdvwHistorico.Size = new System.Drawing.Size(292, 229);
            this.dtgrdvwHistorico.TabIndex = 2;
            // 
            // FrmManutencaoProjetoHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dtgrdvwHistorico);
            this.Name = "FrmManutencaoProjetoHistorico";
            this.Text = "Manutenção do Histórico";
            this.Controls.SetChildIndex(this.dtgrdvwHistorico, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvwHistorico;
    }
}
