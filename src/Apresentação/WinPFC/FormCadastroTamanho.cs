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
    public partial class FrmCadastroTamanho : WinPFC.FrmAncestralCadastro
    {
        M_Tamanho mtmnhModelo = new M_Tamanho();

        public M_Tamanho Modelo_Tamanho
        {
            get { return mtmnhModelo; }
            set { mtmnhModelo = value; }
        }

        public FrmCadastroTamanho()
        {
            InitializeComponent();
        }
    
        protected override bool CarregarDados()
        {
            if (Modelo_Tamanho != null)
            {
                txtbxDescricao.Text = Modelo_Tamanho.Descricao;
                nmrcpdwnTamanho_Min.Value = (decimal)Modelo_Tamanho.Tamanho_Min;
                nmrcpdwnTamanho_Max.Value = (decimal)Modelo_Tamanho.Tamanho_Max;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Tamanho ntmnhNegocio = new N_Tamanho();

            if (ntmnhNegocio.Inserir(txtbxDescricao.Text, (double)nmrcpdwnTamanho_Min.Value, (double)nmrcpdwnTamanho_Max.Value))
                LimparFormulario();

            MessageBox.Show(ntmnhNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Tamanho ntmnhNegocio = new N_Tamanho();

            if (ntmnhNegocio.Alterar(Modelo_Tamanho.Codigo, txtbxDescricao.Text, (double)nmrcpdwnTamanho_Min.Value, (double)nmrcpdwnTamanho_Max.Value))
                LimparFormulario();

            MessageBox.Show(ntmnhNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Tamanho ntmnhNegocio = new N_Tamanho();

            if (ntmnhNegocio.Excluir(Modelo_Tamanho.Codigo))
                LimparFormulario();

            MessageBox.Show(ntmnhNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxDescricao.Clear();
            nmrcpdwnTamanho_Min.Value = 0;
            nmrcpdwnTamanho_Max.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraTamanho frmprcrtmnhProcura = new FrmProcuraTamanho();

            frmprcrtmnhProcura.ShowDialog(this.MdiParent);

            if (frmprcrtmnhProcura.Selecionado)
            {
                mtmnhModelo = frmprcrtmnhProcura.Tamanho;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mtmnhModelo = null;
            base.Cancelar();
        }
    }
}

