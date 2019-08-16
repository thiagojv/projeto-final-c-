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
    public partial class FrmProcuraEscalasCOCOMO : WinPFC.FrmAncestralProcuraNome
    {
        M_Escalas_COCOMO msclscmModelo;

        public M_Escalas_COCOMO Escalas
        {
            get { return msclscmModelo; }
        }

        public FrmProcuraEscalasCOCOMO()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            msclscmModelo = (M_Escalas_COCOMO)ObterSelecao();
            if (msclscmModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Escalas"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Escalas_COCOMO> lstLista;
            N_Escalas_COCOMO nsclscmNegocio = new N_Escalas_COCOMO();

            try
            {
                lstLista = nsclscmNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nsclscmNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

