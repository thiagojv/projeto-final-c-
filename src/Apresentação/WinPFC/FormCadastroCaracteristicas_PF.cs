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
    public partial class FrmCadastroCaracteristicas_PF : WinPFC.FrmAncestralCadastro
    {
        M_Caracteristicas_PF mcrctrstcspfModelo = new M_Caracteristicas_PF();

        public M_Caracteristicas_PF Modelo_Caracteristica_PF
        {
            get { return mcrctrstcspfModelo; }
            set { mcrctrstcspfModelo = value; }
        }

        public FrmCadastroCaracteristicas_PF()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Caracteristica_PF != null)
            {
                txtbxDescricao.Text = Modelo_Caracteristica_PF.Descricao;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Caracteristicas_PF ncrctrstcspfNegocio = new N_Caracteristicas_PF();

            if (ncrctrstcspfNegocio.Inserir(txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(ncrctrstcspfNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Caracteristicas_PF ncrctrstcspfNegocio = new N_Caracteristicas_PF();

            if (ncrctrstcspfNegocio.Alterar(Modelo_Caracteristica_PF.Codigo, txtbxDescricao.Text))
                LimparFormulario();

            MessageBox.Show(ncrctrstcspfNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Caracteristicas_PF ncrctrstcspfNegocio = new N_Caracteristicas_PF();

            if (ncrctrstcspfNegocio.Excluir(Modelo_Caracteristica_PF.Codigo))
                LimparFormulario();

            MessageBox.Show(ncrctrstcspfNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxDescricao.Clear();
        }

        protected override void Procurar()
        {
            FrmProcuraCaracteristicas_PF frmprcrcrctrstcspfProcura = new FrmProcuraCaracteristicas_PF();

            frmprcrcrctrstcspfProcura.ShowDialog();

            if (frmprcrcrctrstcspfProcura.Selecionado)
            {
                mcrctrstcspfModelo = frmprcrcrctrstcspfProcura.Caracteristica;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mcrctrstcspfModelo = null;
            base.Cancelar();
        }
    }
}

