using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralProcura : WinPFC.FrmAncestral
    {
        private bool blnSelecionado = false;
        protected string strngMensagem;

        public FrmAncestralProcura()
        {
            InitializeComponent();
        }

        public bool Selecionado
        {
            get { return blnSelecionado; }
        }

        public string Mensagem
        {
            get { return strngMensagem; }
        }

        protected virtual void Selecionar()
        {
            blnSelecionado = true;
            Close();
        }

        protected virtual void Cancelar()
        {
            blnSelecionado = false;
            this.Close();
        }

        protected virtual void CarregarFormulario()
        {
            LimparFormulario();
        }

        protected virtual object ObterSelecao()
        {
            if (dtgrdvwProcura.SelectedRows.Count == 1)
            {
                return dtgrdvwProcura.SelectedRows[0].DataBoundItem;
            }
            else
                return null;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void FormAncestralProcura_Load(object sender, EventArgs e)
        {
            CarregarFormulario();
        }
    }
}

