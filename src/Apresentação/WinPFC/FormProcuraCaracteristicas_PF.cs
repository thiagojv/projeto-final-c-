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
    public partial class FrmProcuraCaracteristicas_PF : WinPFC.FrmAncestralProcuraNome
    {
        M_Caracteristicas_PF mcrctrstcspfModelo;

        public M_Caracteristicas_PF Caracteristica
        {
            get { return mcrctrstcspfModelo; }
        }

        public FrmProcuraCaracteristicas_PF()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mcrctrstcspfModelo = (M_Caracteristicas_PF)ObterSelecao();
            if (mcrctrstcspfModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Característica"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Caracteristicas_PF> lstLista;
            N_Caracteristicas_PF ncrctrstcspfModelo = new N_Caracteristicas_PF();

            try
            {
                lstLista = ncrctrstcspfModelo.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ncrctrstcspfModelo.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

