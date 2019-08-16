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
    public partial class FrmCadastroAtributos_PF : WinPFC.FrmAncestralCadastro
    {
        M_Atributos_PF mtrbtspfModelo = new M_Atributos_PF();

        public M_Atributos_PF Modelo_Atributos_PF
        {
            get { return mtrbtspfModelo; }
            set { mtrbtspfModelo = value; }
        }

        public FrmCadastroAtributos_PF()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Atributos_PF != null)
            {
                txtbxNome.Text = Modelo_Atributos_PF.Nome;
                txtbxNomeParametro1.Text = Modelo_Atributos_PF.NomeParametro1;
                txtbxNomeParametro2.Text = Modelo_Atributos_PF.NomeParametro2;
                txtbxNomeParametro3.Text = Modelo_Atributos_PF.NomeParametro3;
                txtbxNomeParametro4.Text = Modelo_Atributos_PF.NomeParametro4;
                chckbxEstendido.Checked = Modelo_Atributos_PF.Estendido;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Atributos_PF ntrbtspfNegocio = new N_Atributos_PF();

            if (ntrbtspfNegocio.Inserir(txtbxNome.Text, txtbxNomeParametro1.Text, txtbxNomeParametro2.Text, txtbxNomeParametro3.Text, txtbxNomeParametro4.Text, chckbxEstendido.Checked))
                LimparFormulario();

            MessageBox.Show(ntrbtspfNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Atributos_PF ntrbtspfNegocio = new N_Atributos_PF();

            if (ntrbtspfNegocio.Alterar(Modelo_Atributos_PF.Codigo, txtbxNome.Text, txtbxNomeParametro1.Text, txtbxNomeParametro2.Text, txtbxNomeParametro3.Text, txtbxNomeParametro4.Text, chckbxEstendido.Checked))
                LimparFormulario();

            MessageBox.Show(ntrbtspfNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Atributos_PF ntrbtspfNegocio = new N_Atributos_PF();

            if (ntrbtspfNegocio.Excluir(Modelo_Atributos_PF.Codigo))
                LimparFormulario();

            MessageBox.Show(ntrbtspfNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNome.Clear();
            txtbxNomeParametro1.Clear();
            txtbxNomeParametro2.Clear();
            txtbxNomeParametro3.Clear();
            txtbxNomeParametro4.Clear();
            chckbxEstendido.Checked = false;
        }

        protected override void Procurar()
        {
            FrmProcuraAtributos_PF frmprcrtrbtspfProcura = new FrmProcuraAtributos_PF();

            frmprcrtrbtspfProcura.ShowDialog();

            if (frmprcrtrbtspfProcura.Selecionado)
            {
                mtrbtspfModelo = frmprcrtrbtspfProcura.Atributos;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mtrbtspfModelo = null;
            base.Cancelar();
        }

        private void chckbxEstendido_CheckedChanged(object sender, EventArgs e)
        {
            lblNomeParametro3.Enabled = chckbxEstendido.Checked;
            lblNomeParametro4.Enabled = chckbxEstendido.Checked;
            txtbxNomeParametro3.Enabled = chckbxEstendido.Checked;
            txtbxNomeParametro4.Enabled = chckbxEstendido.Checked;
        }
    }
}

