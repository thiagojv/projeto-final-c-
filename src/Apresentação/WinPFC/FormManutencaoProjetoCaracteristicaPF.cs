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
    public partial class FrmManutencaoProjetoCaracteristicaPF : WinPFC.FrmAncestralProjetoLista
    {
        public FrmManutencaoProjetoCaracteristicaPF()
        {
            InitializeComponent();
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();
            lstbxCaracteristicas.DataSource = (new N_Projeto_Caracteristicas_PF()).CarregarCaracteristicas();
            lstbxCaracteristicas.DisplayMember = "Descricao";
            lstbxCaracteristicas.ValueMember = "Codigo";

            cmbxNivelInfluencia.DataSource = (new N_Projeto_Caracteristicas_PF()).CarregarNiveisInfluencia();
            cmbxNivelInfluencia.DisplayMember = "Descricao";
            cmbxNivelInfluencia.ValueMember = "Codigo";
        }

        protected override void SelecionarRegistro()
        {
            base.SelecionarRegistro();

            int intCaracteristica = ((M_Caracteristicas_PF)Selecionado).Codigo;
            List<M_Projeto_Caracteristicas_PF> lstLista = (new N_Projeto_Caracteristicas_PF()).Selecionar(Projeto_Selecionado, intCaracteristica);

            if ((lstLista != null) && (lstLista.Count > 0))
            {
                M_Projeto_Caracteristicas_PF mprjtpfcrctrstcsModelo = (M_Projeto_Caracteristicas_PF)lstLista[0];

                if (mprjtpfcrctrstcsModelo != null)
                    cmbxNivelInfluencia.SelectedValue = mprjtpfcrctrstcsModelo.Nivel_Influencia;
                else
                    cmbxNivelInfluencia.SelectedValue = -1;
            }
            else
                cmbxNivelInfluencia.SelectedValue = -1;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Projeto_Caracteristicas_PF npjrtcrctrstcsNegocio = new N_Projeto_Caracteristicas_PF();

            if (npjrtcrctrstcsNegocio.Inserir(Projeto_Selecionado, ((M_Caracteristicas_PF)Selecionado).Codigo, (int)((M_Nivel_Influencia_PF)cmbxNivelInfluencia.SelectedItem).Codigo)) ;
                LimparFormulario();

            MessageBox.Show(npjrtcrctrstcsNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Projeto_Caracteristicas_PF npjrtcrctrstcsNegocio = new N_Projeto_Caracteristicas_PF();

            if (npjrtcrctrstcsNegocio.Alterar(Projeto_Selecionado, ((M_Caracteristicas_PF)Selecionado).Codigo, (int)((M_Nivel_Influencia_PF)cmbxNivelInfluencia.SelectedItem).Codigo));
            LimparFormulario();

            MessageBox.Show(npjrtcrctrstcsNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Projeto_Caracteristicas_PF npjrtcrctrstcsNegocio = new N_Projeto_Caracteristicas_PF();

            if (npjrtcrctrstcsNegocio.Excluir(Projeto_Selecionado, ((M_Caracteristicas_PF)Selecionado).Codigo));
            LimparFormulario();

            MessageBox.Show(npjrtcrctrstcsNegocio.Mensagem);
        }

        protected override void Cancelar()
        {
            base.Cancelar();
            SelecionarRegistro();
        }
    }
}

