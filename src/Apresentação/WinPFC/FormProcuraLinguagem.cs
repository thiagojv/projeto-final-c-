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
    public partial class FrmProcuraLinguagem : WinPFC.FrmAncestralProcuraNome
    {
        M_Linguagem mlngmModelo;

        public M_Linguagem Linguagem
        {
            get { return mlngmModelo; }
        }

        public FrmProcuraLinguagem()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mlngmModelo = (M_Linguagem)ObterSelecao();
            if (mlngmModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Linguagem"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Linguagem> lstLista;
            N_Linguagem nlngmNegocio = new N_Linguagem();

            try
            {
                lstLista = nlngmNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nlngmNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

