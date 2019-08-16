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
    public partial class FrmCadastroTipos_FundamentaisCOCOMO : WinPFC.FrmAncestralCadastro
    {
        M_Tipos_FundamentaisCOCOMO mtpsfndmntscmModelo = new M_Tipos_FundamentaisCOCOMO();

        public M_Tipos_FundamentaisCOCOMO Modelo_Tipo_Fundamental
        {
            get { return mtpsfndmntscmModelo; }
            set { mtpsfndmntscmModelo = value; }
        }

        public FrmCadastroTipos_FundamentaisCOCOMO()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Tipo_Fundamental != null)
            {
                txtbxNome.Text = Modelo_Tipo_Fundamental.Nome;
                nmrcpdwnFatorMultiplicacao.Value = (decimal)Modelo_Tipo_Fundamental.PrazoFatorMultiplicacao;
                nmrcpdwnExponencial.Value = (decimal)Modelo_Tipo_Fundamental.PrazoExponencial;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Tipos_FundamentaisCOCOMO ntpsfndmntsNegocio = new N_Tipos_FundamentaisCOCOMO();

            if (ntpsfndmntsNegocio.Inserir(txtbxNome.Text, (double)nmrcpdwnFatorMultiplicacao.Value, (double)nmrcpdwnExponencial.Value))
                LimparFormulario();

            MessageBox.Show(ntpsfndmntsNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Tipos_FundamentaisCOCOMO ntpsfndmntsNegocio = new N_Tipos_FundamentaisCOCOMO();

            if (ntpsfndmntsNegocio.Alterar(Modelo_Tipo_Fundamental.Codigo, txtbxNome.Text, (double)nmrcpdwnFatorMultiplicacao.Value, (double)nmrcpdwnExponencial.Value))
                LimparFormulario();

            MessageBox.Show(ntpsfndmntsNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Tipos_FundamentaisCOCOMO ntpsfndmntsNegocio = new N_Tipos_FundamentaisCOCOMO();

            if (ntpsfndmntsNegocio.Excluir(Modelo_Tipo_Fundamental.Codigo))
                LimparFormulario();

            MessageBox.Show(ntpsfndmntsNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNome.Clear();
            nmrcpdwnFatorMultiplicacao.Value = 0;
            nmrcpdwnExponencial.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraTipos_FundamentaisCOCOMO frmprcrtpsfndmntscmProcura = new FrmProcuraTipos_FundamentaisCOCOMO();

            frmprcrtpsfndmntscmProcura.ShowDialog();

            if (frmprcrtpsfndmntscmProcura.Selecionado)
            {
                mtpsfndmntscmModelo = frmprcrtpsfndmntscmProcura.Tipo_Fundamental;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mtpsfndmntscmModelo = null;
            base.Cancelar();
        }
    }
}

