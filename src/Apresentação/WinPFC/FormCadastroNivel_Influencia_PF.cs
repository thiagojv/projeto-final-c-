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
    public partial class FrmCadastroNivel_Influencia_PF : WinPFC.FrmAncestralCadastro
    {
        M_Nivel_Influencia_PF mnvlnflncModelo = new M_Nivel_Influencia_PF();

        public M_Nivel_Influencia_PF Modelo_Nivel_Influencia
        {
            get { return mnvlnflncModelo; }
            set { mnvlnflncModelo = value; }
        }

        public FrmCadastroNivel_Influencia_PF()
        {
            InitializeComponent();
        }
    
        protected override bool CarregarDados()
        {
            if (Modelo_Nivel_Influencia != null)
            {
                txtbxDescricao.Text = Modelo_Nivel_Influencia.Descricao;
                nmrcpdwnNota.Value = Modelo_Nivel_Influencia.Nota;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Nivel_Influencia_PF nvlnflncNegocio = new N_Nivel_Influencia_PF();

            if (nvlnflncNegocio.Inserir(txtbxDescricao.Text, nmrcpdwnNota.Value))
                LimparFormulario();

            MessageBox.Show(nvlnflncNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Nivel_Influencia_PF nvlnflncNegocio = new N_Nivel_Influencia_PF();

            if (nvlnflncNegocio.Alterar(Modelo_Nivel_Influencia.Codigo, txtbxDescricao.Text, nmrcpdwnNota.Value))
                LimparFormulario();

            MessageBox.Show(nvlnflncNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Nivel_Influencia_PF nvlnflncNegocio = new N_Nivel_Influencia_PF();

            if (nvlnflncNegocio.Excluir(Modelo_Nivel_Influencia.Codigo))
                LimparFormulario();

            MessageBox.Show(nvlnflncNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxDescricao.Clear();
            nmrcpdwnNota.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraNivel_Influencia_PF frmprcrnvlnflncProcura = new FrmProcuraNivel_Influencia_PF();

            frmprcrnvlnflncProcura.ShowDialog();

            if (frmprcrnvlnflncProcura.Selecionado)
            {
                mnvlnflncModelo = frmprcrnvlnflncProcura.Nivel_Infuencia;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mnvlnflncModelo = null;
            base.Cancelar();
        }
    }
}

