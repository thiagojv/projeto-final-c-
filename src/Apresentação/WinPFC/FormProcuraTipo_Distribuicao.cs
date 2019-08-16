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
    public partial class FrmProcuraTipo_Distribuicao : WinPFC.FrmAncestralProcuraNome
    {
        M_Tipo_Distribuicao mtpdstrbcModelo;

        public M_Tipo_Distribuicao Tipo_Distribuicao
        {
            get { return mtpdstrbcModelo; }
        }

        public FrmProcuraTipo_Distribuicao()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mtpdstrbcModelo = (M_Tipo_Distribuicao)dtgrdvwProcura.SelectedRows[0].DataBoundItem;
            if (mtpdstrbcModelo == null)
                MessageBox.Show(string.Format(Mensagens.PROCURAR_FALHA, "Tipo de Distribuição"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Tipo_Distribuicao> lstLista;
            N_Tipo_Distribuicao ntpdstrbcNegocio = new N_Tipo_Distribuicao();

            try
            {
                lstLista = ntpdstrbcNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ntpdstrbcNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_ERRO + Ex.Message);
            }
        }
    }
}

