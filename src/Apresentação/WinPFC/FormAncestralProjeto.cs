using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Modelo;

namespace WinPFC
{
    public partial class FrmAncestralProjeto : WinPFC.FrmAncestral
    {
        protected int Projeto_Selecionado
        {
            get { return ((M_Projeto)cmbxProjeto.SelectedItem).Codigo; }
        }

        public FrmAncestralProjeto()
        {
            InitializeComponent();
        }

        private void FormAncestralProjeto_Load(object sender, EventArgs e)
        {
            CarregarFormulario();
        }

        protected virtual void CarregarFormulario()
        {
            cmbxProjeto.DataSource = (new N_Projeto()).Carregar();
            cmbxProjeto.DisplayMember = "Nome";
            cmbxProjeto.ValueMember = "Codigo";
        }

        private void cmbxProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Projeto_Selecionado > 0)
                ExecutarAcao();
        }

        protected virtual void ExecutarAcao()
        {
          
        }
    }
}

