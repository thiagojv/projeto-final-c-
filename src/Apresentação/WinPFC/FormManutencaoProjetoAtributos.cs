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
    public partial class FrmManutencaoProjetoAtributos : WinPFC.FrmAncestralCadastroProjeto
    {
        M_Projeto_Atributo mprjtrbtModelo = new M_Projeto_Atributo();

        public M_Projeto_Atributo Modelo_Projeto_Atributo
        {
            get { return mprjtrbtModelo; }
            set { mprjtrbtModelo = value; }
        }

        protected M_Atributos_PF Atributo
        {
            get { return (M_Atributos_PF)cmbxAtributo.SelectedItem; }
        }

        public FrmManutencaoProjetoAtributos()
        {
            InitializeComponent();
        }

        private void FrmCadastroProjetoAtributos_Load(object sender, EventArgs e)
        {
            cmbxAtributo.DataSource = (new N_Projeto_Atributo()).CarregarAtributos();
            cmbxAtributo.DisplayMember = "Nome";
            cmbxAtributo.ValueMember = "Codigo";
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Projeto_Atributo != null)
            {
                cmbxAtributo.SelectedValue = Modelo_Projeto_Atributo.Atributo;
                txtbxDescricao.Text = Modelo_Projeto_Atributo.Descricao;
                nmrcpdwnQuantidadeParametro1.Value = (decimal)Modelo_Projeto_Atributo.QuantidadeParametro1;
                nmrcpdwnQuantidadeParametro2.Value = (decimal)Modelo_Projeto_Atributo.QuantidadeParametro2;
                nmrcpdwnQuantidadeParametro3.Value = (decimal)Modelo_Projeto_Atributo.QuantidadeParametro3;
                nmrcpdwnQuantidadeParametro4.Value = (decimal)Modelo_Projeto_Atributo.QuantidadeParametro4;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Projeto_Atributo nprjtrbtNegocio = new N_Projeto_Atributo();

            int intComplexidade = nprjtrbtNegocio.SelecionarComplexidade((int)cmbxAtributo.SelectedValue, (double)nmrcpdwnQuantidadeParametro1.Value, (double)nmrcpdwnQuantidadeParametro2.Value, (double)nmrcpdwnQuantidadeParametro3.Value, (double)nmrcpdwnQuantidadeParametro4.Value, ((M_Atributos_PF)cmbxAtributo.SelectedItem).Estendido);

            if (nprjtrbtNegocio.Inserir(Projeto_Selecionado, (int)cmbxAtributo.SelectedValue, txtbxDescricao.Text, intComplexidade, (double)nmrcpdwnQuantidadeParametro1.Value, (double)nmrcpdwnQuantidadeParametro2.Value, (double)nmrcpdwnQuantidadeParametro3.Value, (double)nmrcpdwnQuantidadeParametro4.Value));
                LimparFormulario();

            MessageBox.Show(nprjtrbtNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Projeto_Atributo nprjtrbtNegocio = new N_Projeto_Atributo();

            int intComplexidade = nprjtrbtNegocio.SelecionarComplexidade((int)cmbxAtributo.SelectedValue, (double)nmrcpdwnQuantidadeParametro1.Value, (double)nmrcpdwnQuantidadeParametro2.Value, (double)nmrcpdwnQuantidadeParametro3.Value, (double)nmrcpdwnQuantidadeParametro4.Value, ((M_Atributos_PF)cmbxAtributo.SelectedItem).Estendido);

            if (nprjtrbtNegocio.Alterar(Projeto_Selecionado, Modelo_Projeto_Atributo.Codigo, (int)cmbxAtributo.SelectedValue, txtbxDescricao.Text, intComplexidade, (double)nmrcpdwnQuantidadeParametro1.Value, (double)nmrcpdwnQuantidadeParametro2.Value, (double)nmrcpdwnQuantidadeParametro3.Value, (double)nmrcpdwnQuantidadeParametro4.Value)) ;
                LimparFormulario();

            MessageBox.Show(nprjtrbtNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Projeto_Atributo nprjtrbtNegocio = new N_Projeto_Atributo();

            if (nprjtrbtNegocio.Excluir(Projeto_Selecionado, Modelo_Projeto_Atributo.Codigo));
                LimparFormulario();

            MessageBox.Show(nprjtrbtNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            cmbxAtributo.SelectedIndex = -1;
            txtbxDescricao.Clear();
            nmrcpdwnQuantidadeParametro1.Value = 0;
            nmrcpdwnQuantidadeParametro2.Value = 0;
            nmrcpdwnQuantidadeParametro3.Value = 0;
            nmrcpdwnQuantidadeParametro4.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraProjetoAtributos frmprcrprjtrbtsProcura = new FrmProcuraProjetoAtributos();

            frmprcrprjtrbtsProcura.Projeto = Projeto_Selecionado;
            frmprcrprjtrbtsProcura.ShowDialog();

            if (frmprcrprjtrbtsProcura.Selecionado)
            {
                mprjtrbtModelo = frmprcrprjtrbtsProcura.Projeto_Atributo;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mprjtrbtModelo = null;
            base.Cancelar();
        }

        private void CarregarNomesParametro(M_Atributos_PF Atributo)
        {
            if (Atributo.Codigo >= 0)
            {
                lblQuantidadeParametro1.Text = Atributo.NomeParametro1;
                lblQuantidadeParametro2.Text = Atributo.NomeParametro2;

                if (Atributo.Estendido)
                {
                    ControlarCampos(true);

                    if (Atributo.NomeParametro3 != "")
                        lblQuantidadeParametro3.Text = Atributo.NomeParametro3;

                    if (Atributo.NomeParametro4 != "")
                        lblQuantidadeParametro4.Text = Atributo.NomeParametro4;
                }
                else
                    ControlarCampos(false);
            }
        }

        private void ControlarCampos(bool Habilitar)
        {
            lblQuantidadeParametro3.Enabled = Habilitar;
            lblQuantidadeParametro4.Enabled = Habilitar;
            nmrcpdwnQuantidadeParametro3.Enabled = Habilitar;
            nmrcpdwnQuantidadeParametro4.Enabled = Habilitar;
            lblQuantidadeParametro3.Text = "Parâmetro 3";
            lblQuantidadeParametro4.Text = "Parâmetro 4";
        }

        private void cmbxAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAtributo.SelectedItem != null)
                CarregarNomesParametro((M_Atributos_PF)cmbxAtributo.SelectedItem);
        }
    }
}

