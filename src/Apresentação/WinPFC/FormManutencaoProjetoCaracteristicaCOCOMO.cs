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
    public partial class FrmManutencaoProjetoCaracteristicaCOCOMO : WinPFC.FrmAncestralProjetoLista
    {
        public FrmManutencaoProjetoCaracteristicaCOCOMO()
        {
            InitializeComponent();
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();
            lstbxCaracteristicas.DataSource = (new N_Projeto_Caracteristicas_COCOMO()).CarregarCaracteristicas();
            lstbxCaracteristicas.DisplayMember = "Descricao";
            lstbxCaracteristicas.ValueMember = "Codigo";

            cmbxEscala.DataSource = (new N_Projeto_Caracteristicas_COCOMO()).CarregarEscalas();
            cmbxEscala.DisplayMember = "Descricao";
            cmbxEscala.ValueMember = "Codigo";
        }

        protected override void SelecionarRegistro()
        {
            base.SelecionarRegistro();

            int intCaracteristica = ((M_Caracteristicas_COCOMO)Selecionado).Codigo;
            List<M_Projeto_Caracteristicas_COCOMO> lstLista = (new N_Projeto_Caracteristicas_COCOMO()).Selecionar(Projeto_Selecionado, intCaracteristica);

            if ((lstLista != null) && (lstLista.Count > 0))
            {
                M_Projeto_Caracteristicas_COCOMO mprjtcrctrstcscmModelo = (M_Projeto_Caracteristicas_COCOMO)lstLista[0];

                if (mprjtcrctrstcscmModelo != null)
                    cmbxEscala.SelectedValue = mprjtcrctrstcscmModelo.COCOMO_Escala;
                else
                    cmbxEscala.SelectedValue = -1;
            }
            else
                cmbxEscala.SelectedValue = -1;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Projeto_Caracteristicas_COCOMO npjrtcrctrstcscmNegocio = new N_Projeto_Caracteristicas_COCOMO();

            if (npjrtcrctrstcscmNegocio.Inserir(Projeto_Selecionado, ((M_Caracteristicas_COCOMO)Selecionado).Codigo, (int)((M_Escalas_COCOMO)cmbxEscala.SelectedItem).Codigo));
            LimparFormulario();

            MessageBox.Show(npjrtcrctrstcscmNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Projeto_Caracteristicas_COCOMO npjrtcrctrstcscmNegocio = new N_Projeto_Caracteristicas_COCOMO();

            if (npjrtcrctrstcscmNegocio.Alterar(Projeto_Selecionado, ((M_Caracteristicas_COCOMO)Selecionado).Codigo, (int)((M_Escalas_COCOMO)cmbxEscala.SelectedItem).Codigo)) ;
            LimparFormulario();

            MessageBox.Show(npjrtcrctrstcscmNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Projeto_Caracteristicas_COCOMO npjrtcrctrstcscmNegocio = new N_Projeto_Caracteristicas_COCOMO();

            if (npjrtcrctrstcscmNegocio.Excluir(Projeto_Selecionado, ((M_Caracteristicas_COCOMO)Selecionado).Codigo));
            LimparFormulario();

            MessageBox.Show(npjrtcrctrstcscmNegocio.Mensagem);
        }

        protected override void Cancelar()
        {
            base.Cancelar();
            SelecionarRegistro();
        }
    }
}