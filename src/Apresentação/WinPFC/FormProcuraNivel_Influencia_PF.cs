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
    public partial class FrmProcuraNivel_Influencia_PF : WinPFC.FrmAncestralProcuraNome
    {
        M_Nivel_Influencia_PF mnvlnflncModelo;

        public M_Nivel_Influencia_PF Nivel_Infuencia
        {
            get { return mnvlnflncModelo; }
        }

        public FrmProcuraNivel_Influencia_PF()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mnvlnflncModelo = (M_Nivel_Influencia_PF)ObterSelecao();
            if (mnvlnflncModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Nível de Influência"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Nivel_Influencia_PF> lstLista;
            N_Nivel_Influencia_PF nnvlnflncNegocio = new N_Nivel_Influencia_PF();

            try
            {
                lstLista = nnvlnflncNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nnvlnflncNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}

