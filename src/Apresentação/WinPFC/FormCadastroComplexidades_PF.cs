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
    public partial class FrmCadastroComplexidades_PF : WinPFC.FrmAncestralCadastro
    {
        M_Complexidades_PF mcmplxdspfModelo = new M_Complexidades_PF();

        public M_Complexidades_PF Modelo_Complexidade_PF
        {
            get { return mcmplxdspfModelo; }
            set { mcmplxdspfModelo = value; }
        }

        public FrmCadastroComplexidades_PF()
        {
            InitializeComponent();
        }

        protected override bool CarregarDados()
        {
            if (Modelo_Complexidade_PF != null)
            {
                cmbxAtributo.SelectedValue = Modelo_Complexidade_PF.Atributo;
                nmrcpdwnParametro1Min.Value = Modelo_Complexidade_PF.Parametro1Min;
                nmrcpdwnParametro1Max.Value = Modelo_Complexidade_PF.Parametro1Max;
                nmrcpdwnParametro2Min.Value = Modelo_Complexidade_PF.Parametro2Min;
                nmrcpdwnParametro2Max.Value = Modelo_Complexidade_PF.Parametro2Max;
                nmrcpdwnParametro3Min.Value = Modelo_Complexidade_PF.Parametro3Min;
                nmrcpdwnParametro3Max.Value = Modelo_Complexidade_PF.Parametro3Max;
                nmrcpdwnParametro4Min.Value = Modelo_Complexidade_PF.Parametro4Min;
                nmrcpdwnParametro4Max.Value = Modelo_Complexidade_PF.Parametro4Max;
                txtbxNivel.Text = Modelo_Complexidade_PF.Nivel;
                nmrcpdwnPeso.Value = Modelo_Complexidade_PF.Peso;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Complexidades_PF ncmplxdspfNegocio = new N_Complexidades_PF();

            if (ncmplxdspfNegocio.Inserir((int)cmbxAtributo.SelectedValue,
                                            nmrcpdwnParametro1Min.Value, nmrcpdwnParametro1Max.Value,
                                            nmrcpdwnParametro2Min.Value, nmrcpdwnParametro2Max.Value,
                                            nmrcpdwnParametro3Min.Value, nmrcpdwnParametro3Max.Value,
                                            nmrcpdwnParametro4Min.Value, nmrcpdwnParametro4Max.Value,
                                            txtbxNivel.Text, nmrcpdwnPeso.Value))
                LimparFormulario();

            MessageBox.Show(ncmplxdspfNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Complexidades_PF ncmplxdspfNegocio = new N_Complexidades_PF();

            if (ncmplxdspfNegocio.Alterar((int)cmbxAtributo.SelectedValue, Modelo_Complexidade_PF.Codigo,
                                            nmrcpdwnParametro1Min.Value, nmrcpdwnParametro1Max.Value,
                                            nmrcpdwnParametro2Min.Value, nmrcpdwnParametro2Max.Value,
                                            nmrcpdwnParametro3Min.Value, nmrcpdwnParametro3Max.Value,
                                            nmrcpdwnParametro4Min.Value, nmrcpdwnParametro4Max.Value,
                                            txtbxNivel.Text, nmrcpdwnPeso.Value))
                LimparFormulario();

            MessageBox.Show(ncmplxdspfNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Complexidades_PF ncmplxdspfNegocio = new N_Complexidades_PF();

            if (ncmplxdspfNegocio.Excluir((int)cmbxAtributo.SelectedValue, Modelo_Complexidade_PF.Codigo))
                LimparFormulario();

            MessageBox.Show(ncmplxdspfNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            cmbxAtributo.SelectedIndex = -1;
            nmrcpdwnParametro1Min.Value = 0;
            nmrcpdwnParametro1Max.Value = 0;
            nmrcpdwnParametro2Min.Value = 0;
            nmrcpdwnParametro2Max.Value = 0;
            nmrcpdwnParametro3Min.Value = 0;
            nmrcpdwnParametro3Max.Value = 0;
            nmrcpdwnParametro4Min.Value = 0;
            nmrcpdwnParametro4Max.Value = 0;
            txtbxNivel.Clear();
            nmrcpdwnPeso.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraComplexidades_PF frmprcrcmplxdspfProcura = new FrmProcuraComplexidades_PF();

            frmprcrcmplxdspfProcura.ShowDialog();

            if (frmprcrcmplxdspfProcura.Selecionado)
            {
                mcmplxdspfModelo = frmprcrcmplxdspfProcura.Complexidade;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();

            List<M_Atributos_PF> lstLista = (new N_Complexidades_PF()).CarregarAtributos();
            M_Atributos_PF mtrbtspfAtributo = new M_Atributos_PF();

            mtrbtspfAtributo.Codigo = -1;
            lstLista.Insert(0, mtrbtspfAtributo);

            cmbxAtributo.DataSource = lstLista;
            cmbxAtributo.DisplayMember = "Nome";
            cmbxAtributo.ValueMember = "Codigo";
        }

        protected override void Cancelar()
        {
            mcmplxdspfModelo = null;
            base.Cancelar();
        }

        private void CarregarNomesParametro(M_Atributos_PF Atributo)
        {
            if (Atributo.Codigo >= 0)
            {
                lblParametro1.Text = Atributo.NomeParametro1;
                lblParametro2.Text = Atributo.NomeParametro2;

                if (Atributo.Estendido)
                {
                    ControlarCampos(true);

                    if (Atributo.NomeParametro3 != "")
                        lblParametro3.Text = Atributo.NomeParametro3;

                    if (Atributo.NomeParametro4 != "")
                        lblParametro4.Text = Atributo.NomeParametro4;
                }
                else
                    ControlarCampos(false);
            }
        }

        private void ControlarCampos(bool Habilitar)
        {
            lblParametro3.Enabled = Habilitar;
            lblParametro3A.Enabled = Habilitar;
            lblParametro4.Enabled = Habilitar;
            lblParametro4A.Enabled = Habilitar;
            nmrcpdwnParametro3Max.Enabled = Habilitar;
            nmrcpdwnParametro3Min.Enabled = Habilitar;
            nmrcpdwnParametro4Max.Enabled = Habilitar;
            nmrcpdwnParametro4Min.Enabled = Habilitar;
            lblParametro3.Text = "Parâmetro 3";
            lblParametro4.Text = "Parâmetro 4";
        }

        private void cmbxAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAtributo.SelectedItem != null)
                CarregarNomesParametro((M_Atributos_PF)cmbxAtributo.SelectedItem);
        }
    }
}

