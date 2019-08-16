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
    public partial class FrmProcuraModelo : WinPFC.FrmAncestralProcuraNome
    {
        M_Modelo mdlModelo;

        public M_Modelo Modelo
        {
            get { return mdlModelo; }
        }

        public FrmProcuraModelo()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mdlModelo = (M_Modelo)ObterSelecao();
            if (mdlModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Modelo"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Modelo> lstLista;
            N_Modelo nmdlNegocio = new N_Modelo();

            try
            {
                lstLista = nmdlNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nmdlNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

