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
    public partial class FrmProcuraProjetoAtributos : WinPFC.FrmAncestralProcuraProjeto
    {
        private M_Projeto_Atributo mprjtrbtModelo;

        public M_Projeto_Atributo Projeto_Atributo
        {
            get { return mprjtrbtModelo; }
        }

        public FrmProcuraProjetoAtributos()
        {
            InitializeComponent();
        }

        private void FrmProcuraProjetoAtributos_Load(object sender, EventArgs e)
        {
            if (Projeto >= 0)
                dtgrdvwProcura.DataSource = (new N_Projeto_Atributo()).Selecionar(Projeto);
            else
            {
                MessageBox.Show("Não existe um projeto selecionado!");
                Close();
            }
        }

        protected override void Selecionar()
        {
            mprjtrbtModelo = (M_Projeto_Atributo)ObterSelecao();
            if (mprjtrbtModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "atributo do projeto"));
            else
                base.Selecionar();

        }
    }
}

