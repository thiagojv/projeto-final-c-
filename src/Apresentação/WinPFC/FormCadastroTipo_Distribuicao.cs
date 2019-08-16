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
    public partial class FrmCadastroTipo_Distribuicao : WinPFC.FrmAncestralCadastro
    {
        M_Tipo_Distribuicao mtpdstrbcModelo = new M_Tipo_Distribuicao();

        public M_Tipo_Distribuicao Modelo_Tipo_Distribuicao
        {
            get { return mtpdstrbcModelo; }
            set { mtpdstrbcModelo = value; }
        }

        public FrmCadastroTipo_Distribuicao()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Tipo_Distribuicao != null)
            {
                txtbxDescricao.Text = Modelo_Tipo_Distribuicao.Descricao;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Tipo_Distribuicao ntpdstrbcNegocio = new N_Tipo_Distribuicao();

            if (ntpdstrbcNegocio.Inserir(txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(ntpdstrbcNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Tipo_Distribuicao ntpdstrbcNegocio = new N_Tipo_Distribuicao();

            if (ntpdstrbcNegocio.Alterar(Modelo_Tipo_Distribuicao.Codigo, txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(ntpdstrbcNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Tipo_Distribuicao ntpdstrbcNegocio = new N_Tipo_Distribuicao();

            if (ntpdstrbcNegocio.Excluir(Modelo_Tipo_Distribuicao.Codigo))
                LimparFormulario();

            MessageBox.Show(ntpdstrbcNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxDescricao.Clear();
        }

        protected override void Procurar()
        {
            FrmProcuraTipo_Distribuicao frmprcrtpfndmntlProcura = new FrmProcuraTipo_Distribuicao();

            frmprcrtpfndmntlProcura.ShowDialog();

            if (frmprcrtpfndmntlProcura.Selecionado)
            {
                mtpdstrbcModelo = frmprcrtpfndmntlProcura.Tipo_Distribuicao;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mtpdstrbcModelo = null;
            base.Cancelar();
        }
    }
}