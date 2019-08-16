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
    public partial class FrmCadastroEsforco : WinPFC.FrmAncestralCadastro
    {
        M_Esforco msfrcModelo = new M_Esforco();

        public M_Esforco Modelo_Esforco
        {
            get { return msfrcModelo; }
            set { msfrcModelo = value; }
        }

        public FrmCadastroEsforco()
        {
            InitializeComponent();
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();
            
            N_Esforco nsfrcNegocio = new N_Esforco();
            List<M_Modelo> lstModelo = nsfrcNegocio.CarregarModelos();
            List<M_Tipos_FundamentaisCOCOMO> lstTiposFundamentais = nsfrcNegocio.CarregarTiposFundamentais();

            M_Modelo mdlModelo = new M_Modelo();
            mdlModelo.Codigo = 0;

            M_Tipos_FundamentaisCOCOMO mtpsfndmntscmTiposFundamentais = new M_Tipos_FundamentaisCOCOMO();
            mtpsfndmntscmTiposFundamentais.Codigo = 0;

            lstModelo.Insert(0, mdlModelo);
            lstTiposFundamentais.Insert(0, mtpsfndmntscmTiposFundamentais);

            cmbxModelo.DataSource = lstModelo;
            cmbxModelo.DisplayMember = "Nome";
            cmbxModelo.ValueMember = "Codigo";

            cmbxTipoFundamental.DataSource = lstTiposFundamentais;
            cmbxTipoFundamental.DisplayMember = "Nome";
            cmbxTipoFundamental.ValueMember = "Codigo";
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Esforco != null)
            {
                cmbxModelo.SelectedValue = Modelo_Esforco.Modelo;
                cmbxTipoFundamental.SelectedValue = Modelo_Esforco.TipoFundamental;
                nmrcpwnFatorMultiplicacao.Value = (decimal)Modelo_Esforco.EsforcoFatorMultiplicacao;
                nmrcpdwnExponencial.Value = (decimal)Modelo_Esforco.EsforcoExponencial;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Esforco nsfrcNegocio = new N_Esforco();

            if (nsfrcNegocio.Inserir((int)cmbxModelo.SelectedValue, (int)cmbxTipoFundamental.SelectedValue, (double)nmrcpwnFatorMultiplicacao.Value, (double)nmrcpdwnExponencial.Value))
                LimparFormulario();

            MessageBox.Show(nsfrcNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Esforco nsfrcNegocio = new N_Esforco();

            if (nsfrcNegocio.Alterar(Modelo_Esforco.Modelo, Modelo_Esforco.TipoFundamental, (double)nmrcpwnFatorMultiplicacao.Value, (double)nmrcpdwnExponencial.Value))
                LimparFormulario();

            MessageBox.Show(nsfrcNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Esforco nsfrcNegocio = new N_Esforco();

            if (nsfrcNegocio.Excluir(Modelo_Esforco.Modelo, Modelo_Esforco.TipoFundamental))
                LimparFormulario();

            MessageBox.Show(nsfrcNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            cmbxModelo.SelectedValue = -1;
            cmbxTipoFundamental.SelectedValue = -1;
            nmrcpwnFatorMultiplicacao.Value = 0;
            nmrcpdwnExponencial.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraEsforco frmprcrsfrcProcura = new FrmProcuraEsforco();

            frmprcrsfrcProcura.ShowDialog();

            if (frmprcrsfrcProcura.Selecionado)
            {
                msfrcModelo = frmprcrsfrcProcura.Esforco;
                CarregarDados();
                cmbxModelo.Enabled = false;
                cmbxTipoFundamental.Enabled = false;
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            msfrcModelo = null;
            base.Cancelar();
        }

    }
}

