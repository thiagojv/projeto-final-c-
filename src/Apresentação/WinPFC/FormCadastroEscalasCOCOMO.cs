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
    public partial class FrmCadastroEscalasCOCOMO : WinPFC.FrmAncestralCadastro
    {
        M_Escalas_COCOMO msclscmModelo = new M_Escalas_COCOMO();

        public M_Escalas_COCOMO Modelo_Escalas_COCOMO
        {
            get { return msclscmModelo; }
            set { msclscmModelo = value; }
        }

        public FrmCadastroEscalasCOCOMO()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Escalas_COCOMO != null)
            {
                txtbxDescricao.Text = Modelo_Escalas_COCOMO.Descricao;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Escalas_COCOMO nsclscmNegocio = new N_Escalas_COCOMO();

            if (nsclscmNegocio.Inserir(txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(nsclscmNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Escalas_COCOMO nsclscmNegocio = new N_Escalas_COCOMO();

            if (nsclscmNegocio.Alterar(Modelo_Escalas_COCOMO.Codigo, txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(nsclscmNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Escalas_COCOMO nsclscmNegocio = new N_Escalas_COCOMO();

            if (nsclscmNegocio.Excluir(Modelo_Escalas_COCOMO.Codigo))
                LimparFormulario();

            MessageBox.Show(nsclscmNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxDescricao.Clear();
        }

        protected override void Procurar()
        {
            FrmProcuraEscalasCOCOMO frmprcrsclscmProcura = new FrmProcuraEscalasCOCOMO();

            frmprcrsclscmProcura.ShowDialog();

            if (frmprcrsclscmProcura.Selecionado)
            {
                msclscmModelo = frmprcrsclscmProcura.Escalas;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            msclscmModelo = null;
            base.Cancelar();
        }
    }
}

