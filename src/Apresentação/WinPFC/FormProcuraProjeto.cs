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
    public partial class FrmProcuraProjeto : WinPFC.FrmAncestralProcuraNome
    {
        M_Projeto mprjtModelo;

        public M_Projeto Projeto
        {
            get { return mprjtModelo; }
        }

        public FrmProcuraProjeto()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mprjtModelo = (M_Projeto)ObterSelecao();
            if (mprjtModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Projeto"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Projeto> lstLista;
            N_Projeto nprjtNegocio = new N_Projeto();

            try
            {
                lstLista = nprjtNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nprjtNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

