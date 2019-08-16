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
    public partial class FrmManutencaoProjetoLinguagem : WinPFC.FrmAncestral
    {
        private int Projeto_Selecionado
        {
            get { return ((M_Projeto)cmbxProjeto.SelectedItem).Codigo; }
        }

        public FrmManutencaoProjetoLinguagem()
        {
            InitializeComponent();
        }

        private void FrmCadastroProjetoLinguagem_Load(object sender, EventArgs e)
        {
            N_Projeto_Linguagem nprjtlngmNegocio = new N_Projeto_Linguagem();

            cmbxProjeto.DataSource = nprjtlngmNegocio.CarregarProjetos();
            cmbxProjeto.DisplayMember = "Nome";
            cmbxProjeto.ValueMember = "Codigo";
        }

        private void cmbxProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Projeto_Selecionado > 0)
                AtualizarLinguagens(Projeto_Selecionado);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar(Projeto_Selecionado, (int)lstbxDisponivel.SelectedValue);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover(Projeto_Selecionado, (int)lstbxAssociados.SelectedValue);
        }

        private void Adicionar(int Projeto, int Linguagem)
        {
            (new N_Projeto_Linguagem()).Inserir(Projeto, Linguagem);
            AtualizarLinguagens(Projeto_Selecionado);
        }

        private void Remover(int Projeto, int Linguagem)
        {
            (new N_Projeto_Linguagem()).Excluir(Projeto, Linguagem);
            AtualizarLinguagens(Projeto_Selecionado);
        }

        private void AtualizarLinguagens(int Projeto)
        {
            N_Projeto_Linguagem nprjtlngmNegocio = new N_Projeto_Linguagem();

            lstbxDisponivel.DataSource = nprjtlngmNegocio.Selecionar(Projeto, true);
            lstbxDisponivel.DisplayMember = "NomeLinguagem";
            lstbxDisponivel.ValueMember = "Linguagem";

            lstbxAssociados.DataSource = nprjtlngmNegocio.Selecionar(Projeto, false);
            lstbxAssociados.DisplayMember = "NomeLinguagem";
            lstbxAssociados.ValueMember = "Linguagem";
        }

        private void btnAdicionarTodos_Click(object sender, EventArgs e)
        {
            foreach (M_Projeto_Linguagem mprjtlngmModelo in lstbxDisponivel.Items)
                Adicionar(Projeto_Selecionado, mprjtlngmModelo.Linguagem);
        }

        private void btnRemoverTodos_Click(object sender, EventArgs e)
        {
            foreach (M_Projeto_Linguagem mprjtlngmModelo in lstbxAssociados.Items)
                Remover(Projeto_Selecionado, mprjtlngmModelo.Linguagem);
        }
    }
}

