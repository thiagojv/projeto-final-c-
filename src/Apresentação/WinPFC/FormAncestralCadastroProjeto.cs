using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace WinPFC
{
    public partial class FrmAncestralCadastroProjeto : WinPFC.FrmAncestralCadastro
    {
        protected int Projeto_Selecionado
        {
            get { return ((M_Projeto)cmbxProjeto.SelectedItem).Codigo; }
        }

        public FrmAncestralCadastroProjeto()
        {
            InitializeComponent();
        }

        protected virtual void FormAncestralCadastroProjeto_Load(object sender, EventArgs e)
        {
            CarregarProjetos();
        }

        private void CarregarProjetos()
        {
            cmbxProjeto.DataSource = (new N_Projeto()).Carregar();
            cmbxProjeto.DisplayMember = "Nome";
            cmbxProjeto.ValueMember = "Codigo";
        }


        private void ExecutarAcao()
        {
        }

        private void cmbxProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Projeto_Selecionado > 0)
                ExecutarAcao();
        }
    }
}

