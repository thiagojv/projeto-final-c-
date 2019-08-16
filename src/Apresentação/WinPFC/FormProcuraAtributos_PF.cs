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
    public partial class FrmProcuraAtributos_PF : WinPFC.FrmAncestralProcuraNome
    {
        M_Atributos_PF mtrbtspfModelo;

        public M_Atributos_PF Atributos
        {
            get { return mtrbtspfModelo; }
        }

        public FrmProcuraAtributos_PF()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mtrbtspfModelo = (M_Atributos_PF)ObterSelecao();
            if (mtrbtspfModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Escalas"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Atributos_PF> lstLista;
            N_Atributos_PF ntrbtspfNegocio = new N_Atributos_PF();

            try
            {
                lstLista = ntrbtspfNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ntrbtspfNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

