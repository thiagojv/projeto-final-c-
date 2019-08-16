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
    public partial class FrmManutencaoProjeto : WinPFC.FrmAncestralCadastro
    {
        M_Projeto mprjtModelo = new M_Projeto();

        public M_Projeto Modelo_Projeto
        {
            get { return mprjtModelo; }
            set { mprjtModelo = value; }
        }

        public FrmManutencaoProjeto()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Projeto != null)
            {
                txtbxNome.Text = Modelo_Projeto.Nome;
                dtmrpckrPeriodoInicial.Value = Modelo_Projeto.Data_Inicio;
                dtmrpckrPeriodoFinal.Value = Modelo_Projeto.Data_Termino;
                cmbxModelo.SelectedValue = Modelo_Projeto.Modelo;
                cmbxTipoFundamental.SelectedValue = Modelo_Projeto.Tipo_Fundamental;
                chckbxAtivo.Checked = Modelo_Projeto.Status;

                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Projeto nprjtNegocio = new N_Projeto();

            if (nprjtNegocio.Inserir(txtbxNome.Text, dtmrpckrPeriodoInicial.Value, dtmrpckrPeriodoFinal.Value, (int)cmbxModelo.SelectedValue, (int)cmbxTipoFundamental.SelectedValue, chckbxAtivo.Checked)) ;
                LimparFormulario();

            MessageBox.Show(nprjtNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Projeto nprjtNegocio = new N_Projeto();

            if (nprjtNegocio.Alterar(Modelo_Projeto.Codigo, txtbxNome.Text, dtmrpckrPeriodoInicial.Value, dtmrpckrPeriodoFinal.Value, (int)cmbxModelo.SelectedValue, (int)cmbxTipoFundamental.SelectedValue, chckbxAtivo.Checked)) ;
                LimparFormulario();

            MessageBox.Show(nprjtNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Projeto nprjtNegocio = new N_Projeto();

            if (nprjtNegocio.Excluir(Modelo_Projeto.Codigo))
                LimparFormulario();

            MessageBox.Show(nprjtNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNome.Clear();
            dtmrpckrPeriodoInicial.Value = DateTime.Now;
            dtmrpckrPeriodoFinal.Value = DateTime.Now;
            cmbxModelo.SelectedValue = -1;
            cmbxTipoFundamental.SelectedValue = -1;
            chckbxAtivo.Checked = false;
        }

        protected override void Procurar()
        {
            FrmProcuraProjeto frmprcrprjtProcura = new FrmProcuraProjeto();

            frmprcrprjtProcura.ShowDialog();

            if (frmprcrprjtProcura.Selecionado)
            {
                mprjtModelo = frmprcrprjtProcura.Projeto;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();

            cmbxModelo.DataSource = (new N_Projeto()).CarregarModelos();
            cmbxModelo.DisplayMember = "Nome";
            cmbxModelo.ValueMember = "Codigo";

            cmbxTipoFundamental.DataSource = (new N_Projeto()).CarregarTiposFundamentais();
            cmbxTipoFundamental.DisplayMember = "Nome";
            cmbxTipoFundamental.ValueMember = "Codigo";
        }

        protected override void Cancelar()
        {
            mprjtModelo = null;
            base.Cancelar();
        }
    }
}

