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
    public partial class FrmCadastroLinguagem : WinPFC.FrmAncestralCadastro
    {
        M_Linguagem mlngmModelo = new M_Linguagem();

        public M_Linguagem Modelo_Linguagem
        {
            get { return mlngmModelo; }
            set { mlngmModelo = value; }
        }

        public FrmCadastroLinguagem()
        {
            InitializeComponent();
        }
    
        protected override bool CarregarDados()
        {
            if (Modelo_Linguagem != null)
            {
                txtbxNome.Text = Modelo_Linguagem.Nome;
                nmrcpdwnEquivalente.Value = (decimal)Modelo_Linguagem.Equivalente_PF;
                return true;
            }
            else
                return false;
        }

        protected override void Inserir()
        {
            base.Inserir();
            N_Linguagem nlngmNegocio = new N_Linguagem();

            if (nlngmNegocio.Inserir((int)nmrcpdwnEquivalente.Value, txtbxNome.Text))
                LimparFormulario();

            MessageBox.Show(nlngmNegocio.Mensagem);
        }

        protected override void Alterar()
        {
            base.Alterar();
            N_Linguagem nlngmNegocio = new N_Linguagem();

            if (nlngmNegocio.Alterar(Modelo_Linguagem.Codigo, (int)nmrcpdwnEquivalente.Value, txtbxNome.Text))
                LimparFormulario();

            MessageBox.Show(nlngmNegocio.Mensagem);
        }

        protected override void Excluir()
        {
            base.Excluir();
            N_Linguagem nlngmNegocio = new N_Linguagem();

            if (nlngmNegocio.Excluir(Modelo_Linguagem.Codigo))
                LimparFormulario();

            MessageBox.Show(nlngmNegocio.Mensagem);
        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            txtbxNome.Clear();
            nmrcpdwnEquivalente.Value = 0;
        }

        protected override void Procurar()
        {
            FrmProcuraLinguagem frmprcrlngmProcura = new FrmProcuraLinguagem();

            frmprcrlngmProcura.ShowDialog();

            if (frmprcrlngmProcura.Selecionado)
            {
                mlngmModelo = frmprcrlngmProcura.Linguagem;
                CarregarDados();
                base.Procurar();
            }
            else
                Cancelar();
        }

        protected override void Cancelar()
        {
            mlngmModelo = null;
            base.Cancelar();
        }
    }
}

