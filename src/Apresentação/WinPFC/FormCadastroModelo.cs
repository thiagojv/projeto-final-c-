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
    public partial class FrmCadastroModelo : WinPFC.FrmAncestralCadastro
    {
        M_Modelo mdlModelo = new M_Modelo();

        public M_Modelo Modelo_Modelo
        {
            get { return mdlModelo; }
            set { mdlModelo = value; }
        }

        public FrmCadastroModelo()
        {
            InitializeComponent();
        }
    
        protected override bool CarregarDados()
        {
            if (Modelo_Modelo != null)
            {
                txtbxNome.Text = Modelo_Modelo.Nome;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Modelo nmdlNegocio = new N_Modelo();

            if (nmdlNegocio.Inserir(txtbxNome.Text))
                LimparFormulario();

            MessageBox.Show(nmdlNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Modelo nmdlNegocio = new N_Modelo();

            if (nmdlNegocio.Alterar(Modelo_Modelo.Codigo, txtbxNome.Text))
                LimparFormulario();

            MessageBox.Show(nmdlNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Modelo nmdlNegocio = new N_Modelo();

            if (nmdlNegocio.Excluir(Modelo_Modelo.Codigo))
                LimparFormulario();

            MessageBox.Show(nmdlNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNome.Clear();
        }

        protected override void Procurar()
        {
            FrmProcuraModelo frmprcrmdlProcura = new FrmProcuraModelo();

            frmprcrmdlProcura.ShowDialog();

            if (frmprcrmdlProcura.Selecionado)
            {
                mdlModelo = frmprcrmdlProcura.Modelo;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mdlModelo = null;
            base.Cancelar();
        }
    }
}

