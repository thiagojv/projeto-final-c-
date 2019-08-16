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
    public partial class FrmProcuraTipos_FundamentaisCOCOMO : WinPFC.FrmAncestralProcuraNome
    {
        M_Tipos_FundamentaisCOCOMO mtpsfndmntscmModelo;

        public M_Tipos_FundamentaisCOCOMO Tipo_Fundamental
        {
            get { return mtpsfndmntscmModelo; }
        }

        public FrmProcuraTipos_FundamentaisCOCOMO()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mtpsfndmntscmModelo = (M_Tipos_FundamentaisCOCOMO)dtgrdvwProcura.SelectedRows[0].DataBoundItem;
            if (mtpsfndmntscmModelo == null)
                MessageBox.Show(string.Format(Mensagens.PROCURAR_FALHA, "Tipo Fundamental"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Tipos_FundamentaisCOCOMO> lstLista;
            N_Tipos_FundamentaisCOCOMO ntpsfndmntscmNegocio = new N_Tipos_FundamentaisCOCOMO();

            try
            {
                lstLista = ntpsfndmntscmNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ntpsfndmntscmNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_ERRO + Ex.Message);
            }
        }
    }
}

