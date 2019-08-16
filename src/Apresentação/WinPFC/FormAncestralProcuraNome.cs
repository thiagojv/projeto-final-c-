using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralProcuraNome : FrmAncestralProcura
    {
        public FrmAncestralProcuraNome()
        {
            InitializeComponent();
        }

        protected override void CarregarFormulario()
        {
            tbpgNomeCompleto.Show();
            base.CarregarFormulario();
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNomeCompleto.Clear();
            txtbxNomeParcial.Clear();
        }

        protected virtual void ProcurarNomeCompleto(string Nome)
        {
            Procurar(Nome, false);
        }

        protected virtual void ProcurarNomeParcial(string Nome)
        {
            Procurar(Nome, true);
        }

        protected virtual void Procurar(string Nome, bool Parcial)
        {
            
        }

        private void btnNomeCompleto_Click(object sender, EventArgs e)
        {
            ProcurarNomeCompleto(txtbxNomeCompleto.Text);
        }

        private void btnProcurarParcial_Click(object sender, EventArgs e)
        {
            ProcurarNomeParcial(txtbxNomeParcial.Text);
        }
    }
}