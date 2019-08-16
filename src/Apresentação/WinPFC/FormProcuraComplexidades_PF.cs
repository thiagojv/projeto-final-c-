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
    public partial class FrmProcuraComplexidades_PF : WinPFC.FrmAncestralProcuraIndice
    {
        private M_Complexidades_PF mcmplxdspfModelo;

        public M_Complexidades_PF Complexidade
        {
            get { return mcmplxdspfModelo; }
        }

        public FrmProcuraComplexidades_PF()
        {
            InitializeComponent();
        }

        protected override void CarregarIndice()
        {
            N_Complexidades_PF ncmplxdspfNegocio = new N_Complexidades_PF();

            base.CarregarIndice();
            cmbxIndice.DataSource = ncmplxdspfNegocio.CarregarAtributos();
            cmbxIndice.DisplayMember = "Nome";
            cmbxIndice.ValueMember = "Codigo";
        }

        protected override void Procurar(int Indice)
        {
            base.Procurar(Indice);
            List<M_Complexidades_PF> lstLista;
            N_Complexidades_PF ncmplxdspfModelo = new N_Complexidades_PF();

            try
            {
                lstLista = ncmplxdspfModelo.Selecionar(Indice);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ncmplxdspfModelo.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }

        protected override void Selecionar()
        {
            mcmplxdspfModelo = (M_Complexidades_PF)ObterSelecao();
            if (mcmplxdspfModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Complexidades"));
            else
                base.Selecionar();
        }
    }
}

